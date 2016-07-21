using System;
using System.Text;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Calculation();

            Console.ReadKey();
        }
        //основной подсчет
        static void Calculation()
        {
            Console.WriteLine("Для завершения программы закройте консоль");
            while (true)
            {
                Console.WriteLine("Введите число");
                string strOperandFirst = Console.ReadLine();
                double operandFirst = 0;

                bool resultInspection = InspectionOperand(strOperandFirst, operandFirst);

                if (resultInspection)
                {
                    operandFirst = Convert.ToDouble(strOperandFirst);
                    while (true)
                    {
                        Console.WriteLine("Введите один из операторов: + , - , * , / , % , pow");
                        string opt = Console.ReadLine();

                        resultInspection = InspectionOperator(opt);
                        if (resultInspection)
                        {
                            while (true)
                            {
                                Console.WriteLine("Введите число");
                                string strOperandSecond = Console.ReadLine();
                                double operandSecond = 0;

                                resultInspection = InspectionOperand(strOperandSecond, operandSecond);
                                if (resultInspection)
                                {
                                    operandSecond = Convert.ToDouble(strOperandSecond);
                                    operandFirst = operationDefinition(opt, operandFirst, operandSecond);
                                    Console.WriteLine(operandFirst);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Такое значение недоступно");
                                    continue;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Такой оператор недоступен");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Такое значение недоступно");
                    continue;

                }
            }
        }
        //проверка операндов
        static bool InspectionOperand(string operandArg, double operandDoubleArg)
        {
            if (!Double.TryParse(operandArg, out operandDoubleArg))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //проверка операторов
        static bool InspectionOperator(string operatorArg)
        {
            switch (operatorArg)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                case "pow":
                    return true;
                default:
                    return false;
            }
        }
        //методы оперций
        static double Sum(double operandFirst, double second)
        {
            operandFirst += second;
            return operandFirst;
        }
        static double Diff(double operandFirst, double second)
        {
            operandFirst -= second;
            return operandFirst;
        }
        static double Сomposition(double operandFirst, double second)
        {
            operandFirst *= second;
            return operandFirst;
        }
        static double Quotient(double operandFirst, double second)
        {
            operandFirst /= second;
            return operandFirst;
        }
        static double Module(double operandFirst, double second)
        {
            operandFirst %= second;
            return operandFirst;
        }
        static double Pow(double operandFirst, double second)
        {

            operandFirst = Math.Pow(operandFirst, second);
            return operandFirst;
        }
        //выбор операции
        static double operationDefinition(string opt, double first, double second)
        {
            switch (opt)
            {
                case "+":
                    { first = Sum(first, second); }
                    break;
                case "-":
                    { first = Diff(first, second); }
                    break;
                case "*":
                    { first = Сomposition(first, second); }
                    break;
                case "/":
                    { first = Quotient(first, second); }
                    break;
                case "%":
                    { first = Module(first, second); }
                    break;
                case "pow":
                    { first = Pow(first, second); }
                    break;
            }
            return first;
        }

    }
}


