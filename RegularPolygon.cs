namespace VP_Pract2
{
    public class RegularPolygon : Figure
    {
        private int numberOfSides;
        private double sideLength;
        public int NumberOfSides
        {
            get
            {
                return numberOfSides;
            }
            set
            {
                if (value > 0)
                {
                    numberOfSides = value;
                }
                else
                {
                    throw new Exception("Number of sides must be greater than 0");
                }

            }
        }
        public double SideLength
        {
            get
            {
                return sideLength;
            }
            set
            {
                if (value > 0)
                {
                    sideLength = value;
                }
                else
                {
                    throw new Exception("Side of Regular polygon must be greater than 0");
                }

            }
        }

        public RegularPolygon(int numberOfSides, double sideLength, string color) : base($"Правильный {numberOfSides}-угольник", color)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public override double Perimeter
        {
            get
            {
                return NumberOfSides * SideLength;
            }
        }

        public override double Area
        {
            get
            {
                double R = SideLength / (2 * Math.Tan(Math.PI / NumberOfSides));
                return 0.5 * NumberOfSides * SideLength * R;
            }
        }
    }
    public class Square : RegularPolygon
    {
        public Square(double sideLength, string color) : base(4, sideLength, color)
        {
            Name = "Квадрат";
        }
    }

    // Класс Треугольник
    public class Triangle : RegularPolygon
    {
        public Triangle(double sideLength, string color) : base(3, sideLength, color)
        {
            Name = "Треугольник";
        }
    }
}
