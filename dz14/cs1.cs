using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz14
{
    public class Performance : IDisposable
    {
        public string PerformanceName { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        //Конструктор класу
        public Performance(string performanceName, string authorName, string genre, string year)
        {
            this.PerformanceName = performanceName;
            this.AuthorName = authorName;
            this.Genre = genre;
            this.Year = year;
            
        }

        //Метод для виведення
        public void Show()
        {
            Console.WriteLine($"Perfomance name:{PerformanceName}");
            Console.WriteLine($"Author name:{AuthorName}");
            Console.WriteLine($"Genre of perfomance:{Genre}");
            Console.WriteLine($"Perfomance year:{Year}");


        }

        //Метод для очищення даних
        public void Dispose()
        {
            PerformanceName = null;
            AuthorName = null;
            Genre = null;
            Year = null;
            Console.WriteLine("Дані видаленні");
        }
    }
    internal class cs1
    {
        public static void task_1()
        {
            Console.OutputEncoding = Encoding.Unicode;
            using (Performance performance = new Performance("Кайдаші", "Іван Нечуй-Левицький", "Трагікомедія", "1878"))
            {
                performance.Show();
            }

            Console.WriteLine();
        }
    }
}
