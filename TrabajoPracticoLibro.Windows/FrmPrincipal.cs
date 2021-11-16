using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoLibro.Datos;
using TrabajoPracticoLibro.Entidades;

namespace TrabajoPracticoLibro.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private List<Libros> Lista;
        private int CantidadDeRegistros;
        private void SalirtoolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmLibrosEdit frm = new FrmLibrosEdit(){ Text="Agregar Nuevo Libro"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            Libros libros = frm.GetLibro();

            if (RepositorioLibros.GetInstancia().Existe(libros))
            {
                MessageBox.Show("Libro Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RepositorioLibros.GetInstancia().Agregar(libros);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, libros);
            AgregarFila(r);
            ActualizarCantidadRegistros();
             
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosdataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Libros libros)
        {
            r.Cells[ColNombreDelLibro.Index].Value = libros.NombreLibro.ToString();
            r.Cells[ColEditorial.Index].Value = libros.Editorial;
            r.Cells[ColTema.Index].Value = libros.Tema;
            r.Cells[ColPaginas.Index].Value = libros.Paginas;
            r.Cells[ColISBN.Index].Value = libros.ISBN;
            r.Cells[ColAutor.Index].Value = libros.Autor.ToString();
            r.Tag = libros;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosdataGridView);
            return r;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosComboTema();
            CargarDatosComboEditorial();
            RepositorioLibros.GetInstancia();
            Lista = RepositorioLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
            
        }

        private void CargarDatosComboEditorial()
        {
            var ListaDeEditorial = Enum.GetValues(typeof(Editorial)).Cast<Editorial>().ToList();
            foreach (var Editorial in ListaDeEditorial)
            {
                EditorialtoolStripComboBox.Items.Add(Editorial);
            }
        }

        private void CargarDatosComboTema()
        {
            var ListaDeTemas = Enum.GetValues(typeof(Tema)).Cast<Tema>().ToList();
            foreach (var Tema in ListaDeTemas)
            {
                TematoolStripComboBox.Items.Add(Tema);
            }
        }

        public void ActualizarCantidadRegistros()
        {
            CantidadDeRegistros = RepositorioLibros.GetInstancia().GetCantidad();
            CantidadDeRegistroslabel.Text = CantidadDeRegistros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosdataGridView.Rows.Clear();
            foreach (var libros in Lista)
            {
                var r = ConstruirFila();
                SetearFila(r, libros);
                AgregarFila(r);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosdataGridView.SelectedRows[0];
            Libros libros = (Libros)r.Tag;

            DialogResult dr = MessageBox.Show("Borrar El Registro", "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            RepositorioLibros.GetInstancia().Borrar(libros);
            DatosdataGridView.Rows.Remove(r);
            MessageBox.Show("Registro Borrado", "Mensaje", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            ActualizarCantidadRegistros();
        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow r = DatosdataGridView.SelectedRows[0];
            Libros libros = (Libros)r.Tag;

            Libros librosCopia = (Libros)libros.Clone();

            FrmLibrosEdit frm = new FrmLibrosEdit() { Text = "Modificar Un Libro"};
            frm.SetLibro(librosCopia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                librosCopia = frm.GetLibro();
                if (!RepositorioLibros.GetInstancia().Existe(librosCopia))
                {
                    SetearFila(r, librosCopia);
                    RepositorioLibros.GetInstancia().Editar(libros, librosCopia);
                    MessageBox.Show("Libro Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Libro Repetido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SetearFila(r, libros);
                }
            }
        }

        private void ascPorPaginasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista = RepositorioLibros.GetInstancia().OrdenarPorAscPaginas();
            MostrarDatosEnGrilla();
        }

        private void descToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista = RepositorioLibros.GetInstancia().OrdenarPorDescPaginas();
            MostrarDatosEnGrilla();
        }

        private void TematoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TematoolStripComboBox.SelectedIndex==-1)
            {
                return;
            }
            Tema tema = (Tema)TematoolStripComboBox.SelectedItem;
            Lista = RepositorioLibros.GetInstancia().FiltrarPorTema(tema);
            MostrarDatosEnGrilla();

            CantidadDeRegistros=RepositorioLibros.GetInstancia().GetCantidad(tema);
            CantidadDeRegistroslabel.Text = CantidadDeRegistros.ToString();
        }

        private void EditorialtoolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditorialtoolStripComboBox.SelectedIndex==-1)
            {
                return;
            }
            Editorial editorial = (Editorial)EditorialtoolStripComboBox.SelectedItem;
            Lista = RepositorioLibros.GetInstancia().FiltrarPorEditorial(editorial);
            MostrarDatosEnGrilla();
            CantidadDeRegistros=RepositorioLibros.GetInstancia().GetCantidad(editorial);
            CantidadDeRegistroslabel.Text = CantidadDeRegistros.ToString();
        }


        private void ActualizartoolStripButton_Click(object sender, EventArgs e)
        {
            Lista = RepositorioLibros.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros();
        }
    }
}
