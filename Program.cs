using System;
using TriangleApp.Models;
using TriangleApp.Services;


namespace TriangleApp
{
 class Program
    {
        static void Main(string[] args)
        {
            TriangleValidator validator = new TriangleValidator();

            Console.WriteLine("Введите длины сторон треугольника:");

            try
            {
                Console.Write("a = ");
                string inputA = Console.ReadLine();
                if (!double.TryParse(inputA, out double a) || a <= 0)
                    throw new ArgumentException("Сторона a должна быть положительным числом.");

                Console.Write("b = ");
                string inputB = Console.ReadLine();
                if (!double.TryParse(inputB, out double b) || b <= 0)
                    throw new ArgumentException("Сторона b должна быть положительным числом.");

                Console.Write("c = ");
                string inputC = Console.ReadLine();
                if (!double.TryParse(inputC, out double c) || c <= 0)
                    throw new ArgumentException("Сторона c должна быть положительным числом.");

                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine(triangle.ToString());
                Console.WriteLine("Существует: " + validator.Exists(triangle));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Непредвиденная ошибка: " + ex.Message);
            }
        }
    }
}
