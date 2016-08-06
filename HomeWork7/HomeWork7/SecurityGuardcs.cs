using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class SecurityGuard : Employee, IBonuses
    {
        public int dayWorkingHours { get; set; }
        public int nightWorkingHours { get; set; }
        public int bonusHours { get; set; }
        int bonusDay { get; set; }
        int bonusNight { get; set; }
        public void CalculationBonuses()
        {
            bonusHours = bonusDay * 2 + bonusNight * 3;
            salaryTotal += bonusHours * salaryInHour;
        }
        public override void CalculationSalary()
        {
            totalWorkingHours = dayWorkingHours + nightWorkingHours;
            salaryTotal = (dayWorkingHours + nightWorkingHours * 2) * salaryInHour;
        }
    }
}
