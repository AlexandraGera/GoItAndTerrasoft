using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Russian:Lang 
    {
        public override void Greeting()
        {
            string[] array = new string[] { "Привет", "Здравствуй", "Приветствую" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void AskHowAreYou()
        {
            string[] array = new string[] { "Хорошо", "Норм", "Не очень" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void AskWeather()
        {
            string[] array = new string[] { "Хорошая погода", "Как-то не очень", "Нормальная" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void DoNotUnderstand()
        {
            string[] array = new string[] { "Что говоришь ?", "Не понимаю :(", "Ничего об этом не знаю :)" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void Goodbye()
        {
            string[] array = new string[] { "Пока", "Увидимся", "Было приятно пообщаться :)" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
    }
}
