using TriangleApp.Models;

namespace TriangleApp.Services
{
    public class TriangleValidator
    {
        public static bool Exists(Triangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;

            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
