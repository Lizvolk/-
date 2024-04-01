using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    // Класс фигуры
    public class Figure : IComparable<Figure>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Figure(string name, double area)
        {
            Name = name;
            Area = area;
        }

        // Реализация сравнения по площади
        public int CompareTo(Figure other)
        {
            return Area.CompareTo(other.Area);
        }

        public override string ToString()
        {
            return $"{Name} (Area: {Area})";
        }
    }

    // Обобщенный класс списка
    public class GenericList<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        // Метод добавления элемента в список
        public void Add(T item)
        {
            items.Add(item);
        }

        // Метод сортировки элементов по возрастанию
        public void BubbleSort()
        {
            for (int i = 0; i < items.Count - 1; i++)
            {
                for (int j = 0; j < items.Count - 1 - i; j++)
                {
                    if (items[j].CompareTo(items[j + 1]) > 0)
                    {
                        T temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }
        }

        // Метод вывода элементов списка
        public void Print()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
