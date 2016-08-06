using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class OrdinaryWorker : Employee, IBonuses
    {
        public int Overtime { get; set; }
        public int bonusHours { get; set; }
        public void CalculationBonuses()
        {
            salaryTotal += bonusHours * 4 * salaryInHour;
        }
        public override void CalculationSalary()
        {
            Overtime = totalWorkingHours - RATE_HOURS;
            salaryTotal = (RATE_HOURS + Overtime * 3) * salaryInHour;
        }
    }
}
