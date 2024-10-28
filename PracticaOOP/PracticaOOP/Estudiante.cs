using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public string Matricula { get; set; }

        public Estudiante(string nombre, DateTime fechaNacimiento, string ciudad, string carrera, string matricula)
              : base(nombre, fechaNacimiento, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
        }

        public  void InformacionEstudiante()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }
}
