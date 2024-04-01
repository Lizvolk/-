using UserLibrary;

namespace UserUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExamples.ExampleMethod1(DelegateExamples.GenerateFloat, true, new List<float> { 1.5f, 2.7f, 7.7f });

            DelegateExamples.ExampleMethod2(DelegateExamples.PrintChar,false, 2.5f, 9.8f);

            Console.ReadLine();
        }

    }
}

