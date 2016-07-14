using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello world";

            for (int i = 0; i < helloWorld.Length; i++)
            {
                Console.WriteLine("Char {0}: dec {1}, hex {1:X}", helloWorld[i], (int)helloWorld[i]);

            }
            Console.ReadKey();
        }
    }
}
