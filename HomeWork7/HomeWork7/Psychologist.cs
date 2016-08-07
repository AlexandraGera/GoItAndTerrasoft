using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Psychologist : Employee
    {
        public int visitors { get; set; }
        public new int bonusHours { get; set; }
        public override void CalculationBonuses()
        {
            salaryTotal += bonusHours * 2 * salaryInHour;
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
                    Console.Write("Введите колличество часов: ");
                    item = Console.ReadLine();
                    boolItem = Inspection(item);
                    if (boolItem)
                    {
                        totalWorkingHours = Convert.ToInt32(item);
                        Console.Write("Введите колличество пациентов: ");
                        item = Console.ReadLine();
                        boolItem = Inspection(item);
                        if (boolItem)
                        {
                            visitors = Convert.ToInt32(item);
                            Console.Write("Введите колличество бонусных часов: ");
                            item = Console.ReadLine();
                            boolItem = Inspection(item);
                            if (boolItem)
                            {
                                bonusHours = Convert.ToInt32(item);
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

        }
        public override void CalculationSalary()
        {
            salaryTotal += totalWorkingHours * salaryInHour;
            for (int i = 0; i < visitors; i++)
            {
                salaryTotal *= 1.2;
            }
            Console.Clear();
            Console.WriteLine("Общее количество часов {0}\nКоличество посетителей {1}\nБонусные часы {2}\nЗаработная плата итого: {3}\n", totalWorkingHours, visitors, bonusHours, salaryTotal);
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
