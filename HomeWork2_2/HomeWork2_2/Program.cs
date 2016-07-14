using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //area circle and volume sphere
            Console.WriteLine("Вычисление площади круга и объема шара по радиусу\n");

            Console.WriteLine("Введите радиус");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaCircle = radius * radius * Math.PI;
            double volumeSphere = (Math.PI / 3 * 4) * (Math.Pow(radius, 3));

            Console.WriteLine("Площадь круга {0}", areaCircle);
            Console.WriteLine("Объем шара {0}\n\n", volumeSphere);

            //area rectangle
            Console.WriteLine("Вычисление площади прямоугольника\n");

            Console.WriteLine("Введите длину стороны а");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны b");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double areaRectangle = sideA * sideB;
            Console.WriteLine("Площадь прямоугольника {0}\n\n", areaRectangle);

            //volume box
            Console.WriteLine("Вычисление объема прямоугольного параллелепипеда\n");

            Console.WriteLine("Введите длину стороны основания а");
            double groundA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны основания b");
            double groundB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту");
            double height = Convert.ToDouble(Console.ReadLine());

            double areaBox = groundA * groundB * height;
            Console.WriteLine("Объем прямоугольного параллелепипеда {0}", areaBox);

            Console.ReadKey();
        }
    }
}
