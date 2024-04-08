using System.Collections.Generic;
using System.Linq;
using UserLibrary;


namespace UserLibrary
{
    class Program
    {
        static void Main()
        {
            //Создание списка товаров
            List<Item> items = new List<Item>
            {
                new Item { Article = 1, Name = "Роза", Color = "Красная", Price = 180, Supplier = "Поставщик1", Date = new DateTime(2023, 10, 10) },
                new Item { Article = 2, Name = "Шар", Color = "Синий", Price = 300, Supplier = "Поставщик2", Date = new DateTime(2024, 8, 15) },
                new Item { Article = 3, Name = "Мишка", Color = "Коричневый", Price = 2000, Supplier = "Поставщик3", Date = new DateTime(2022, 7, 15) },
                new Item { Article = 4, Name = "Открытка", Color = "Розовая", Price = 12000, Supplier = "Поставщик4", Date = new DateTime(2022, 8, 20) },
                new Item { Article = 5, Name = "Зеркальце", Color = "Серебряное", Price = 430, Supplier = "Поставщик2", Date = new DateTime(2024, 8, 10) },
                new Item { Article = 6, Name = "Упаковка", Color = "Прозрачная", Price = 40, Supplier = "Поставщик2", Date = new DateTime(2024, 4, 15) },
                new Item { Article = 7, Name = "Расческа", Color = "Желтачя", Price = 1000, Supplier = "Поставщик2", Date = new DateTime(2024, 8, 15) },

            };

            //a.Отсортировать товары по поставщику, а затем по наименованию.
           var sortedItems = items.OrderBy(item => item.Supplier).ThenBy(item => item.Name);
            Console.WriteLine("Товары, отсортированные по поставщику и наименованию:");
            foreach (var item in sortedItems)
            {
                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Поставщик: {item.Supplier}");
            }
            Console.WriteLine("\n");

            //b.Вывести информацию о товарах конкретного поставщика.
            string selectedSupplier = "Поставщик1";
            var supplierItems = items.Where(item => item.Supplier == selectedSupplier);
            Console.WriteLine($"Товары от поставщика {selectedSupplier}:");
            foreach (var item in supplierItems)
            {
                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}");
            }
            Console.WriteLine("\n");

            //c.Вывести три самых дорогих товара.
           var topThreeExpensiveItems = items.OrderByDescending(item => item.Price).Take(3);
            Console.WriteLine("Три самых дорогих товара:");
            foreach (var item in topThreeExpensiveItems)
            {
                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Цена: {item.Price}");
            }
            Console.WriteLine("\n");

            //d.Вывести информацию о товарах, произведенных в текущем году.
            int currentYear = DateTime.Now.Year;
            var itemsThisYear = items.Where(item => item.Date.Year == currentYear);
            Console.WriteLine($"Товары, произведенные в текущем году ({currentYear}):");
            foreach (var item in itemsThisYear)
            {
                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Дата производства: {item.Date}");
            }
            Console.WriteLine("\n");

           // e.Вывести информацию о последнем произведенном товаре.
            var latestItem = items.OrderByDescending(item => item.Date).FirstOrDefault();
            Console.WriteLine("Последний произведенный товар:");
            if (latestItem != null)
            {
                Console.WriteLine($"Артикул: {latestItem.Article}, Наименование: {latestItem.Name}, Дата производства: {latestItem.Date}");
            }
            else
            {
                Console.WriteLine("Товары не найдены.");
            }
            Console.WriteLine("\n");

            //f.Посчитать количество поставщиков товара с заданным наименованием.
            string itemName = "Открытка";
            var supplierCount = items.Where(item => item.Name == itemName).Select(item => item.Supplier).Distinct().Count();
            Console.WriteLine($"Количество поставщиков товара {itemName}: {supplierCount}");
            Console.WriteLine("\n");

