using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type byte:\n default value {0}, min {1}, max {2}\n ", new Byte { }, Byte.MinValue, Byte.MaxValue);

            Console.WriteLine("Type sbyte:\n default value {0}, min {1}, max {2}\n", new SByte { }, SByte.MinValue, SByte.MaxValue);

            Console.WriteLine("Type short:\n default value {0}, min {1}, max {2}\n", new Int16 { }, Int16.MinValue, Int16.MaxValue);

            Console.WriteLine("Type ushort:\n default value {0}, min {1}, max {2}\n", new UInt16 { }, UInt16.MinValue, UInt16.MaxValue);

            Console.WriteLine("Type int:\n default value {0}, min {1}, max {2}\n", new Int32 { }, Int32.MinValue, Int32.MaxValue);

            Console.WriteLine("Type uint:\n default value {0}, min {1}, max {2}\n", new UInt32 { }, UInt32.MinValue, UInt32.MaxValue);

            Console.WriteLine("Type long:\n default value {0}, min {1}, max {2}\n", new Int64 { }, Int64.MinValue, Int64.MaxValue);

            Console.WriteLine("Type ulong:\n default value {0}, min {1}, max {2}\n", new UInt64 { }, UInt64.MinValue, UInt64.MaxValue);

            Console.WriteLine("Type float:\n default value {0}, min {1}, max {2}\n", new Single { }, Single.MinValue, Single.MaxValue);

            Console.WriteLine("Type double:\n default value {0}, min {1}, max {2}\n", new Double { }, Double.MinValue, Double.MaxValue);

            Console.WriteLine("Type decimal:\n default value {0}, min {1}, max {2}\n\n", new Decimal { }, Decimal.MinValue, Decimal.MaxValue);

            Console.WriteLine("Type bool:\n default value {0}\n", new Boolean { });

            Console.WriteLine("Type char:\n default value {0}\n", new Char { });

            Console.ReadKey();
        }
    }
}
