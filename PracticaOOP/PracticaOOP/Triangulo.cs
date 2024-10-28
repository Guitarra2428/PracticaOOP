using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP
{
    public class Triangulo: Figura
    {
        public Triangulo(double sbase, double altura)
        {
            _Base = sbase;
            _Altura = altura;
        }

        public double _Base { get; set; }
        public double _Altura { get; set; }
       

        public override double CalcularArea()
        {
            return (_Base * _Altura) / 2;
        }
    }
}
