using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoLibro.Entidades;

namespace TrabajoPracticoLibro.Datos
{
    public class RepositorioLibros
    {
        private List<Libros> ListaLibros;
        private ManejadorDeArchivo manejador; 
        private static RepositorioLibros Instancia=null;
        public static RepositorioLibros GetInstancia()
        {
            if (Instancia==null)
            {
                Instancia = new RepositorioLibros();
            }
            return Instancia;
        }
        public bool Existe(Libros libros)
        {
            return ListaLibros.Contains(libros);
        }

        public void Agregar(Libros libros)
        {
            manejador.AgregarEnArchivo(libros);
            ListaLibros.Add(libros);
        }
        public void Borrar(Libros Libros)
        {
            ListaLibros.Remove(Libros);
            manejador.BorrarRegistroEnARchivo(Libros);
        }
        public void Editar(Libros libros, Libros librosCopia)
        {
            manejador.EditarEnArchivo(libros, librosCopia);
            var Index = ListaLibros.IndexOf(libros);
            ListaLibros.RemoveAt(Index);
            ListaLibros.Insert(Index, librosCopia);

        }
        private RepositorioLibros()
        {
            manejador = new ManejadorDeArchivo();
            ListaLibros = new List<Libros>();
            ListaLibros = manejador.LeerDatosDelArchivo();
        }
        public List<Libros> GetLista()
        {
            return ListaLibros;
        }
        public int GetCantidad()
        {
            return ListaLibros.Count;
        }
      
        public   List<Libros> OrdenarPorAscPaginas()
        {
            return ListaLibros.OrderBy(l => l.Paginas).ToList();
        }

        public List<Libros> OrdenarPorDescPaginas()
        {
            return ListaLibros.OrderByDescending(l => l.Paginas).ToList();
        }

        public List<Libros> FiltrarPorTema(Tema tema)
        {
            return ListaLibros.Where(t => t.Tema == tema).ToList();
        }
        public List<Libros> FiltrarPorEditorial(Editorial editorial)
        {
            return ListaLibros.Where(E => E.Editorial == editorial).ToList();
           
        }
        public int GetCantidad(Editorial editorial)
        {
            return ListaLibros.Count(e=>e.Editorial==editorial);
        }
        public int GetCantidad(Tema tema)
        {
            return ListaLibros.Count(e => e.Tema == tema);
        }
    }
}
