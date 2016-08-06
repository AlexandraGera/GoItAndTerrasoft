using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Psychologist : Employee, IBonuses
    {
        public int visitors { get; set; }
        public int bonusHours { get; set; }
        public void CalculationBonuses()
        {
            salaryTotal += bonusHours * 2 * salaryInHour;
        }
        public override void CalculationSalary()
        {
            salaryTotal = totalWorkingHours * salaryInHour;
            for (int i = 0; i <= visitors; i++)
            {
                salaryTotal *= 1.2;
            }
        }
    }
}
