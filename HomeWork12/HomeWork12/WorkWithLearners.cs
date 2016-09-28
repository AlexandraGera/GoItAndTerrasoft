using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HomeWork12
{
    class WorkWithLearners
    {
        LearnerList lernerList = new LearnerList();
        public void AddLerners()
        {
            Console.Clear();
            Console.Write("Введите имя ученика: ");
            string Name = Console.ReadLine();
            int Age = 0;
            while (true)
            {
                Console.Write("Введите возраст ученика(от 1 до 99): ");
                string AgeString = Console.ReadLine();
                bool boolAge = Inspection(AgeString);
                if (boolAge && (Convert.ToInt32(AgeString)>0) && (Convert.ToInt32(AgeString) <100))
                {
                    Age = Convert.ToInt32(AgeString);
                    break;
                }
                else
                {
                    Console.WriteLine("Значение не верно, нажмите любую клавишу");
                    Console.ReadKey();
                    continue;
                }
            }
            lernerList.AddLearner(Name, Age, lernerList.Count());
            
            Console.WriteLine("Ученик добавлен\nНажмите любую клавишу");
            Console.ReadKey();
        }

        private bool Inspection(string StringArg)
        {
            int intSelection = 0;
            if (Int32.TryParse(StringArg, out intSelection))
                return true;
            return false;
        }

        public int SelectLearner()
        {
            int select = -1;
            Console.Clear();
            if (lernerList.Count()>0)
            {
                foreach (var item in lernerList)
                {
                    Console.WriteLine("#{0}. {1,-20} {2} лет", item.Id,item.Name, item.Age);
                }
                while (true)
                {
                    Console.Write("\nВведите номер ученика : ");
                    string selectStr = Console.ReadLine();
                    bool boolSelect = Inspection(selectStr);
                    if (boolSelect && (Convert.ToInt32(selectStr) >= 0) && (Convert.ToInt32(selectStr) < lernerList.Count()))
                    {
                        select = Convert.ToInt32(selectStr);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Значение не верно, нажмите любую клавишу");
                        Console.ReadKey();
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ученики не добавленны\nНажмите любую клавишу");
                Console.ReadKey();
            }
            return select;
        }
        
        public void AddSubjectAndMark(int select)
        {
            foreach (var item in lernerList)
            {
                if (item.Id != select) continue;
                else
                {
                    Console.Clear();
                    Console.Write("Название предмета : ");
                    string nameSubject = Console.ReadLine();
                    int mark = -1;
                    while (true)
                    {
                        Console.Write("\n Количество баллов (0-100): ");
                        string markStr = Console.ReadLine();
                        bool boolSelect = Inspection(markStr);
                        if (boolSelect && (Convert.ToInt32(markStr) >= 0) && (Convert.ToInt32(markStr) <= 100))
                        {
                            mark = Convert.ToInt32(markStr);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Значение не верно, нажмите любую клавишу");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    item.subjectAndMark.AddSubject(nameSubject, mark);
                    Console.Clear();
                    Console.WriteLine("\t Предметы ученика");
                    item.subjectAndMark.ShowSubject();
                    Console.WriteLine("\nПредмет добавлен\nНажмите любую клавишу");
                    Console.ReadKey();
                }
            }
        }

        public void ShowAverage(int select)
        {
            foreach (var item in lernerList)
            {
                if (item.Id != select) continue;
                else
                {
                    double mark = item.subjectAndMark.AverageMark();
                    Console.Write("\nСредняя оценка : {0}\n", mark);
                    Console.WriteLine("Для возврата нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                }  
            }
        }

        public void RatingByAge()
        {
            Console.Clear();
            int count = 0;
            while (true)
            {
                Console.Write("Введите возраст ученика (1-99): ");
                string ageStr = Console.ReadLine();
                Console.WriteLine();
                bool boolAge = Inspection(ageStr);
                if (boolAge && (Convert.ToInt32(ageStr) > 0) && (Convert.ToInt32(ageStr) < 100))
                {
                    int age = Convert.ToInt32(ageStr);
                    foreach (var item in lernerList)
                    {
                        if (item.Age < age) continue;
                        else
                        {
                            Console.WriteLine("{0,-20}{1} лет",item.Name,item.Age);
                            Console.WriteLine("-------------------------------");
                            item.subjectAndMark.ShowSubject();
                            Console.WriteLine("\n");
                            count++;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Значение не верно, нажмите любую клавишу");
                    Console.ReadKey();
                    continue;
                }
            }
            if (count<0)
            {
                Console.WriteLine("Нет учеников этого возроста или более");
            }
            Console.WriteLine("Для возврата нажмите любую кнопку...");
            Console.ReadKey();
        }
        public void Serializable()
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter("list.json"))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                jsonSerializer.Serialize(jsonWriter, lernerList);
            }
        }
        
    }
}
