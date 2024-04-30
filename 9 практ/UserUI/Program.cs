using System;
using System.IO;

class Program
{
    static void Main()
    {
        string basePath = @"C:\temp\";
        string k1Path = Path.Combine(basePath, "K1");
        string k2Path = Path.Combine(basePath, "K2");
        string allPath = Path.Combine(basePath, "All");

        // 1) Создание папок K1 и K2
        Directory.CreateDirectory(k1Path);
        Directory.CreateDirectory(k2Path);

        // 2) Создание файлов t1.txt и t2.txt и запись в них текста
        File.WriteAllText(Path.Combine(k1Path, "t1.txt"), "текст записан в файле t1.txt");
        File.WriteAllText(Path.Combine(k1Path, "t2.txt"), "текст записан в файле t2.txt");

        // 3) Чтение из файлов t1.txt и t2.txt и запись в t3.txt
        string t1Content = File.ReadAllText(Path.Combine(k1Path, "t1.txt"));
        string t2Content = File.ReadAllText(Path.Combine(k1Path, "t2.txt"));
        File.WriteAllText(Path.Combine(k2Path, "t3.txt"), t1Content + Environment.NewLine + t2Content);

        // 4) Вывод информации о созданных файлах
        Console.WriteLine("Созданные файлы:");
        string[] files = Directory.GetFiles(basePath, "*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFullPath(file));
        }

        // 5) Перенос файла t2.txt в папку K2
        string t2FilePath = Path.Combine(k1Path, "t2.txt");
        string t2NewPath = Path.Combine(k2Path, Path.GetFileName(t2FilePath));
        File.Move(t2FilePath, t2NewPath);

        // 6) Копирование файла t1.txt в папку K2
        string t1NewPath = Path.Combine(k2Path, Path.GetFileName(t1Content));
        File.Copy(Path.Combine(k1Path, "t1.txt"), t1NewPath);

        // 7) Переименование папки K2 в All и удаление папки K1
        Directory.Move(k2Path, allPath);
        File.Delete(Path.Combine(k1Path, "t1.txt")); // Удаление файла t1.txt
        Directory.Delete(k1Path);

        // 8) Вывод полной информации обо всех файлах папки All
        Console.WriteLine("\nПолная информация о файлах папки All:");
        files = Directory.GetFiles(allPath, "*", SearchOption.AllDirectories);
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFullPath(file));
        }
    }
}
