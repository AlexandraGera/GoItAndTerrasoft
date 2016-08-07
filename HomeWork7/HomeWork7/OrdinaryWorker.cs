﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class OrdinaryWorker : Employee
    {
        public int Overtime { get; set; }
        public new int bonusHours { get; set; }
        public override void CalculationBonuses()
        {
            salaryTotal += bonusHours * 4 * salaryInHour;
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
            
        }
        public override void CalculationSalary()
        {
            Overtime = totalWorkingHours - RATE_HOURS;
            salaryTotal += (RATE_HOURS + Overtime * 3) * salaryInHour;
            Console.Clear();
            Console.WriteLine("Общее количество часов {0}\nСверурочные часы {1}\nБонусные часы {2}\nЗаработная плата итого: {3}\n", totalWorkingHours, Overtime, bonusHours, salaryTotal);
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
