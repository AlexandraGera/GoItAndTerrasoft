using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
   public enum Enum:sbyte
    {
        hi=1,
        how,
        weather,
        by,
        dont
    }
    abstract class Lang
    {
       public Dictionary<string, sbyte> phrases = new Dictionary<string, sbyte>
        {
            {"hi",1},{"hello",1},{"hey",1},{"прив",1},{"здрав",1},{"здаров",1},{"віта",1},
            {"how are you",2},{"How're you",2},{"как ты",2},{"дела",2},{"почува",2},{"як ти",2},{"справи",2},
            {"weather",3},{"погода",3},
            {"see you",4},{"bye",4},{"пока",4},{"свидания",4},{"побачен",4},{"бувай",4}
        };
        public sbyte Inspection(string str)
        {
            sbyte index = -1;
            foreach (var item in phrases)
            {
                if (str.IndexOf(item.Key) != -1)
                {
                    index = item.Value;
                    break;
                }
                else
                {
                    continue;
                }      
            }
            if (index == -1)
            {
                index = (sbyte)Enum.dont;
            }
            return index;
        }
        public void Reply(sbyte index)
        {
            switch (index)
            {
                case (sbyte)Enum.hi:
                    Greeting();
                    break;
                case (sbyte)Enum.how:
                    AskHowAreYou();
                    break;
                case (sbyte)Enum.weather:
                    AskWeather();
                    break;
                case (sbyte)Enum.by:
                    Goodbye();
                    break;
                default:
                    DoNotUnderstand();
                    break;
            }
        }
        public abstract void Greeting();
        public abstract void AskHowAreYou();
        public abstract void AskWeather();
        public abstract void DoNotUnderstand();
        public abstract void Goodbye();
    }
}
