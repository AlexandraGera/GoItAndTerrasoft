using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Doctor : Employee, IBonuses
    {
        public int cured { get; set; }
        public int bonusHours { get; set; }
        public void CalculationBonuses()
        {
            salaryTotal += bonusHours * salaryInHour;
        }
        public override void CalculationSalary()
        {
            salaryTotal = totalWorkingHours * salaryInHour;
            salaryTotal += cured * 50;
        }
    }
}
