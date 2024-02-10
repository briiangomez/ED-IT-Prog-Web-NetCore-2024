using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    public class Triangulo : Figura
    {
        public Triangulo()
        {

        }


        public Triangulo(double lado) : base(lado)
        {

        }

        public Triangulo(double lado, double _base, double altura) : base(lado, _base, altura)
        {

        }


        public double CalcularPerimetro()
        {
            return base.CalcularPerimetro(3);
        }

        //Metodo propio de la clase
        public double CalcularArea()
        {
            return base.CalcularArea() / 2;
        }


    }
}
