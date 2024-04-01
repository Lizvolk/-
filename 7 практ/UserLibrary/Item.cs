using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary
{
    public class Item
    {
        public string Article { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Item(string article, string name, string color, double price)
        {
            Article = article;
            Name = name;
            Color = color;
            Price = price;
        }
        public override string ToString()
        {
            return $"Артикул: {Article}, Название: {Name}, Цвет: {Color}, Цена: {Price}";
        }
    }
}
       
    
    

