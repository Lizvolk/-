using System;
using UserLibrary;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        string input = "Первая строка для примера";

        Console.WriteLine("Подстрока для удаления:");
        string substring = "строка для";

        string resultRemoveAll = StringManipulator.RemoveAll(input, substring);
        Console.WriteLine($"Результат удаления подстроки: {resultRemoveAll}");
        Console.WriteLine(); // Переход на новую строку

        Console.WriteLine("Задание 2");
        string inputWithSpaces = "LizVolk        EgoroGenia   MaxZenkin    Korolov";

        string resultRemoveSpaces = StringManipulator.RemoveExtraSpaces(inputWithSpaces);
        Console.WriteLine($"Результат удаления избыточных пробелов: {resultRemoveSpaces}");
        Console.WriteLine(); // Переход на новую строку

        Console.WriteLine("Задание 3");
        string inputForSorting = "БЕЛАЯ БЕРЁЗА    ПОД МОИМ ОКНОМ       ..СТОИТ ОНА";

        string resultSortedWords = StringManipulator.SortWords(inputForSorting);
        Console.WriteLine($"Результат сортировки слов: {resultSortedWords}");
        Console.WriteLine(); // Переход на новую строку

        Console.WriteLine("Задание 1");
        string s = "Конкатенация строковых литералов происходит на этапе компиляции";

        Console.WriteLine("Введите символ C:");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку

        string s0 = "Да";

        string resultInsert = StringBuilderManipulator.InsertStringAfterChar(s, c, s0);
        Console.WriteLine($"Результат вставки строки S0 после каждого вхождения символа C в строку S:\n {resultInsert}");
        Console.WriteLine(); // Переход на новую строку

        Console.WriteLine("Задание 2");
        string str1 = "Helloooooo";
        string str2 = "World";

         StringBuilderManipulator.PadStrings(ref str1,ref str2);

        Console.WriteLine(str1); Console.WriteLine(str2  + ".");
        //string s1 = "Конкатенация строковых литералов";
        //string s2 = "Конкатенация";

        //string resultPadded = StringBuilderManipulator.PadStrings(s1, s2);
        //Console.WriteLine($"Результат дополнения строк пробельными символами:\n {resultPadded}");
        Console.WriteLine(); // Переход на новую строку

        Console.WriteLine("Задание 3");
        string decimalNumber = "10";
        string binaryRepresentation = StringBuilderManipulator.DecimalToBinary(decimalNumber);

        Console.WriteLine($"Двоичное представление числа {decimalNumber}: {binaryRepresentation}");
    }

    // string resultBinary = StringBuilderManipulator.DecimalToBinary(decimalNumber);
    // Console.WriteLine($"Двоичное представление числа: {resultBinary}");
}

