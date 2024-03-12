namespace VP_Pract2
{
    class Program
    {
        static void Main()
        {
            var list = new List<Figure>();
            list.Add(new Circle(5, "Красный"));
           
            list.Add(new Ring(8, 4, "Синий"));

            list.Add(new Parallelogram(5, 7, 4, "Красный"));

            list.Add(new Rectangle(6, 4, "Синий"));

            list.Add(new Rhombus(5, 3, "Зеленый"));

            list.Add(new RegularPolygon(6, 5, "Красный"));

            list.Add(new Square(4, "Синий"));

            list.Add(new Triangle(3, "Зеленый"));
         
            foreach (Figure f in list)
            {
                Console.WriteLine(f.ToString());
            }

            Console.ReadLine();
        }
    }
}