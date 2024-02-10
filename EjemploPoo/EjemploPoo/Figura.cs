using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    public class Figura
    {
        //Constructores
        public Figura()
        {

        }

        public Figura(double lado)
        {
            Lado = lado;
        }

        public Figura(double lado, double _base, double altura)
        {
            Lado = lado;
            Base = _base;
            Altura = altura;
        }

        //Atributos
        protected double Lado { get; set; }

        protected double Base { get; set; }

        protected double Altura { get; set; }

        //Metodos
        public double CalcularPerimetro(int cantidadLados)
        {
            return Lado * cantidadLados;
        }


        protected string MostrarDatos(double lado)
        {
            return lado.ToString();
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
