using TriangleApp.Models;

namespace TriangleApp.Services
{
    public class TriangleValidator
    {
        public bool Exists(Triangle triangle)
        {
            if (triangle == null)
                throw new ArgumentNullException("Треугольник не может быть пустым.");

            double a = triangle.A;
            double b = triangle.B;
            double c = triangle.C;

            if (a == 0 || b == 0 || c == 0)
                return false;

            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}

