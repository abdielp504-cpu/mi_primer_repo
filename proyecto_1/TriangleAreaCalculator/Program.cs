using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Áreas Geométricas");
            Console.WriteLine("----------------------------------");

            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Calcular el área de un triángulo");
                Console.WriteLine("2. Calcular el área de un cuadrado");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateTriangleArea();
                        break;
                    case "2":
                        CalculateSquareArea();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }
            }
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("\n--- Área de un Triángulo ---");

            double Base, Altura;

            Console.Write("Ingrese la longitud de la base: ");
            while (!double.TryParse(Console.ReadLine(), out Base) || Base <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
                Console.Write("Ingrese la longitud de la base: ");
            }

            Console.Write("Ingrese la longitud de la altura: ");
            while (!double.TryParse(Console.ReadLine(), out Altura) || Altura <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
                Console.Write("Ingrese la longitud de la altura: ");
            }

            double Area = 0.5 * Base * Altura;
            Console.WriteLine($"El área del triángulo es: {Area}");
        }

        static void CalculateSquareArea()
        {
            Console.WriteLine("\n--- Área de un Cuadrado ---");

            double Lado;

            Console.Write("Ingrese la longitud de un lado del cuadrado: ");
            while (!double.TryParse(Console.ReadLine(), out Lado) || Lado <= 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
                Console.Write("Ingrese la longitud de un lado del cuadrado: ");
            }

            double Area = Lado * Lado;
            Console.WriteLine($"El área del cuadrado es: {Area}");
        }
    }
}
