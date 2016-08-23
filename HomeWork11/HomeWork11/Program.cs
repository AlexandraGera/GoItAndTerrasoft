using System;
using System.Text;
using System.IO;

namespace HomeWork11
{
    class Program
    {
        delegate void WriteInformation();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            WorkWhithInfo workWhithInfo = new WorkWhithInfo();
            workWhithInfo.MainMenu();
        }

        class WorkWhithInfo
        {
            delegate void WriteInformation();
            private string InputString { get; set; }
            private decimal InputDecimal { get; set; }

            public void MainMenu()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Введите текст или число:");
                    string input = Console.ReadLine();
                    bool resultInspection = Inspection(input);
                    if (!resultInspection) continue;
                    OutputSelection();
                    Console.Write("\nПовторить?(1-Повторить/ Любая другая клавиша- закрыть) : ");
                    input = Console.ReadLine();
                    if (input == "1") continue;
                    else break;
                }
            }

            private bool Inspection(string inputArg)
            {
                decimal input = 0;
                if (Decimal.TryParse(inputArg, out input))
                {
                    InputDecimal = Convert.ToDecimal(inputArg);
                    InputDecimal *= InputDecimal;
                    return true;
                }
                else if (!String.IsNullOrEmpty(inputArg))
                {
                    InputString = inputArg;
                    return true;
                }
                else
                {
                    Console.WriteLine("Строка пуста!\nНажмите любую клавишу...");
                    Console.ReadLine();
                    return false;
                }
            }

            private void OutputSelection()
            {
                WriteInformation writeInfo;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\tЧто сделать с информацией?\n1. Вывести на консоль\n2. Записать в файл");
                    string selection = Console.ReadLine();
                    if (selection == "1")
                    {
                        if (InputString == default(string)) writeInfo = () => { Console.WriteLine("\n" + InputDecimal); InputDecimal = default(decimal); };
                        else writeInfo = () => { Console.WriteLine("\n" + InputString); InputString = default(string); };
                        break;
                    }
                    else if (selection == "2")
                    {
                        if (InputString == default(string)) writeInfo = () =>
                        {
                            using (StreamWriter writer = new StreamWriter("result.txt", true))
                            {
                                writer.WriteLine(InputDecimal);
                                InputDecimal = default(decimal);
                            }
                            Console.WriteLine("\nЗапись сделана");
                        };
                        else writeInfo = () => {
                            using (StreamWriter writer = new StreamWriter("result.txt", true))
                            {
                                writer.WriteLine(InputString);
                                InputString = default(string);
                            }
                            Console.WriteLine("\nЗапись сделана");
                        };
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ввод неверный\nНажмите любую клавишу...");
                        Console.ReadLine();
                        continue;
                    }
                }
                if (writeInfo != null) writeInfo();
            }
        }
    }
}
