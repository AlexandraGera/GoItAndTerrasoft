using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Module_1
{
    partial class Shop
    {
        //Обращение к покупателю
        public void Greeting()
        {
            Console.Write("Enter please your name:");
            string nameUser = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("{0}, choose that your want to buy: \n", nameUser);
        }
        //создаем список товаров и выводим его на экран
        public List<Product> ProductsAvailable()
        {
            List<Product> products = new List<Product>
        {
            new Product(){Id = 1, Name = "Apple", Price = 1.0 },
            new Product(){Id = 2, Name = "Milk", Price = 1.5 },
            new Product(){Id = 3, Name = "Cola", Price = 0.75 },
            new Product(){Id = 4, Name = "Bread", Price = 2.55 },
            new Product(){Id = 5, Name = "Chocolate", Price = 3.00 }
        };
            Console.WriteLine("-----------Products------------\n");
            foreach (var item in products)
            {
                Console.WriteLine("{0}. {1,-10} : $ {2:N2}", item.Id, item.Name, item.Price);
            }
            Console.WriteLine();
            Console.WriteLine("6. Exit");
            Console.WriteLine("-------------------------------\n");
            return products;
        }
    }
}
