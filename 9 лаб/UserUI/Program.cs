using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        //  для выборки уникальных элементов из коллекции
        var numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        var uniqueNumbers = numbers.Distinct();
        Console.WriteLine("Уникальные элементы:");
        foreach (var number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        //  для подсчета элементов, удовлетворяющих условию
        var evenCount = numbers.Count(x => x % 2 == 0);
        Console.WriteLine($"Количество четных чисел: {evenCount}");
        Console.WriteLine();

        //  для проверки наличия элемента, удовлетворяющего условию
        var hasNegative = numbers.Any(x => x < 0);
        Console.WriteLine($"Есть ли отрицательные числа: {hasNegative}");
        Console.WriteLine();

        //  для объединения двух коллекций по ключу
        var names = new List<string> { "Алиса", "Надежда", "Егор" };
        var lengths = new List<int> { 5, 3, 7 };
        var joined = names.Join(lengths,
                                       name => name.Length,
                                       length => length,
                                       (name, length) => $"{name} ({length} букв)");
        Console.WriteLine("Сопоставление имен с их длиной:");
        foreach (var item in joined)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //  для разделения коллекции на страницы
        var numbersPerPage = 3;
        var pages = numbers.Page(numbersPerPage);
        Console.WriteLine($"По {numbersPerPage} элемента/(ов) на странице:");
        foreach (var page in pages)
        {
            foreach (var number in page)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
