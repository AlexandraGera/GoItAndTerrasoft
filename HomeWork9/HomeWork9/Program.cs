using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IntPtr myCurrentLanguage = InputLanguage.CurrentInputLanguage.Handle;
                long language = (long)myCurrentLanguage;
                switch (language)
                {
                    case 67699721:
                        {

                        }
                        break;
                    case 68748313:
                        {

                        }
                        break;
                    case -257424350:
                        {

                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine(language);
                break;
            }
            

            Console.ReadLine();
        }
       
    }
}
