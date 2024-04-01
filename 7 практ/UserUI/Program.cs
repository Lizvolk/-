using UserLibrary;

namespace UserUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shop shop = new Shop();
                shop.AddItem(new Item("001", "Продукт A", "Красный", 10.99));
                shop.AddItem(new Item("002", "Продукт B", "Синий", 15.99));
                // добавим товар с уже существующим артикулом
                shop.AddItem(new Item("001", "Продукт C", "Зеленый", 20.99));
            }
            catch (ExistingItemCodeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"существующий товар: {ex.ExistingItem}");
            }

            Console.ReadLine();

            //{
            //    TestFirstCase();
            //    //TestSecondCase();
            //    Console.ReadLine(); 
            //}
            //{
            //    try
            //    {
            //        TestFirstCase();
            //        //TestSecondCase();
            //    }
            //    catch (ExistingItemCodeException ex)
            //    {
            //        // Обработка исключения ExistingItemCodeException
            //        Console.WriteLine("Поймано ExistingItemCodeException in Main:");
            //        Console.WriteLine($"Собщение: {ex.Message}");
            //    }

            //    Console.ReadLine(); 
            //}


            //static void TestFirstCase()
            //{
            //    try
            //    {
            //        throw new ExistingItemCodeException();
            //    }
            //    catch (ExistingItemCodeException ex)
            //    {
            //        Console.WriteLine("Первый кейс:");
            //        Console.WriteLine($"Поймано исключение и повторно запущено с помощью 'throw ex;'");
            //        throw ex;
            //    }
            //}

            //static void TestSecondCase()
            //{
            //    try
            //    {
            //        throw new ExistingItemCodeException();
            //    }
            //    catch (ExistingItemCodeException ex)
            //    {
            //        Console.WriteLine("Второй кейс:");
            //        Console.WriteLine($"Поймано исключение и повторно запущено с помощью 'throw;'");
            //        throw;
            //    }
            //}
        }
    }
}