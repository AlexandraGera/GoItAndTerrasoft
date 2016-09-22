using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double Discount { get; set; }
        public double Total
        {
            get { return (Amount * Price) * (1 - Discount * 0.01); }
        }
    }
}
