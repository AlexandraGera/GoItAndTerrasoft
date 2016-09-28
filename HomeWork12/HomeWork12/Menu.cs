using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork12
{
    class Menu
    {
       public void ManeMenu()
        {
            WorkWithLearners work = new WorkWithLearners();

            string selection = "";
            while (selection != "5")
            {
                Console.Clear();
                Console.WriteLine("\tМеню");
                Console.WriteLine("\n1. Добавить ученика\n2. Добавить предмет и оценку\n3. Посмотреть среднюю оценку\n4. Посмотреть оценки учеников по возросту\n5. Выход\n\n");
                Console.Write("Выберите номер пункта меню: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        {
                            work.AddLerners();
                        }
                        break;
                    case "2":
                        {
                            int select=work.SelectLearner();
                            if (select != -1) work.AddSubjectAndMark(select);
                        }
                        break;
                    case "3":
                        {
                            int select = work.SelectLearner();
                            if (select != -1) work.ShowAverage(select);
                        }
                        break;
                    case "4":
                        {
                            work.RatingByAge();
                        }
                        break;
                    case "5":
                        {
                            work.Serializable();
                        }
                        break;
                    default:
                        Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                        Console.ReadKey();
                        continue;
                }
            }

        }

    }
}
