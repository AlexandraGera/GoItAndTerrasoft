using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Employee
    {
        public string name;
        public const byte RATE_HOURS = 180;
        public int totalWorkingHours { get; set; }
        public double salaryInHour { get; set; }
        public double salaryTotal { get; set; }
        public virtual void CalculationSalary()
        {
            salaryTotal = totalWorkingHours * salaryInHour;
        }
    }
}
