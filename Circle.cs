namespace VP_Pract2
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius 
        { 
            get
            {
                return radius;
            }
            set
            { 
                if(value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new Exception("Raduus must be greater than 0");
                }

            } 
        }

        public Circle(double radius, string color) : base("Круг", color)
        {
            Radius = radius;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }


    public class Ring : Circle
    {
        private double innerRadius;
        public double InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                if (value > 0)
                {
                    innerRadius = value;
                }
                else
                {
                    throw new Exception("Inner Raduus must be greater than 0");
                }

            }
        }
        public Ring(double radius, double innerRadius, string color) : base(radius, color)
        {
            InnerRadius = innerRadius;
            Name = "Кольцо";
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * (Radius + InnerRadius);
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * (Radius * Radius - InnerRadius * InnerRadius);
            }
        }
    }
}