            //g.Вывести поставщиков, которые поставляют товары только дороже 10000.
            var suppliersAbove10000 = items.GroupBy(item => item.Supplier)
                                           .Where(group => group.All(item => item.Price > 10000))
                                           .Select(group => group.Key);
            Console.WriteLine("Поставщики, которые поставляют товары только дороже 10000:");
            foreach (var supplier in suppliersAbove10000)
            {
                Console.WriteLine(supplier);
            }
            Console.WriteLine("\n");

           // h.Вывести товары, которые либо не поставлялись в текущем году, либо их цена ниже средней цены всех товаров.////////////////////////////////
            
           

            var itemsNotThisYearOrBelowAverageQuery = from item in items
                                                      let averagePrice = items.Average(x => x.Price)
                                                      where item.Date.Year != currentYear || item.Price < averagePrice
                                                      select item;

            // Вывод результатов
            Console.WriteLine("Товары, не произведенные в текущем году или цена ниже средней:");
            foreach (var item in itemsNotThisYearOrBelowAverageQuery)
            {
                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Цена: {item.Price}");
            }
            Console.WriteLine("\n");

            //i.Вывести полные наименования товаров в виде { Артикул}{ Наименование} { Цвет}.
            var fullNames = items.Select(item => $"{item.Article} {item.Name} {item.Color}");
            Console.WriteLine("Полные наименования товаров:");
            foreach (var fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }
            Console.WriteLine("\n");

           // j.Вывести минимальную цену товара для каждого поставщика.
           var minPricesBySupplier = items.GroupBy(item => item.Supplier)
                                          .Select(group => new { Supplier = group.Key, MinPrice = group.Min(item => item.Price) });
            Console.WriteLine("Минимальные цены товаров для каждого поставщика:");
            foreach (var result in minPricesBySupplier)
            {
                Console.WriteLine($"Поставщик: {result.Supplier}, Минимальная цена: {result.MinPrice}");
            }
        }
    }
}

//using UserLibrary;

//namespace UserLibrary
//{
//    class Program
//    {
//        static void Main()
//        {
//            // Создание списка товаров
//            List<Item> items = new List<Item>
//            {
//               new Item { Article = 1, Name = "Роза", Color = "Красная", Price = 180, Supplier = "Поставщик1", Date = new DateTime(2023, 10, 10) },
//                new Item { Article = 2, Name = "Шар", Color = "Синий", Price = 300, Supplier = "Поставщик2", Date = new DateTime(2024, 8, 15) },
//                new Item { Article = 3, Name = "Мишка", Color = "Коричневый", Price = 2000, Supplier = "Поставщик3", Date = new DateTime(2022, 7, 15) },
//                new Item { Article = 4, Name = "Открытка", Color = "Розовая", Price = 12000, Supplier = "Поставщик4", Date = new DateTime(2022, 8, 20) },
//                new Item { Article = 5, Name = "Зеркальце", Color = "Серебряное", Price = 430, Supplier = "Поставщик2", Date = new DateTime(2024, 8, 10) },
//                new Item { Article = 6, Name = "Упаковка", Color = "Прозрачная", Price = 40, Supplier = "Поставщик2", Date = new DateTime(2024, 4, 15) },
//                new Item { Article = 7, Name = "Расческа", Color = "Желтачя", Price = 1000, Supplier = "Поставщик2", Date = new DateTime(2024, 8, 15) },
//            };

//            // a. Отсортировать товары по поставщику, а затем по наименованию.
//            var sortedItemsQuery = from item in items
//                                   orderby item.Supplier, item.Name
//                                   select item;
//            Console.WriteLine("Товары, отсортированные по поставщику и наименованию:");
//            foreach (var item in sortedItemsQuery)
//            {
//                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Поставщик: {item.Supplier}");
//            }
//            Console.WriteLine("\n");

//            // b. Вывести информацию о товарах конкретного поставщика.
//            string selectedSupplier = "Поставщик1";
//            var supplierItemsQuery = from item in items
//                                     where item.Supplier == selectedSupplier
//                                     select item;
//            Console.WriteLine($"Товары от поставщика {selectedSupplier}:");
//            foreach (var item in supplierItemsQuery)
//            {
//                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}");
//            }
//            Console.WriteLine("\n");

