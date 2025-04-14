namespace TriangleApp.UI
{
    public class InputHelper
    {
        public static double ReadPositiveDouble(string message)
        {
            double value;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.Write("Введите корректное положительное число: ");
            }
            return value;
        }
    }
}

