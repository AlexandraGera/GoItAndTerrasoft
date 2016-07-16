using System;


namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1234567890;
            string result="";
            while (number > 0)
            {
                int n = number % 10;

                if (n % 2 != 0 && n != 9)
                {
                    n++;
                }
                else if (n == 9)
                {
                    n = 0;
                }

                string str = n.ToString();
                result = str + result;

                number /= 10;
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
