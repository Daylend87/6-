namespace TriangleApp.Models
{
    public class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public double SideA
        {
            get => _sideA;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона A должна быть больше нуля.");
                _sideA = value;
            }
        }

        public double SideB
        {
            get => _sideB;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона B должна быть больше нуля.");
                _sideB = value;
            }
        }

        public double SideC
        {
            get => _sideC;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона C должна быть больше нуля.");
                _sideC = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public Triangle() : this(1, 1, 1)
        {
        }

        public bool Exists()
        {
            return (SideA + SideB > SideC) &&
                   (SideA + SideC > SideB) &&
                   (SideB + SideC > SideA);
        }

        public override string ToString()
        {
            return $"Треугольник: A = {SideA}, B = {SideB}, C = {SideC}";
        }
    }
}


