namespace TriangleApp.Models
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get 
            { 
                return a;
            }
            set
            {
                if (value > 0)
                    a = value;
                else
                    throw new ArgumentException("Длина стороны должна быть положительной.");
            }
        }

        public double B
        {
            get 
            {
                return b;
            }
            set
            {
                if (value > 0)
                    b = value;
                else
                    throw new ArgumentException("Длина стороны должна быть положительной.");
            }
        }

        public double C
        {
            get 
            {
                    return c;
            }
            set
            {
                if (value > 0)
                    c = value;
                else
                    throw new ArgumentException("Длина стороны должна быть положительной.");
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длины сторон должны быть положительными.");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public override string ToString()
        {
            return $"Треугольник со сторонами: a={a}, b={b}, c={c}";
        }
    }

}

