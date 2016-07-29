using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkWithScout Work = new WorkWithScout();
            Work.Menu();
            
            Console.ReadKey();
        }
    }


    class Scout
    {
       public string scoutName;
       public string scoutSex;
       private int points;
       private int numberOfSports;
       private double averagePoint;
        
       public List<Scout> Scouts = new List<Scout>();
        public Dictionary<String, Byte> SportAchievement = new Dictionary<String, Byte>{};

       

    }


    class scoutBoy : Scout
    {
       public static String[] Sports = {
           "Football",
           "Arm wrestling",
           "Basketball",
           "Boxing"
       };
        public void ShowSports()
        {
            for (int i = 0; i < Sports.Length; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, Sports[i]);
            }
        }
    }


    class scoutGirl : Scout
    {
        public static String[] Sports = {
           "Gymnastics",
           "Athletics",
           "Swimming",
           "Dancing"
       };
        public void ShowSports()
        {
            for (int i = 0; i < Sports.Length; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, Sports[i]);
            }
        }

    }

    class Sport
    {
        public string nameSport;
        public int pointSport;
        //private int win;
        //private int bestPlayer;
        //private int courage;
        //private int audienceSympathy;
    }

    class WorkWithScout
    {
        public List<Scout> Scouts = new List<Scout>();
        //вывод основного меню

        public void Menu()
        {
            string strItem;
            int intItem = 0;
            while (intItem != 5)
            {
                Console.Clear();
                Console.WriteLine("\t МЕНЮ \n1. Добавить скаута\n2. Спорт и награды\n3. Списки скаутов\n4. Расчеты\n5. Выход");

                Console.Write("\nВведите номер из меню "); ;
                strItem = Console.ReadLine();
                if (Int32.TryParse(strItem, out intItem))
                {

                    switch (strItem)
                    {
                        case "1":
                            {
                                AddScout();
                                ShowScoutsList();
                                Console.ReadKey();
                            }
                            break;
                        case "2":
                            {
                                //работа со спортом и наградами
                                //AddSports();
                            }
                            break;
                        case "3":
                            {
                                //работа со списками
                            }
                            break;
                        case "4":
                            {
                                //вывод расчетов
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey(); ;
                }
            }
        }

        //добавление нового скаута
        private void AddScout()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите имя скаута");
                string name = Console.ReadLine();
                if (name.Length > 2)
                {
                    Console.Write("Введите пол скаута(1-мальчик или 2-девочка):");
                    string sex = Console.ReadLine();

                    switch (sex)
                    {
                        case "1":
                            {
                                Scouts.Add(new scoutBoy() { scoutName = name, scoutSex = "Мальчик" });
                            }
                            break;
                        case "2":
                            {
                                Scouts.Add(new scoutGirl() { scoutName = name, scoutSex = "Девочка" });
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                }
            }
        }
        //вывести список скаутов
        private void ShowScoutsList()
        {
            if (Scouts.Count > 0)
            {
                for (int i = 0; i < Scouts.Count; i++)
                {
                    Console.WriteLine("{0}. {1,-15} Пол:{2}; ", i + 1, Scouts[i].scoutName, Scouts[i].scoutSex);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Не добавленно не одного скаута\n Для возврата в меню нажмите любую клавишу");
            }

        }
        private void MenuLists()
        {
            Console.WriteLine("1. Список всех скаутов\n2. Список скаутов мальчиков\n3. Список скаутов девочек");
            Console.Write("Выберите один из списков:");

        }
        //добавление спорта и награды
        //    private void AddSports()
        //    {
        //        string strItem;
        //        int intItem = 0;
        //        while (true)
        //        {
        //            Console.Clear();
        //            ShowScoutsList();
        //            Console.Write("\nВыбирите скаута из списка:");
        //            strItem = Console.ReadLine();
        //            if ((Int32.TryParse(strItem, out intItem)&&(intItem < Scouts.Count)))
        //            {
        //                intItem = Convert.ToInt32(strItem);
        //                --intItem;
        //                if(Scouts[intItem] is scoutGirl)
        //                {
        //                    scoutGirl scoutGirl = new scoutGirl();
        //                    scoutGirl.ShowSports();
        //                    Console.Write("\nВыбирите спорт из списка:");
        //                    strItem = Console.ReadLine();
        //                    if ((Int32.TryParse(strItem, out intItem) && (intItem < scoutGirl.Sports.Length)))
        //                    {
        //                        object Person = Scouts[intItem];

        //                        Console.ReadKey();
        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
        //                Console.ReadKey();
        //            }
        //        }
        //    }
        //}
    }
}


//List<Product> products = new List<Product>
//    {
//        new Product(){Id = 1, Name = "Apple", Price = 1.0 },
//        new Product(){Id = 2, Name = "Milk", Price = 1.5 },
//        new Product(){Id = 3, Name = "Cola", Price = 0.75 },
//        new Product(){Id = 4, Name = "Bread", Price = 2.55 },
//        new Product(){Id = 5, Name = "Chocolate", Price = 3.00 }
//    };

//    public Dictionary<String,Byte> AchievementList(string n, int point)
//    {
//         public Dictionary<String, Byte> Achievement = new Dictionary<String, Byte>();

//}
//    private Dictionary<String, Byte> Acivka(string n, int p)
//    {
//    public Dictionary<String, Byte> Achievement = new Dictionary<String, Byte>();


//    return Achievement;
//}
//switch (strItem)
//{
//    case "1":
//        {
//            if (!Scouts[intItem].SportAchievement.ContainsKey("Гимнастика"))
//            {
//                Console.WriteLine("Введите награду\nКолличество баллов от 0 до 100");
//                string strPoint = Console.ReadLine();
//                if ((Int32.TryParse(strItem, out intItem) && (intItem < scoutGirl.Sports.Length)))
//                {
//                    Scouts[intItem].SportAchievement.Add("Гимнастика", 35);
//                }

//            }

//        }
//        break;

//    default:
//        break;
//}