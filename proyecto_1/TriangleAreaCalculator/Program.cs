using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Área de Triángulos");
            Console.WriteLine("----------------------------------");

            double Base;
            double Altura;
            double Area;

            // Solicitar la base del triángulo
            Console.Write("Ingrese la longitud de la base del triángulo: ");
            while (!double.TryParse(Console.ReadLine(), out Base) || Base <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo para la base.");
                Console.Write("Ingrese la longitud de la base del triángulo: ");
            }

            // Solicitar la altura del triángulo
            Console.Write("Ingrese la longitud de la altura del triángulo: ");
            while (!double.TryParse(Console.ReadLine(), out Altura) || Altura <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo para la altura.");
                Console.Write("Ingrese la longitud de la altura del triángulo: ");
            }

            // Calcular el área
            Area = 0.5 * Base * Altura;

            // Mostrar el resultado
            Console.WriteLine($"El área del triángulo es: {Area}");

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
