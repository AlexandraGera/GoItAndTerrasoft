using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class English:Lang
    {
        public override void Greeting()
        {
            string[] array = new string[] { "Hi", "Hello", "Good day" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void AskHowAreYou()
        {
            string[] array = new string[] { "I'm fine", "So far so good", "So-so" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void AskWeather()
        {
            string[] array = new string[] { "The weather is fine", "The weather is getting warmer", "I think it will clear up soon" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void DoNotUnderstand()
        {
            string[] array = new string[] { "What are you talking about?", "I don't understand :(", "Do not have any idea :)" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
        public override void Goodbye()
        {
            string[] array = new string[] { "Bye!", "See you later :)", "Goodbye" };
            Random rnd = new Random();
            Console.WriteLine("Бот: {0}\n", array[rnd.Next(0, 3)]);
        }
    }
}
