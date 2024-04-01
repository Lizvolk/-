using System;
using System.Collections.Generic;

namespace VP_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>();
            Console.WriteLine("\nДобавление значений в массив:");
            dynamicArray.Add(1);
            dynamicArray.Add(2);
            dynamicArray.Add(3);

            Console.WriteLine(dynamicArray);

            Console.WriteLine("Добавление коллекции эл-ов в массив\n");
            List<int> elements = new List<int> { 4, 5, 6 };
            dynamicArray.Add(elements);
            Console.WriteLine(dynamicArray);
            Console.WriteLine("\nВставка эл-та 10:");
            dynamicArray.Insert(10, 2);
            Console.WriteLine(dynamicArray);
            dynamicArray.RemoveAt(3);
            Console.WriteLine("\nУдаление эл-а из 3 позиции:");
            Console.WriteLine(dynamicArray);
            dynamicArray.RemoveAt(0);
            Console.WriteLine(dynamicArray);
        }
    }
}