//            // c. Вывести три самых дорогих товара.
//            var topThreeExpensiveItemsQuery = (from item in items
//                                               orderby item.Price descending
//                                               select item).Take(3);
//            Console.WriteLine("Три самых дорогих товара:");
//            foreach (var item in topThreeExpensiveItemsQuery)
//            {
//                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Цена: {item.Price}");
//            }
//            Console.WriteLine("\n");

//            // d. Вывести информацию о товарах, произведенных в текущем году.
//            int currentYear = DateTime.Now.Year;
//            var itemsThisYearQuery = from item in items
//                                     where item.Date.Year == currentYear
//                                     select item;
//            Console.WriteLine($"Товары, произведенные в текущем году ({currentYear}):");
//            foreach (var item in itemsThisYearQuery)
//            {
//                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Дата производства: {item.Date}");
//            }
//            Console.WriteLine("\n");

//            // e. Вывести информацию о последнем произведенном товаре.
//            var latestItemQuery = (from item in items
//                                   orderby item.Date descending
//                                   select item).FirstOrDefault();
//            Console.WriteLine("Последний произведенный товар:");
//            if (latestItemQuery != null)
//            {
//                Console.WriteLine($"Артикул: {latestItemQuery.Article}, Наименование: {latestItemQuery.Name}, Дата производства: {latestItemQuery.Date}");
//            }
//            else
//            {
//                Console.WriteLine("Товары не найдены.");
//            }
//            Console.WriteLine("\n");

//            // f. Посчитать количество поставщиков товара с заданным наименованием.
//            string itemName = "Зеркальце"; // Замените на нужное наименование товара
//            var supplierCountQuery = (from item in items
//                                      where item.Name == itemName
//                                      select item.Supplier).Distinct().Count();
//            Console.WriteLine($"Количество поставщиков товара {itemName}: {supplierCountQuery}");
//            Console.WriteLine("\n");

//            // g. Вывести поставщиков, которые поставляют товары только дороже 10000.
//            var suppliersAbove10000Query = from item in items
//                                           group item by item.Supplier into grp
//                                           where grp.All(x => x.Price > 10000)
//                                           select grp.Key;
//            Console.WriteLine("Поставщики, которые поставляют товары только дороже 10000:");
//            foreach (var supplier in suppliersAbove10000Query)
//            {
//                Console.WriteLine(supplier);
//            }
//            Console.WriteLine("\n");

//            // h. Вывести товары, которые либо не поставлялись в текущем году, либо их цена ниже средней цены всех товаров.
//           var itemsNotThisYearOrBelowAverageQuery =
//           from item in items
//           let averagePrice = items.Average(x => x.Price)
//           where item.ProductionDate.Year != currentYear || item.Price < averagePrice
//           select item;

//           Console.WriteLine("Товары, не произведенные в текущем году или цена ниже средней:");
//           foreach (var item in itemsNotThisYearOrBelowAverageQuery)
//           {
//                Console.WriteLine($"Артикул: {item.Article}, Наименование: {item.Name}, Цена: {item.Price}");
//           }
//            Console.WriteLine("\n");

//            // i. Вывести полные наименования товаров в виде {Артикул} {Наименование} {Цвет}.
//            var fullNamesQuery = from item in items
//                                 select $"{item.Article} {item.Name} {item.Color}";
//            Console.WriteLine("Полные наименования товаров:");
//            foreach (var fullName in fullNamesQuery)
//            {
//                Console.WriteLine(fullName);
//            }
//            Console.WriteLine("\n");

//            // j. Вывести минимальную цену товара для каждого поставщика.
//            var minPricesBySupplierQuery = from item in items
//                                           group item by item.Supplier into grp
//                                           select new { Supplier = grp.Key, MinPrice = grp.Min(x => x.Price) };
//            Console.WriteLine("Минимальные цены товаров для каждого поставщика:");
//            foreach (var result in minPricesBySupplierQuery)
//            {
//                Console.WriteLine($"Поставщик: {result.Supplier}, Минимальная цена: {result.MinPrice}");
//            }
//        }
//    }
//}

