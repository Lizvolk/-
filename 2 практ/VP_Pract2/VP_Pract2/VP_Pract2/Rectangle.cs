namespace VP_Pract2
{
    public class Parallelogram : Figure
    {
        private double sideA;
        private double sideB;
        private double height;
        public double SideA {
            get
            {
                return sideA;
            }
            set
            {
                if (value > 0)
                {
                    sideA = value;
                }
                else
                {
                    throw new Exception("Side of Parallelogram must be greater than 0");
                }

            }
        }
        public double SideB {
            get
            {
                return sideB;
            }
            set
            {
                if (value > 0)
                {
                    sideB = value;
                }
                else
                {
                    throw new Exception("Side of Parallelogram must be greater than 0");
                }

            }
        }
        public double Height {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new Exception("Height of Parallelogram must be greater than 0");
                }

            }
        }
        public Parallelogram(double sideA, double sideB, double height, string color) : base("Параллелограмм", color)
        {
            SideA = sideA;
            SideB = sideB;
            Height = height;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (SideA + SideB);
            }
        }
        public override double Area
        {
            get { 
                return SideA * Height;
            }
        }
    }


    public class Rectangle : Parallelogram
    {
        public Rectangle(double width, double height, string color) : base(width, height, height, color)
        {
            Name = "Прямоугольник";

        }
    }

    public class Rhombus : Parallelogram
    {
        public Rhombus(double side, double height, string color) : base(side, side, height, color)
        {
            Name = "Ромб";
        }

        public override double Area
        {
            get
            {
                return SideA * Height;
            }
        }
    }
}
