using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz14
{
    public class Shop : IDisposable
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string ShopType { get; set; }

        public Shop(string name, string address, string shopType)
        {
            Name = name;
            Address = address;
            ShopType = shopType;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Shop Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Shop type: {ShopType}");
        }

        // Реалізація інтерфейсу IDisposable
        public void Dispose()
        {
            Name = null;
            Address = null;
            ShopType = null;
            Console.WriteLine("Дані видаленні");
        }
    }
        internal class cs2
        {
            public static void task_2()
            {
                Console.OutputEncoding = Encoding.Unicode;
                using (Shop shop = new Shop("Мегамаркет", "вул. Примерна, 10", "Продовольчий"))
                {
                    // Виклик методу для відображення інформації про магазин
                    shop.DisplayInfo();
                }

                Console.WriteLine();
            }
        }
}
