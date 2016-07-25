using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Module_1
{
    partial class Cart
    {
        //основной метод покупки 
        public void Buy(List<Product> products)
        {
            bool resultInspection;
            while (true)
            {
                //выбор продукта
                Console.Write("Point:");
                string strProductIndex = Console.ReadLine();
                int productIndex = 0;
                //выход из цыкла выбора
                if (strProductIndex == "6")
                {
                    //проверка наличия скидки
                    double totalCost = TotalProduct(products);
                    double totalDiscount = 0;
                    Console.Write("Have you discount? (yes/no): ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        while (true)
                        {
                            Console.Write("Enter a value of discount (in percentage): ");
                            string strPercentage = Console.ReadLine();
                            int percentage = 0;
                            resultInspection = Inspection(strPercentage, percentage);
                            if (resultInspection)
                            {
                                percentage = Convert.ToInt32(strPercentage);
                                totalDiscount = TotalDiscount(percentage, totalCost);
                                totalCost = totalCost - totalDiscount;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("This is not a number");
                                continue;
                            }
                        }
                    }
                    ShowCart(products, totalDiscount, totalCost);
                    break;
                }
                //проверка ввода номера товара
                resultInspection = Inspection(strProductIndex, productIndex);
                if (resultInspection)
                {
                    productIndex = Convert.ToInt32(strProductIndex);
                    if (productIndex > 6)
                    {
                        Console.WriteLine("Select your product from the list");
                        continue;
                    }
                    //ввод количества товара
                    Console.Write("Count:");
                    string strCount = Console.ReadLine();
                    Console.WriteLine();
                    int count = 0;

                    resultInspection = Inspection(strCount, count);

                    if (resultInspection)
                    {
                        count = Convert.ToInt32(strCount);

                        AddToCart(products, productIndex, count);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("This is not a number");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("This is not a number");
                    continue;
                }
            }
        }

        //проверка введеных данных
        public bool Inspection(string numberArg, int numberIntArg)
        {
            if (!Int32.TryParse(numberArg, out numberIntArg))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //добавление товара в корзину
        public void AddToCart(List<Product> products, int productIndex, int count)
        {
            switch (productIndex)
            {
                case 1:
                    {
                        products[0].Quantity += count;
                        products[0].TotalCost = products[0].Quantity * products[0].Price;
                    }
                    break;
                case 2:
                    {
                        products[1].Quantity += count;
                        products[1].TotalCost = products[1].Quantity * products[1].Price;
                    }
                    break;
                case 3:
                    {
                        products[2].Quantity += count;
                        products[2].TotalCost = products[2].Quantity * products[2].Price;
                    }
                    break;
                case 4:
                    {
                        products[3].Quantity += count;
                        products[3].TotalCost = products[3].Quantity * products[3].Price;
                    }
                    break;
                case 5:
                    {
                        products[4].Quantity += count;
                        products[4].TotalCost = products[4].Quantity * products[4].Price;
                    }
                    break;
            }
        }

        //подсчет общей суммы покупок
        public double TotalProduct(List<Product> products)
        {
            double total = 0;
            foreach (var item in products)
            {
                total += item.TotalCost;
            }
            return total;
        }

        //подсчет скидки
        public double TotalDiscount(int percentage, double totalCost)
        {
            double totalDiscount = (percentage * 0.01) * totalCost;
            return totalDiscount;
        }

        //вывод корзины на экран
        public void ShowCart(List<Product> products, double totalDiscount, double totalCost)
        {
            Console.WriteLine();
            Console.WriteLine("-------------Check-------------");
            foreach (var item in products)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine("{0,-10} {1,-3} {2,-2} = $ {3:N2}", item.Name, "X", item.Quantity, item.TotalCost);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0,-15} : $ {1}", "Total discount", totalDiscount);
            Console.WriteLine("{0,-15} : $ {1}", "For payment", totalCost);
            Console.WriteLine("-------------------------------");
        }
    }
}
