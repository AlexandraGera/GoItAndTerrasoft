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
     
        List<Scout> Scouts = new List<Scout> {};

        public void ShowSport(List<Sport> thisScout)
        {
            foreach (var item in thisScout)
            {
                if (item.onOf == true)
                {
                    Console.WriteLine("{0}. {1}", item.Id, item.nameSport);
                }
                else
                {
                    continue;
                }
            }
        }
       

        public void ShowSportsAddRemove(List<Sport> SportList)
       {
            Console.Clear();
            Console.WriteLine("Виды спорта доступные для удаления:\n");
            foreach (var item in SportList)
            {
                if (item.onOf == true)
                {
                    Console.WriteLine("{0}.{1}", item.Id, item.nameSport);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Виды спорта доступные для добавления:\n");
            foreach (var item in SportList)
            {
           if (item.onOf == true)
           {
                    continue;
            }
            else
            {
             Console.WriteLine("{0}.{1}", item.Id, item.nameSport);   
             }
            }
        }

        public List<Sport> SportsAddRemove( List<Sport> SportList, int i)
        {
            Console.Clear();

            if (SportList[i].onOf == false)
            {
                SportList[i].onOf = true;
                Console.WriteLine("Вид спорта добавлен");
            }
            else
            {
                SportList[i].onOf = false;
                Console.WriteLine("Вид спорта удален");
            }
            Console.WriteLine("Для возврата нажмите любую кнопку");
            Console.ReadKey();
       
            return SportList;
        }
    }


    class scoutBoy : Scout
    {
        public new List<Sport> SportsList = new List<Sport> {
         new Sport() {nameSport= "Football", Id=1},
         new Sport() {nameSport= "Arm wrestling",Id=2},
         new Sport() {nameSport= "Basketball",Id=3},
         new Sport() {nameSport= "Boxing",Id=4}
        };
    }


    class scoutGirl : Scout
    {
         public new List<Sport> SportsList = new List<Sport> { 
         new Sport() {nameSport= "Gymnastics", Id=1},
         new Sport() {nameSport= "Athletics", Id=2},
         new Sport() {nameSport= "Swimming", Id=3},
         new Sport() {nameSport= "Dancing", Id=4}
        };
    }

    class Sport
    {
        public string nameSport;
        public byte Id;
        public int pointSport;
        public bool onOf = false;
        
        public Dictionary<String, Byte> SportAchievement = new Dictionary<String, Byte> { };

        public void ShowAchivment(Dictionary<String, Byte> Achivement)
        {
            int counter = 1;
            foreach (KeyValuePair<String, Byte> item in Achivement)
            {
                Console.WriteLine("{0}. {1,-20} Баллы: {2}", counter, item.Value , item.Key);
                counter++;
            }
        }
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
                            }
                            break;
                        case "2":
                            {
                                AddRemoveSports();
                            }
                            break;
                        case "3":
                            {
                                MenuLists();
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
        private void ShowGirlList()
        {
            if (Scouts.Count > 0)
            {

                for (int i = 0; i < Scouts.Count; i++)
                {
                    if (Scouts[i] is scoutGirl)
                    {
                        Console.WriteLine("{0}. {1,-15} Пол:{2}; ", i + 1, Scouts[i].scoutName, Scouts[i].scoutSex);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Не добавленно не одного скаута\n Для возврата в меню нажмите любую клавишу");
            }
            Console.WriteLine("Для выхода из списка нажмите любую клавишу");
            Console.ReadKey();
        }
        private void ShowBoyList()
        {
            if (Scouts.Count > 0)
            {

                for (int i = 0; i < Scouts.Count; i++)
                {
                    if (Scouts[i] is scoutBoy)
                    {
                        Console.WriteLine("{0}. {1,-15} Пол:{2}; ", i + 1, Scouts[i].scoutName, Scouts[i].scoutSex);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Не добавленно не одного скаута\n Для возврата в меню нажмите любую клавишу");
            }
            Console.WriteLine("Для выхода из списка нажмите любую клавишу");
            Console.ReadKey();
        }
        private void MenuLists()
        {
            string strItem = "";
            while (strItem != "4")
            {
                Console.Clear();
                Console.WriteLine("1. Список всех скаутов\n2. Список скаутов мальчиков\n3. Список скаутов девочек\n\n4.Выход");
                Console.Write("Выберите один из списков:");
                strItem = Console.ReadLine();
                switch (strItem)
                {
                    case "1":
                        {
                            Console.Clear();
                            ShowScoutsList();
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        {
                            Console.Clear();
                            ShowBoyList();
                        }
                        break;
                    case "3":
                        {
                            Console.Clear();
                            ShowGirlList();
                        }
                        break;
                    case "4":
                        break;
                    default:
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        //добавление спорта и награды
        private void AddRemoveSports()
        {
            string strItem;
            int intItem = 0;
            while (true)
            {
                Console.Clear();
                ShowScoutsList();
                Console.Write("\nВыбирите скаута из списка:");
                strItem = Console.ReadLine();
                if ((Int32.TryParse(strItem, out intItem) && (intItem <= Scouts.Count)))
                {
                    intItem = Convert.ToInt32(strItem);
                    --intItem;

                    if (Scouts[intItem] is scoutGirl)
                    {
                        scoutGirl thisScout = Scouts[intItem] as scoutGirl;
                        thisScout.ShowSportsAddRemove(thisScout.SportsList);
                        Console.Write("\nВыбирите спорт из списка:");
                        string strSportItem = Console.ReadLine();
                        int intSportItem = 0;
                        if ((Int32.TryParse(strSportItem, out intSportItem)) && (intSportItem <= 4))
                        {
                            intSportItem = Convert.ToInt32(strSportItem);
                            --intSportItem;
                            thisScout.SportsList = Scouts[intItem].SportsAddRemove(thisScout.SportsList, intSportItem);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        scoutBoy thisScout = (Scouts[intItem] as scoutBoy);
                        thisScout.ShowSportsAddRemove(thisScout.SportsList);
                        Console.Write("\nВыбирите спорт из списка:");
                        string strSportItem = Console.ReadLine();
                        int intSportItem = 0;
                        if ((Int32.TryParse(strSportItem, out intSportItem)) && (intSportItem <= 4))
                        {
                            intSportItem = Convert.ToInt32(strSportItem);
                            --intSportItem;
                            thisScout.SportsList = Scouts[intItem].SportsAddRemove(thisScout.SportsList, intSportItem);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                }

            }
        }


        //добавление награды

        private void AddAchivment()
        {
            string strItem;
            int intItem = 0;
            while (true)
            {
                Console.Clear();
                ShowScoutsList();
                Console.Write("\nВыбирите скаута из списка:");
                strItem = Console.ReadLine();
                if ((Int32.TryParse(strItem, out intItem) && (intItem <= Scouts.Count)))
                {
                    intItem = Convert.ToInt32(strItem);
                    --intItem;

                    if (Scouts[intItem] is scoutGirl)
                    {
                        scoutGirl thisScout = Scouts[intItem] as scoutGirl;
                        thisScout.ShowSport(thisScout.SportsList);
                        Console.Write("\nВыбирите спорт из списка:");
                        string strSportItem = Console.ReadLine();
                        int intSportItem = 0;
                        if ((Int32.TryParse(strSportItem, out intSportItem)) && (intSportItem <= 4))
                        {
                            intSportItem = Convert.ToInt32(strSportItem);
                            --intSportItem;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите описание награды (до 50 знаков):");
                                string achivmentName = Console.ReadLine();
                                if (achivmentName.Length <= 50 && achivmentName.Length > 0)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Введите колличество баллов (0-100):");
                                        string achivmentPoint = Console.ReadLine();
                                        byte intAchivmentPoint = 0;
                                        if ((Byte.TryParse(achivmentPoint, out intAchivmentPoint)) && (intAchivmentPoint <= 100) && (intAchivmentPoint >= 0))
                                        {
                                            intAchivmentPoint = Convert.ToByte(achivmentPoint);
                                            thisScout.SportsList[intSportItem].SportAchievement.Add(achivmentName, intAchivmentPoint);
                                            Console.WriteLine("Награда добавлена");
                                            Console.WriteLine("Нажмите любую клавишу");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        scoutBoy thisScout = (Scouts[intItem] as scoutBoy);
                        thisScout.ShowSport(thisScout.SportsList);
                        Console.Write("\nВыбирите спорт из списка:");
                        string strSportItem = Console.ReadLine();
                        int intSportItem = 0;
                        if ((Int32.TryParse(strSportItem, out intSportItem)) && (intSportItem <= 4))
                        {
                            intSportItem = Convert.ToInt32(strSportItem);
                            --intSportItem;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите описание награды (до 50 знаков):");
                                string achivmentName = Console.ReadLine();
                                if (achivmentName.Length <= 50 && achivmentName.Length > 0)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Введите колличество баллов (0-100):");
                                        string achivmentPoint = Console.ReadLine();
                                        byte intAchivmentPoint = 0;
                                        if ((Byte.TryParse(achivmentPoint, out intAchivmentPoint)) && (intAchivmentPoint <= 100) && (intAchivmentPoint >= 0))
                                        {
                                            intAchivmentPoint = Convert.ToByte(achivmentPoint);
                                            thisScout.SportsList[intSportItem].SportAchievement.Add(achivmentName, intAchivmentPoint);
                                            Console.WriteLine("Награда добавлена");
                                            Console.WriteLine("Нажмите любую клавишу");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
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
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                }
            }
        }


        //Удаление награды
        private void RemoveAchivment()
        {
            string strItem;
            int intItem = 0;
            while (true)
            {
                Console.Clear();
                ShowScoutsList();
                Console.Write("\nВыбирите скаута из списка:");
                strItem = Console.ReadLine();
                if ((Int32.TryParse(strItem, out intItem) && (intItem <= Scouts.Count)))
                {
                    intItem = Convert.ToInt32(strItem);
                    --intItem;

                    if (Scouts[intItem] is scoutGirl)
                    {
                        scoutGirl thisScout = Scouts[intItem] as scoutGirl;
                        thisScout.ShowSport(thisScout.SportsList);
                        Console.Write("\nВыбирите спорт из списка:");
                        string strSportItem = Console.ReadLine();
                        int intSportItem = 0;
                        if ((Int32.TryParse(strSportItem, out intSportItem)) && (intSportItem <= 4))
                        {
                            intSportItem = Convert.ToInt32(strSportItem);
                            --intSportItem;
                            while (true)
                            {
                                Console.Clear();
                                thisScout.SportsList[intSportItem].ShowAchivment(thisScout.SportsList[intSportItem].SportAchievement);
                                Console.WriteLine("Введите описание награды (до 50 знаков):");
                                string achivmentName = Console.ReadLine();
                                if (achivmentName.Length <= 50 && achivmentName.Length > 0)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Введите колличество баллов (0-100):");
                                        string achivmentPoint = Console.ReadLine();
                                        byte intAchivmentPoint = 0;
                                        if ((Byte.TryParse(achivmentPoint, out intAchivmentPoint)) && (intAchivmentPoint <= 100) && (intAchivmentPoint >= 0))
                                        {
                                            intAchivmentPoint = Convert.ToByte(achivmentPoint);
                                            thisScout.SportsList[intSportItem].SportAchievement.Add(achivmentName, intAchivmentPoint);
                                            Console.WriteLine("Награда добавлена");
                                            Console.WriteLine("Нажмите любую клавишу");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        scoutBoy thisScout = (Scouts[intItem] as scoutBoy);
                        thisScout.ShowSport(thisScout.SportsList);
                        Console.Write("\nВыбирите спорт из списка:");
                        string strSportItem = Console.ReadLine();
                        int intSportItem = 0;
                        if ((Int32.TryParse(strSportItem, out intSportItem)) && (intSportItem <= 4))
                        {
                            intSportItem = Convert.ToInt32(strSportItem);
                            --intSportItem;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Введите описание награды (до 50 знаков):");
                                string achivmentName = Console.ReadLine();
                                if (achivmentName.Length <= 50 && achivmentName.Length > 0)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("Введите колличество баллов (0-100):");
                                        string achivmentPoint = Console.ReadLine();
                                        byte intAchivmentPoint = 0;
                                        if ((Byte.TryParse(achivmentPoint, out intAchivmentPoint)) && (intAchivmentPoint <= 100) && (intAchivmentPoint >= 0))
                                        {
                                            intAchivmentPoint = Convert.ToByte(achivmentPoint);
                                            thisScout.SportsList[intSportItem].SportAchievement.Add(achivmentName, intAchivmentPoint);
                                            Console.WriteLine("Награда добавлена");
                                            Console.WriteLine("Нажмите любую клавишу");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
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
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                }
            }
        }
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