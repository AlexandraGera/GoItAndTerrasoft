using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Employee:IBonuses
    {
        public string name;
        public const byte RATE_HOURS = 180;
        public int totalWorkingHours { get; set; }
        public double salaryInHour { get; set; }
        public double salaryTotal { get; set; }
        public int bonusHours { get; set; }
        public virtual void CalculationBonuses()
        {
            salaryTotal += bonusHours  * salaryInHour;
        }
        public virtual void DataInput()
        {
        }
        public virtual void CalculationSalary()
        {
            salaryTotal = totalWorkingHours * salaryInHour;
        }
        protected bool Inspection(string number)
        {
            byte byteNumber = 0;
            if (Byte.TryParse(number, out byteNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
