using System.Runtime.Serialization;

namespace UserLibrary
{
    
    public class Shop
    {
        private List<Item> items;
        public Shop()
        {
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            foreach (var existitem in items) 
            {
                if (existitem.Article == item.Article)
                {
                    throw new ExistingItemCodeException(item);
                }
            }

            items.Add(item);

        }
 
    }
}
