using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class Scout
    {
        public string scoutName;
        public string scoutSex;
        public int points;
        public int numberOfSports;
        public double averagePoint;

        List<Scout> Scouts = new List<Scout> { };
        public List<Sport> SportsList = new List<Sport>();

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

        public List<Sport> SportsAddRemove(List<Sport> SportList, int i)
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

        public int QuantitySports(List<Sport> SportsList)
        {
            numberOfSports = 0;
            foreach (var item in SportsList)
            {
                if (item.onOf == true)
                {
                    ++numberOfSports;
                }
                else
                {
                    continue;
                }
            }
            return numberOfSports;
        }

        public int totalScore(List<Sport> SportsList)
        {
            points = 0;
            foreach (var item in SportsList)
            {
                if (item.onOf == true)
                {
                    points += item.pointSport;
                }
                else
                {
                    continue;
                }
            }
            return points;
        }

        public double averageScore(List<Sport> SportsList, int sports)
        {
            double i = 0;
            foreach (var item in SportsList)
            {
                i += item.average;
            }
            return i / sports;
        }
    }
}
