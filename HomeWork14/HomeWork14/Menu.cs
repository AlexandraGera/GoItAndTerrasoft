using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Menu
    {
        public Menu()
        {
            string select = "";
            while (select != "0")
            {
                Console.Clear();
                Console.WriteLine("\tMENU\n1. New ,promotional and popular products\n2. Product search\n\n0.Exit\n\n");
                Console.Write("Enter 1 , 2 or 0 : ");
                select = Console.ReadLine();
                switch (select)
                {
                    case "0":
                        break;
                    case "1":
                        {
                            SelectionProducts();
                        }
                        break;
                    case "2":
                        {
                            ProductSearch();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Input wrong! Please press Enter...");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }

        private void SelectionProducts()
        {
            RepositoryProducts listProducts = new RepositoryProducts();
            var query = from product in listProducts.repository
                        where product.Discount > 0 && product.Price <= 1000 && product.Amount > 2 && product.Name.ToLower().Contains("new")
                         select new
                         {
                             Id = product.Id,
                             Name=product.Name,
                             Total = product.Total
                         };
            int page = -1;
            while (page != 0)
            {
                Console.Clear();
                int pageCount = query.Count() / 2;
                Console.Write("Select page 1-{0} or 0-Exit : ", pageCount);
                string pageStr = Console.ReadLine();
                if (Int32.TryParse(pageStr, out page))
                {
                    page = Convert.ToInt32(pageStr);
                    if (page == 0) break;
                    else if (page > 0 && page <= pageCount)
                    {
                        Console.Clear();
                        Console.WriteLine("\tPage {0}\n", page);
                        foreach (var item in query.Skip(2 * (page - 1)).Take(2))
                        {
                            Console.WriteLine("Id: {0}   {1,-30}  Total: {2,7}", item.Id, item.Name, item.Total);
                        }

                        Console.WriteLine("Please press Enter...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Input wrong! Please press Enter...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Input wrong! Please press Enter...");
                    Console.ReadKey();
                }
            }
        }

        private void ProductSearch()
        {
            string searchString = "";
            while (searchString!="0")
            {
                Console.Clear();
                Console.Write("Enter to search (0-Exit) : ");
                searchString = Console.ReadLine().ToLower();
                RepositoryProducts listProducts = new RepositoryProducts();
                if (searchString == "0") break;
                else
                {
                    var query =  from product in listProducts.repository
                                 where product.Name.ToLower().Contains(searchString)
                                 select new
                                 {
                                     Id = product.Id,
                                     Name = product.Name,
                                     Total = product.Total
                                 };
                    Console.Clear();
                    if (query.Count() < 1)
                    {
                        Console.WriteLine("No results!");
                        Console.ReadKey();
                    }
                    else
                    {
                        foreach (var item in query)
                        {
                            Console.WriteLine("Id: {0,-5}   {1,-30}  Total: {2,10:N2}", item.Id, item.Name, item.Total);
                        }
                    }
                    Console.WriteLine("\nPlease press any key to return...");
                    Console.ReadKey();
                }
            }
        }
    }
}
