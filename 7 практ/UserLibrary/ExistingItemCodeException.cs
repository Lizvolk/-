using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary
{
    [Serializable]
    public class ExistingItemCodeException : ApplicationException
    {
        public Item ExistingItem { get; }

        public ExistingItemCodeException()
        {
        }

        public ExistingItemCodeException(string message) : base(message)
        {
        }

        public ExistingItemCodeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ExistingItemCodeException(Item item) : this("Товар с таким номером уже есть в магазине")
        {
            ExistingItem = item;
            // Инициализируем свойство Data информацией о товаре
            Data["ExistingItem"] = item.ToString();
        }

        protected ExistingItemCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
