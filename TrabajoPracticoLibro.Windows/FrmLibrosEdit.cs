using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoLibro.Entidades;

namespace TrabajoPracticoLibro.Windows
{
    public partial class FrmLibrosEdit : Form
    {
        public FrmLibrosEdit()
        {
            InitializeComponent();
        }

        private Libros libros;

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;
        }

        public Libros GetLibro()
        {
            return libros;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboEditorial(ref EditorialcomboBox);
            CargarDatosComboTema(ref TemacomboBox);
            if (libros!=null)
            {
                NombreDelLibrotextBox.Text = libros.NombreLibro.ToString();
                EditorialcomboBox.SelectedItem = libros.Editorial;
                TemacomboBox.SelectedItem = libros.Tema;
                PaginastextBox.Text = libros.Paginas.ToString();
                ISBNtextBox.Text = libros.ISBN.ToString();
                AutortextBox.Text = libros.Autor.ToString();
            }
           
        }

        private void CargarDatosComboTema(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Tema));
        }

        private void CargarDatosComboEditorial(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Editorial));
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
                if (libros==null)
                {
                    libros = new Libros();
                }
                libros.NombreLibro = NombreDelLibrotextBox.Text.ToString();
                libros.Editorial = (Editorial)EditorialcomboBox.SelectedItem;
                libros.Tema = (Tema)TemacomboBox.SelectedItem;
                 libros.Paginas =int.Parse( PaginastextBox.Text);
                libros.ISBN =int.Parse( ISBNtextBox.Text);
                libros.Autor = AutortextBox.Text.ToString();
                DialogResult = DialogResult.OK;

            
        }
        public void SetLibro(Libros librosCopia)
        {
            this.libros = librosCopia;
        }

        private void NombreDelLibrotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PaginastextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ISBNtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AutortextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
