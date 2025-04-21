using System;
using TriangleApp.Models;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите сторону a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Введите сторону b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Введите сторону c: ");
                double c = double.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(a, b, c);

                Console.WriteLine(triangle.ToString());

                if (triangle.Exists())
                    Console.WriteLine("Треугольник с такими сторонами существует.");
                else
                    Console.WriteLine("Треугольник с такими сторонами НЕ существует.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}

