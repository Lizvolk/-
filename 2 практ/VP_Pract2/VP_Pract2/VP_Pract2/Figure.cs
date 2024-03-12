namespace VP_Pract2
{
    public abstract class Figure
    {
        public string Name;
        public string Color;

        public Figure(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract double Perimeter { get; }
        public abstract double Area { get; }

        public override string ToString()
        {
            return $"Фигура {Name}. Цвет {Color}. Периметр {Perimeter}. Площадь {Area}";
        }
    }


}