using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoLibro.Entidades
{
    public class Libros:ICloneable
    {
        public string NombreLibro { get; set; }
        public Editorial Editorial { get; set; }
        public Tema Tema { get; set; }
        public int Paginas { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Libros))
            {
                return false;
            }
            return this.NombreLibro == ((Libros)obj).NombreLibro;
                  
        }
        public override int GetHashCode()
        {
            return NombreLibro.GetHashCode();
        }

    }
}
