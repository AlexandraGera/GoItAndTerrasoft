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
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Start();
        }
        static void Start()
        {
            IntPtr defaultLanguage = InputLanguage.DefaultInputLanguage.Handle;
            long language = (long)defaultLanguage;
            switch (language)
            {
                case 68748313:
                    Console.WriteLine("Чат с ботом начат (Для завершения программы закройте консоль)");
                    Console.WriteLine("------------------------------------------------------------\n");
                    break;
                case -257424350:
                    Console.WriteLine("Чат з ботом розпочато (Для завершення програми закрийте консоль)");
                    Console.WriteLine("---------------------------------------------------------------\n");
                    break;
                default:
                    Console.WriteLine("Chat with a bot started (Close the console to complete the program)");
                    Console.WriteLine("------------------------------------------------------------------\n");
                    break;
            }
            Write();
        }
        static void Write()
        {
            while (true)
            {
                string str = Console.ReadLine().ToLower();
                long language = (long)InputLanguage.CurrentInputLanguage.Handle;
                sbyte index = 0;
                switch (language)
                {
                    case 68748313:
                        {
                            Russian russianChat = new Russian();
                            index = russianChat.Inspection(str);
                            russianChat.Reply(index);
                        }
                        break;
                    case -257424350:
                        {
                            Ukrainian ukrainianChat = new Ukrainian();
                            index = ukrainianChat.Inspection(str);
                            ukrainianChat.Reply(index);
                        }
                        break;
                    default:
                        English englishChat = new English();
                        index = englishChat.Inspection(str);
                        englishChat.Reply(index);
                        break;
                }
            }
        }
    }
}
