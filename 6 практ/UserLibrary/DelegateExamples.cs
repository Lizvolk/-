namespace UserLibrary
{
    public delegate void ActionFuncFloatBoolList(Func<float> floatGenerator, bool condition, List<float> floatList);

    public delegate void FuncActionCharBoolDouble(Action<char> charAction, bool condition, double value, double val);
    public class DelegateExamples
    {
        // Метод, принимающий делегат ActionFuncFloatBoolList
        public static void ExampleMethod1(Func<float> floatGenerator, bool condition, List<float> floatList)
        {
            Console.WriteLine("ExampleMethod1 вызван");
            if (condition)
            {
                Console.WriteLine("Условие true. Распечатать список:");
                foreach (var item in floatList)
                {  
                    Console.WriteLine(item);
                }
                    
            }
            else
            {
                float result = floatGenerator();
                Console.WriteLine("Условие false. Генерация float: " + result);
            }
        }
        public static double ExampleMethod2(Action<char> charAction, bool condition, double value, double val)
        {
            Console.WriteLine("\nExampleMethod2 вызыван:");
            if (condition)
            {
                Console.WriteLine("Условие is true.");
                return 0; 
            }
            else
            {
                charAction('A');
                double squaredValue = value * value;
                Console.WriteLine("Условие false. Значение площади: " + squaredValue);
                Console.WriteLine("Сумма: " + val);
                return squaredValue; 
            }
        }

        // Метод, генерирующий случайное число типа float
        public static float GenerateFloat()
        {
            Random random = new Random();
            return (float)random.NextDouble() * 100f;
        }
        public static void PrintChar(char c)
        {
            Console.WriteLine("Значение: " + c);
        }
    }
}
