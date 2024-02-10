using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

    public class Alumno : Persona
    {
        public Alumno(string pNombre, string pApellido, bool pRegular)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Regular = pRegular;
        }
        public bool Regular { get; set; }
    }

    public class Instructor : Persona
    {
        public Instructor(string pNombre, string pApellido, List<Materia> pMaterias)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Materias = pMaterias;
        }
        public List<Materia> Materias { get; set; } //Relación muchos a muchos
    }

    public class Materia
    {
        public Materia(string pNombre, string pPrograma)
        {
            this.Nombre = pNombre;
            this.Programa = pPrograma;
        }
        public string Nombre { get; set; }
        public string Programa { get; set; }
    }

    public class Aula
    {
        public Aula(string pCodigo, int pCapacidad)
        {
            this.Codigo = pCodigo;
            this.Capacidad = pCapacidad;
        }
        public string Codigo { get; set; }
        public int Capacidad { get; set; }
    }


    public class Clase
    {
        public Clase(DateTime pInicio, DateTime pFin, Aula pAula)
        {
            this.Inicio = pInicio;
            this.Fin = pFin;
            this.Aula = pAula;
        }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Aula Aula { get; set; } //Relación 1 a 1
    }

    public class Curso
    {
        public List<Alumno> Alumnos { get; set; }

        public List<Instructor> Instructores { get; set; }

        public List<Clase> Clases { get; set; }

        public Materia Materia { get; set; }
    }
}
