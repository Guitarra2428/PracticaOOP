using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }


        public Persona(string nombre, DateTime fechaNacimiento, string ciudad)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
            Edad = CalcularEdad();
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

            return edad;
        }
 
        public  void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }
    }
}
