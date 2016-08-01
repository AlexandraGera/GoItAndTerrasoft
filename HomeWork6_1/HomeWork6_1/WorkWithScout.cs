using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class WorkWithScout
    {
        public List<Scout> Scouts = new List<Scout>();
        //добавление нового скаута
        protected void AddScout()
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
        protected void ShowScoutsList()
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
        protected void ShowGirlList()
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
        protected void ShowBoyList()
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
        
        //добавление спорта и награды
        protected void AddRemoveSports()
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
                            thisScout.SportsList = thisScout.SportsAddRemove(thisScout.SportsList, intSportItem);
                            thisScout.numberOfSports = thisScout.QuantitySports(thisScout.SportsList);
                            thisScout.points = thisScout.totalScore(thisScout.SportsList);
                            thisScout.averagePoint = thisScout.averageScore(thisScout.SportsList, thisScout.numberOfSports);
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
                            thisScout.numberOfSports = thisScout.QuantitySports(thisScout.SportsList);
                            thisScout.averagePoint = thisScout.averageScore(thisScout.SportsList, thisScout.numberOfSports);
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
                    Console.WriteLine("Это неверное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                }

            }
        }

        //добавление награды
        protected void AddAchivment()
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
                                            Sport thisSport = thisScout.SportsList[intSportItem];
                                            thisSport.SportAchievement.Add(achivmentName, intAchivmentPoint);
                                            thisSport.pointSport = thisSport.SportPoint(thisSport.SportAchievement);
                                            thisSport.average = thisSport.AveragePointSport(thisSport.SportAchievement);
                                            thisScout.points = thisScout.totalScore(thisScout.SportsList);
                                            thisScout.averagePoint = thisScout.averageScore(thisScout.SportsList, thisScout.numberOfSports);
                                            Console.WriteLine("Награда добавлена");
                                            Console.WriteLine("Нажмите любую клавишу");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                            Console.ReadKey();
                        }
                        break;
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
                                            Sport thisSport = thisScout.SportsList[intSportItem];
                                            thisSport.SportAchievement.Add(achivmentName, intAchivmentPoint);
                                            thisSport.pointSport = thisSport.SportPoint(thisSport.SportAchievement);
                                            thisSport.average = thisSport.AveragePointSport(thisSport.SportAchievement);
                                            thisScout.points = thisScout.totalScore(thisScout.SportsList);
                                            thisScout.averagePoint = thisScout.averageScore(thisScout.SportsList, thisScout.numberOfSports);
                                            Console.WriteLine("Награда добавлена");
                                            Console.WriteLine("Нажмите любую клавишу");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                                break;
                            }
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
                break;
            }
        }

        //Удаление награды
        protected void RemoveAchivment()
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
                                Console.WriteLine("Введите номер награды:");
                                string achivmentNumber = Console.ReadLine();
                                int intAchivmentNumber = 0;
                                if ((Int32.TryParse(achivmentNumber, out intAchivmentNumber)) && (intAchivmentNumber <= thisScout.SportsList[intSportItem].SportAchievement.Count))
                                {
                                    intAchivmentNumber = Convert.ToInt32(achivmentNumber);
                                    --intAchivmentNumber;
                                    Sport thisSport = thisScout.SportsList[intSportItem];
                                    thisSport.RemoveAchivment(thisSport.SportAchievement, intAchivmentNumber);
                                    thisSport.pointSport = thisSport.SportPoint(thisSport.SportAchievement);
                                    thisSport.average = thisSport.AveragePointSport(thisSport.SportAchievement);
                                    thisScout.points = thisScout.totalScore(thisScout.SportsList);
                                    thisScout.averagePoint = thisScout.averageScore(thisScout.SportsList, thisScout.numberOfSports);
                                    Console.WriteLine("Награда удалена");
                                    Console.WriteLine("Нажмите любую клавишу");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    continue;
                                }
                                break;
                            }
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
                                thisScout.SportsList[intSportItem].ShowAchivment(thisScout.SportsList[intSportItem].SportAchievement);
                                Console.WriteLine("Введите номер награды:");
                                string achivmentNumber = Console.ReadLine();
                                int intAchivmentNumber = 0;
                                if ((Int32.TryParse(achivmentNumber, out intAchivmentNumber)) && (intAchivmentNumber <= thisScout.SportsList[intSportItem].SportAchievement.Count))
                                {
                                    intAchivmentNumber = Convert.ToInt32(achivmentNumber);
                                    --intAchivmentNumber;
                                    Sport thisSport = thisScout.SportsList[intSportItem];
                                    thisSport.RemoveAchivment(thisSport.SportAchievement, intAchivmentNumber);
                                    thisSport.pointSport = thisSport.SportPoint(thisSport.SportAchievement);
                                    thisSport.average = thisSport.AveragePointSport(thisSport.SportAchievement);
                                    thisScout.points = thisScout.totalScore(thisScout.SportsList);
                                    thisScout.averagePoint = thisScout.averageScore(thisScout.SportsList, thisScout.numberOfSports);
                                    Console.WriteLine("Награда удалена");
                                    Console.WriteLine("Нажмите любую клавишу");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    continue;
                                }
                                break;
                            }
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
                break;
            }
        }

        //расчеты
        protected void ShowScoutsPoint()
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
                    Console.Clear();
                    Console.WriteLine("{0,-15}Видов спорта:{1,-5}Всего баллов:{2,-5}Средний балл:{3}", Scouts[intItem].scoutName, Scouts[intItem].numberOfSports, Scouts[intItem].points, Scouts[intItem].averagePoint);
                    Console.WriteLine("Для возврата нажмите любую клавишу");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Это неверное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                }
                break;
            }
        }

        //показать расчеты
        protected void ShowCalculate()
        {

            double k = 0;
            int count = 0;

            Console.Clear();
            foreach (var item in Scouts)
            {
                k += item.averagePoint;
                count++;
            }
            Console.WriteLine("\tСредний балл лагеря: {0}\n", k / count);
            Console.WriteLine("--------------------------------------------------\n");

            Scout best = CalculationBestScout("Мальчик");
            Console.WriteLine("\tЛучший мальчик:\n\n {0,-20}Средний балл: {1}", best.scoutName, best.averagePoint);
            Console.WriteLine("--------------------------------------------------\n");

            best = CalculationBestScout("Девочка");
            Console.WriteLine("\tЛучшая девочка:\n\n {0,-20}Средний балл: {1}", best.scoutName, best.averagePoint);
            Console.WriteLine("--------------------------------------------------\n");

            best = CalculationBestScoutPoint("Мальчик");
            Console.WriteLine("\tСамый успешный мальчик:\n\n {0,-20}Общий балл: {1}", best.scoutName, best.points);
            Console.WriteLine("--------------------------------------------------\n");

            best = CalculationBestScoutPoint("Девочка");
            Console.WriteLine("\tСамая успешная девочка:\n\n {0,-20}Общий балл: {1}", best.scoutName, best.points);
            Console.WriteLine("--------------------------------------------------\n");

            best = CalculationBestScoutSports("Мальчик");
            Console.WriteLine("\tСамый активный мальчик:\n\n {0,-20}Видов спорта: {1}", best.scoutName, best.numberOfSports);
            Console.WriteLine("--------------------------------------------------\n");

            best = CalculationBestScoutSports("Девочка");
            Console.WriteLine("\tСамая активная девочка:\n\n {0,-20}Видов спорта: {1}", best.scoutName, best.numberOfSports);
            Console.WriteLine("--------------------------------------------------\n");

            Scout lazy = CalculationLazyScoutSports("Мальчик");
            Console.WriteLine("\tСамый ленивый мальчик:\n\n {0,-20}Видов спорта: {1}", lazy.scoutName, lazy.numberOfSports);
            Console.WriteLine("--------------------------------------------------\n");

            lazy = CalculationLazyScoutSports("Девочка");
            Console.WriteLine("\tСамая ленивая девочка:\n\n {0,-20}Видов спорта: {1}", lazy.scoutName, lazy.numberOfSports);
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();

        }

        private Scout CalculationBestScout(string sex)
        {
            Scout bestScout = null;
            double point = 0;
            foreach (Scout item in Scouts)
            {
                if (sex == "Мальчик" && item is scoutGirl)
                {
                    continue;
                }
                if (sex == "Девочка" && item is scoutBoy)
                {
                    continue;
                }
                if (bestScout == null)
                {
                    bestScout = item;
                    point = bestScout.averagePoint;
                }
                else
                {
                    if (item.averagePoint > point)
                    {
                        bestScout = item;
                        point = bestScout.averagePoint;
                    }
                }
            }
            if (bestScout == null)
            {
                bestScout = new Scout();
                bestScout.scoutName = "-";
                bestScout.averagePoint = 0;
            }

            return bestScout;

        }
        private Scout CalculationBestScoutPoint(string sex)
        {
            Scout bestScout = null;
            int point = 0;
            foreach (Scout item in Scouts)
            {
                if (sex == "Мальчик" && item is scoutGirl)
                {
                    continue;
                }
                if (sex == "Девочка" && item is scoutBoy)
                {
                    continue;
                }
                if (bestScout == null)
                {
                    bestScout = item;
                    point = bestScout.points;
                }
                else
                {
                    if (item.averagePoint > point)
                    {
                        bestScout = item;
                        point = bestScout.points;
                    }
                }
            }
            if (bestScout == null)
            {
                bestScout = new Scout();
                bestScout.scoutName = "-";
                bestScout.averagePoint = 0;
            }
            return bestScout;
        }
        private Scout CalculationBestScoutSports(string sex)
        {
            Scout bestScout = null;
            int sports = 0;
            foreach (Scout item in Scouts)
            {
                if (sex == "Мальчик" && item is scoutGirl)
                {
                    continue;
                }
                if (sex == "Девочка" && item is scoutBoy)
                {
                    continue;
                }
                if (bestScout == null)
                {
                    bestScout = item;
                    sports = bestScout.numberOfSports;
                }
                else
                {
                    if (item.numberOfSports > sports)
                    {
                        bestScout = item;
                        sports = bestScout.numberOfSports;
                    }
                }
            }
            if (bestScout == null)
            {
                bestScout = new Scout();
                bestScout.scoutName = "-";
                bestScout.averagePoint = 0;
            }
            return bestScout;
        }
        private Scout CalculationLazyScoutSports(string sex)
        {
            Scout lazyScout = null;
            int sports = 0;
            foreach (Scout item in Scouts)
            {
                if (sex == "Мальчик" && item is scoutGirl)
                {
                    continue;
                }
                if (sex == "Девочка" && item is scoutBoy)
                {
                    continue;
                }
                if (lazyScout == null)
                {
                    lazyScout = item;
                    sports = lazyScout.numberOfSports;
                }
                else
                {
                    if (item.numberOfSports < sports)
                    {
                        lazyScout = item;
                        sports = lazyScout.numberOfSports;
                    }
                }
            }
            if (lazyScout == null)
            {
                lazyScout = new Scout();
                lazyScout.scoutName = "-";
                lazyScout.averagePoint = 0;
            }
            return lazyScout;
        }
    }
}
