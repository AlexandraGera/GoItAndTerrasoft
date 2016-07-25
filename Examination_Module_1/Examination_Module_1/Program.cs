using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Module_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Shop shop = new Shop();
            shop.Greeting();
            List<Product> products = shop.ProductsAvailable();
            Cart Cart = new Cart();
            Cart.Buy(products);
            
            Console.ReadKey();
        }
    }
}
