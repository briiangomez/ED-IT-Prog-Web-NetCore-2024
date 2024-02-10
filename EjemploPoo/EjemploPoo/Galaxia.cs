using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    public class Galaxia
    {
        public string Nombre { get; set; }

        public int MegaAniosLuz { get; set; }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} - Años Luz: {MegaAniosLuz}";
        }
    }
}
