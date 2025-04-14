using System;
using TriangleApp.Models;
using TriangleApp.Services;
using TriangleApp.UI;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = InputHelper.ReadPositiveDouble("Введите сторону A: ");
                double b = InputHelper.ReadPositiveDouble("Введите сторону B: ");
                double c = InputHelper.ReadPositiveDouble("Введите сторону C: ");

                Triangle triangle = new Triangle(a, b, c);
                Console.WriteLine(triangle);

                bool exists = TriangleValidator.Exists(triangle);
                Console.WriteLine("Треугольник существует? " + exists);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}