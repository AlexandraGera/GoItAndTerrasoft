using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class Sport
    {
        public string nameSport;
        public byte Id;
        public int pointSport;
        public double average;
        public bool onOf = false;

        public SortedList<String, Byte> SportAchievement = new SortedList<String, Byte> { };

        public void ShowAchivment(SortedList<String, Byte> Achivement)
        {
            int counter = 1;
            foreach (KeyValuePair<String, Byte> item in Achivement)
            {
                Console.WriteLine("{0}. {1,-20} Баллы: {2}", counter, item.Key, item.Value);
                counter++;
            }
        }

        public void RemoveAchivment(SortedList<String, Byte> Achivement, int i)
        {
            Achivement.RemoveAt(i);
        }

        public int SportPoint(SortedList<String, Byte> SportAchievement)
        {
            pointSport = 0;
            foreach (var item in SportAchievement)
            {
                pointSport += item.Value;
            }
            return pointSport;
        }

        public double AveragePointSport(SortedList<String, Byte> SportAchievement)
        {
            int countAchievement = 0;
            int i = 0;
            foreach (var item in SportAchievement)
            {
                ++countAchievement;
                i += item.Value;
            }
            return average = i / countAchievement;
        }
    }
}
