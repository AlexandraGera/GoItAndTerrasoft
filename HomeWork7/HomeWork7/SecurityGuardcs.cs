using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class SecurityGuard : Employee
    {
        public int dayWorkingHours { get; set; }
        public int nightWorkingHours { get; set; }
        public new int bonusHours { get; set; }
        int bonusDay { get; set; }
        int bonusNight { get; set; }
        public override void CalculationBonuses()
        {
            bonusHours = ( bonusDay * 2 ) +( bonusNight * 3 );
            salaryTotal += bonusHours * salaryInHour;
        }
        public override void DataInput()
        {
            while (true)
            {
                Console.Write("Введите оплату в час: ");
                string item = Console.ReadLine();
                bool boolItem = Inspection(item);
                if (boolItem)
                {
                    salaryInHour = Convert.ToDouble(item);
                    Console.Write("Введите колличество дневных часов: ");
                    item = Console.ReadLine();
                    boolItem = Inspection(item);
                    if (boolItem)
                    {
                        dayWorkingHours = Convert.ToInt32(item);
                        Console.Write("Введите колличество ночных часов: ");
                        item = Console.ReadLine();
                        boolItem = Inspection(item);
                        if (boolItem)
                        {
                            nightWorkingHours = Convert.ToInt32(item);
                            Console.Write("Введите колличество дневных бонусных часов: ");
                            item = Console.ReadLine();
                            boolItem = Inspection(item);
                            if (boolItem)
                            {
                                bonusDay = Convert.ToInt32(item);
                                Console.Write("Введите колличество ночных бонусных часов:  ");
                                item = Console.ReadLine();
                                boolItem = Inspection(item);
                                if (boolItem)
                                {
                                   bonusNight = Convert.ToInt32(item);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                                    Console.ReadKey();
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                                Console.ReadKey();
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                    continue;
                }
            }

        }
        public override void CalculationSalary()
        {
            totalWorkingHours = dayWorkingHours + nightWorkingHours;
            salaryTotal += (dayWorkingHours + nightWorkingHours * 2) * salaryInHour;
            Console.Clear();
            Console.WriteLine("Общее количество часов {0}\nБонусные часы  {1}\nЗаработная плата итого: {2}\n", totalWorkingHours, bonusHours, salaryTotal);
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
