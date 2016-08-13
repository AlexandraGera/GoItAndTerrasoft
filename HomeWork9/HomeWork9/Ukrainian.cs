using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Ukrainian:Lang
    {
        public override void Greeting()
        {
            string[] array = new string[] { "Вітаю", "Привіт", "Доброго дня" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n",array[rnd.Next(0, 3)]);
        }
        public override void AskHowAreYou()
        {
            string[] array = new string[] { "Все добре", "Норм", "Не дуже" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void AskWeather()
        {
            string[] array = new string[] { "Мені подобається", "Якось не дуже", "Піде" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void DoNotUnderstand()
        {
            string[] array = new string[] { "Що говориш ?", "Не розумію :(", "Нічого про це не знаю" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void Goodbye()
        {
            string[] array = new string[] { "Пока", "До побачення", "Було приємно поспілкуватися" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
    }
}
