using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    interface IFigura
    {
        abstract public int Area();

        int SumaNumero();
    }

    abstract class FiguraAbs
    {
        public int lado = 0;

        abstract public int Perimetro();

        public int SumaNumeros()
        {
            return 2 + 2;
        }
    }

    class CuadradoAbs : FiguraAbs,IFigura
    {

        public CuadradoAbs(int _lado)
        {
            lado = _lado;
        }

        public int Area()
        {
            return lado * lado;
        }

        public override int Perimetro()
        {
            return lado * 4;
        }

        public int SumaNumero()
        {
            throw new NotImplementedException();
        }
    }
}
