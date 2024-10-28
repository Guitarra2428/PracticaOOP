using PracticaOOP;

Estudiante estudiante = new Estudiante("Luis Alberto Mesili", new DateTime(1995, 6, 20), "RD", "Ingeniería en Sistemas", "2022A001");


Figura rectangulo = new Rectangulo(5, 10);
Figura circulo = new Circulo(7);
Figura triangulo = new Triangulo(4, 8);

Console.WriteLine("Datos del estudiante:");
estudiante.MostrarInformacion();  
Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());