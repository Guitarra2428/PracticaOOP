using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    internal class Rectangulo : Figura
    {
        public double Altura { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double altura, double ancho)
        {
            Altura = altura;
            Ancho = ancho;
        }
        public override double CalcularArea()
        {
           return Altura * Ancho;   
        }
    }
}
