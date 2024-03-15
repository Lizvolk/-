
using System.Globalization;

namespace VP_Pract3
{
    class Program
    {
        static void Main()
        {

            string text = "Практическая работа 3 по вп, Егорова,Волкова 12345";
            Console.WriteLine(text.ToString());
            StringInfo info = text.GetStringInfo();
            
            Console.WriteLine($"Длина: {info.Length}");
            Console.WriteLine($"Число цифр: {info.DigitCount}");
            Console.WriteLine($"Число букв: {info.LetterCount}");
        }
    }
}
