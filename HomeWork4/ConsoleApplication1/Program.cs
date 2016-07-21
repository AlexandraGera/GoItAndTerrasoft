using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите число");
            string strOperandFirst = Console.ReadLine();
            double operandFirst=0;
            if (!Double.TryParse(strOperandFirst, out operandFirst))
            {
                Console.WriteLine("false!!!!");
                
            }
            else
            {
                Console.WriteLine("True!!!!");
            }
            Console.ReadKey();
        }
        
    }
}
