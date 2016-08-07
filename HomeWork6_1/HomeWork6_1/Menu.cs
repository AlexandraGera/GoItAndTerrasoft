using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class Menu : WorkWithScout
    {
        //вывод основного меню
      public void ManeMenu()
        {
            string strItem;
            int intItem = 0;
            while (intItem != 6)
            {
                Console.Clear();
                Console.WriteLine("\t МЕНЮ \n1. Добавить скаута\n2. Спорт\n3. Награды\n4. Списки скаутов\n5. Расчеты\n6. Выход");
                Console.Write("\nВведите номер из меню "); ;
                strItem = Console.ReadLine();
                if (Int32.TryParse(strItem, out intItem))
                {
                    switch (strItem)
                    {
                        case "1":
                            {
                                AddScout();
                                ShowScoutsList();
                                Console.ReadKey();
                            }
                            break;
                        case "2":
                            {
                                AddRemoveSports();
                            }
                            break;
                        case "3":
                            {

                                MenuAchivment();
                            }
                            break;
                        case "4":
                            {
                                MenuLists();
                            }
                            break;
                        case "5":
                            {
                                MenuCalculate();
                            }
                            break;
                        default:
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey(); 
                }
            }
        }
        //меню списков
        private void MenuLists()
        {
            string strItem = "";
            while (strItem != "4")
            {
                Console.Clear();
                Console.WriteLine("1. Список всех скаутов\n2. Список скаутов мальчиков\n3. Список скаутов девочек\n\n4.Выход");
                Console.Write("Выберите один из списков:");
                strItem = Console.ReadLine();
                switch (strItem)
                {
                    case "1":
                        {
                            Console.Clear();
                            ShowScoutsList();
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            ShowBoyList();
                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            ShowGirlList();
                        }
                        break;
                    case "4":
                        break;
                    default:
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        //меню ачивок
        private void MenuAchivment()
        {
            string strItem = "";
            while (strItem != "3")
            {
                Console.Clear();
                Console.WriteLine("1.Добавить награду\n2. Удалить награду\n\n3.Выход");
                Console.Write("Выберите действие:");
                strItem = Console.ReadLine();
                switch (strItem)
                {
                    case "1":
                        {
                            AddAchivment();
                        }
                        break;
                    case "2":
                        {
                            RemoveAchivment();
                        }
                        break;
                    case "3":
                        break;
                    default:
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        //меню расчетов
        private void MenuCalculate()
        {
            string strItem = "";
            while (strItem != "3")
            {
                Console.Clear();
                Console.WriteLine("1.Посмотреть средний балл скаута\n2. Посмотреть статистику\n\n3.Выход");
                Console.Write("Выберите действие:");
                strItem = Console.ReadLine();
                switch (strItem)
                {
                    case "1":
                        {
                            ShowScoutsPoint();
                        }
                        break;
                    case "2":
                        {
                            ShowCalculate();
                        }
                        break;
                    case "3":
                        break;
                    default:
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
