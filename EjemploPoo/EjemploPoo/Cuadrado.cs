using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    public class Cuadrado : Figura
    {

        //Constructores
        public Cuadrado()
        {

        }

        public double Perimetro
        {
            private set { }
            get
            {
                return Lado * 4;
            }
           
        }

        public Cuadrado(double lado) : base(lado)
        {
            
        }

        public Cuadrado(double lado, double _base, double altura) : base(lado,_base,altura)
        {

        }

        public double CalcularPerimetro()
        {
            return base.CalcularPerimetro(4);
        }


    }
}
