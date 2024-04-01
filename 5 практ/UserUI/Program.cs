using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("banana");
            stringList.Add("apple");
            stringList.Add("orange");
            Console.WriteLine("Исходный список:");
            stringList.Print();
            stringList.BubbleSort();
            Console.WriteLine("\nОтсортированный список:");
            stringList.Print();

           
            GenericList<Figure> figureList = new GenericList<Figure>();
            figureList.Add(new Figure("Square", 16));
            figureList.Add(new Figure("Circle", 25 * Math.PI));
            figureList.Add(new Figure("Triangle", 6));
            Console.WriteLine("\nИсходный список элементов:");
            figureList.Print();
            figureList.BubbleSort();
            Console.WriteLine("\nОтсортированный список элементов:");
            figureList.Print();

            Console.ReadLine();
        }
    }
}
