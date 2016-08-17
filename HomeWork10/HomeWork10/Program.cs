using System;
using System.Text;

namespace HomeWork10
{
    delegate void PushShowButton(decimal a, decimal b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            while (true)
            {
                Console.Clear();
                WorkWithNumbers workWithNumber = new WorkWithNumbers();
                decimal a = workWithNumber.InputNumber();
                decimal b = workWithNumber.InputNumber();
                workWithNumber.InputOperators();

                Console.WriteLine("Для вывода результатов на экран нажмите Esc");
                ConsoleKeyInfo keyInfo;
                while (true)
                {
                    keyInfo = Console.ReadKey();
                    if (keyInfo.Key==ConsoleKey.Escape)
                    {
                        Console.Clear();
                        workWithNumber.showButton.DoEvent(a, b);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                    Console.Write("\nЕще раз?(да-1, нет- любая клавиша):");
                    string answer = Console.ReadLine();
                if (answer == "1") continue;
                else break;
            }
        }
    }

    class WorkWithNumbers
    {
        public ShowButton showButton = new ShowButton();

        public decimal InputNumber()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                string strNumber = Console.ReadLine();
                decimal number = 0;
                if (Decimal.TryParse(strNumber, out number))
                {
                    number = Convert.ToDecimal(strNumber);
                    return number;
                }
                else
                {
                    Console.WriteLine("Значение недоступно");
                    continue;
                }
            }
        }

        public void InputOperators()
        {
            Console.Clear();
            Console.WriteLine("\tВыберите опреаторы, которые нужно применить к числам(введите индексы операторов без пробела)\n" );
            Console.WriteLine("1. +\n2. -\n3. /\n4. *");
            string strOperators = Console.ReadLine();
            char[] operators = strOperators.ToCharArray();
            for (int i = 0; i < operators.Length; i++)
            {
                switch (operators[i])
                {
                    case '1':
                        showButton.Push += ((decimal a, decimal b) => Console.WriteLine("{0} + {1} = {2}", a, b, a + b));
                        break;
                    case '2':
                        showButton.Push += ((decimal a, decimal b) => Console.WriteLine("{0} - {1} = {2}", a, b, a - b));
                        break;
                    case '3':
                        showButton.Push += ((decimal a, decimal b) => Console.WriteLine("{0} / {1} = {2}", a, b, a / b));
                        break;
                    case '4':
                        showButton.Push += ((decimal a, decimal b) => Console.WriteLine("{0} * {1} = {2}", a, b, a * b));
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class ShowButton
    {
        public event PushShowButton Push;

        public void DoEvent(decimal a, decimal b)
        {
            if (Push != null) Push(a,b);
        }
    }
}
