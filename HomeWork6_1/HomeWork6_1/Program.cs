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

        }
    }


    class Scout
    {
        string name;
        string sex;
        int points;
        int numberOfSports;
        double averagePoint;

        //private Dictionary<String, Byte> Aachievement = new Dictionary<String, Byte>();

        
    }


    class scoutBoy : Scout
    {
        public static  String[] boysSports = {
           "Football",
           "Arm wrestling",
           "Basketball",
           "Boxing"
       };
    }


    class scoutGirl : Scout
    {
        public static  String[] girlSports = {
           "Gymnastics",
           "Athletics",
           "Swimming",
           "Dancing"
       };

    }

    class WorkWithScout
    {
        public void Menu()
        {

        }
    }

    class Sport
    {
       public string name;

    }

    //List<Product> products = new List<Product>
    //    {
    //        new Product(){Id = 1, Name = "Apple", Price = 1.0 },
    //        new Product(){Id = 2, Name = "Milk", Price = 1.5 },
    //        new Product(){Id = 3, Name = "Cola", Price = 0.75 },
    //        new Product(){Id = 4, Name = "Bread", Price = 2.55 },
    //        new Product(){Id = 5, Name = "Chocolate", Price = 3.00 }
    //    };
}
