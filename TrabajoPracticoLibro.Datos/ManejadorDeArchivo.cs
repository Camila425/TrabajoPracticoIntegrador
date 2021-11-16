using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoLibro.Entidades;

namespace TrabajoPracticoLibro.Datos
{
    public class ManejadorDeArchivo
    {
        private readonly string _Archivo = Environment.CurrentDirectory + @"\Libros.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\Libros.Bak";

        public List<Libros> LeerDatosDelArchivo()
        {
            List<Libros> Lista = new List<Libros>();
            if (File.Exists(_Archivo))
            {
                StreamReader Lector = new StreamReader(_Archivo);
                while (!Lector.EndOfStream)
                {
                    var Linea = Lector.ReadLine();
                    Libros libros = ConstruirLibro(Linea);
                    Lista.Add(libros);

                }
                Lector.Close();

            }
            return Lista;
        }

        public void EditarEnArchivo(Libros libros, Libros librosCopia)
        {
            StreamReader Lector = new StreamReader(_Archivo);
            StreamWriter Escritor = new StreamWriter(_archivoBak);
            while (!Lector.EndOfStream)
            {
                var Linea = Lector.ReadLine();
                Libros librosEnArchivo = ConstruirLibro(Linea);
                if (!librosEnArchivo.Equals(libros))
                {
                    Escritor.WriteLine(Linea);
                }
                else
                {
                    Linea = ConstruirLinea(librosCopia);
                    Escritor.WriteLine(Linea);
                }
            }
            Lector.Close();
            Escritor.Close();
            File.Delete(_Archivo);
            File.Move(_archivoBak, _Archivo);

        }
        public void BorrarRegistroEnARchivo(Libros libros)
        {
            StreamReader Lector = new StreamReader(_Archivo);
            StreamWriter Escritor = new StreamWriter(_archivoBak);
            while (!Lector.EndOfStream)
            {
                var Linea = Lector.ReadLine();
                Libros LibroEnArchivo = ConstruirLibro(Linea);
                if (!LibroEnArchivo.Equals(libros))
                {
                    Escritor.WriteLine(Linea);
                }
            }
            Lector.Close();
            Escritor.Close();
            File.Delete(_Archivo);
            File.Move(_archivoBak, _Archivo);
        }
        private Libros ConstruirLibro(string linea)
        {
            var campos = linea.Split('|');
            return new Libros()
            {
                NombreLibro = campos[0],
                Editorial = (Editorial)int.Parse(campos[1]),
                Tema = (Tema)int.Parse(campos[2]),
                Paginas = int.Parse(campos[3]),
                ISBN = int.Parse(campos[4]),
                Autor = campos[5]

            };

        }
        public void AgregarEnArchivo(Libros libros)
        {
            StreamWriter Escritor = new StreamWriter(_Archivo, true);
            string Linea = ConstruirLinea(libros);
            Escritor.WriteLine(Linea);
            Escritor.Close();

        }

        private string ConstruirLinea(Libros libros)
        {
            return $"{libros.NombreLibro}|{libros.Editorial.GetHashCode()}|{libros.Tema.GetHashCode()}|" +
                   $"{libros.Paginas}|{libros.ISBN}|{libros.Autor}";

        }
    }
}
