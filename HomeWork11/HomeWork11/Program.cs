using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork11
{
    class Program
    {
        delegate void WriteInformation<T>(T a);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите текст или число:");
                string input = Console.ReadLine();
                bool resultInspection = Inspection(input);
                if (!resultInspection) continue;
                Console.Write("\nПовторить?(1-Повторить/ Любая другая клавиша- закрыть) : ");
                input = Console.ReadLine();
                if (input == "1") continue;
                else break;
            }
        }
        static bool Inspection(string inputArg)
        {
            decimal input = 0;
            if(Decimal.TryParse(inputArg, out input)){
                input = Convert.ToDecimal(inputArg);
                input *= input;
                OutputSelection(input);
               
                return true;
            }
            else if (!String.IsNullOrEmpty(inputArg))
            {
                OutputSelection(inputArg);
                return true;
            }
            else
            {
                Console.WriteLine("Строка пуста!\nНажмите любую клавишу...");
                return false;
            }
        }
        static void OutputSelection<T>(T infoArg)
        {
        
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("\tЧто сделать с информацией?\n1. Вывести на консоль\n2. Записать в файл");
                string selection = Console.ReadLine();
                if (selection == "1")
                {
                    ShowInConsole(infoArg);
                    break;
                }
                else if (selection == "2")
                {
                    WriteInFile(infoArg);
                    break;
                }
                else
                {
                    Console.WriteLine("Ввод не верный\nНажмите любую клавишу...");
                    Console.ReadLine();
                    continue;
                }
            }
        }
        static void ShowInConsole<T>(T infoArg)
        {
            Console.WriteLine("\n"+infoArg);
        }
        static void WriteInFile<T>(T infoArg)
        {
            using (StreamWriter writer = new StreamWriter("result.txt", true))
            {
                writer.WriteLine(infoArg);
            }
            Console.WriteLine("\nЗапись сделана");
        }
    }
}
