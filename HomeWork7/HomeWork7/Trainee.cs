using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    sealed class Trainee : IBonuses
    {
        Employee mentor;
        public Trainee(Employee mentor)
        {
            this.mentor = mentor;
        }
        public int bonusHours { get; set; }
        public void CalculationBonuses()
        {
            mentor.salaryTotal += bonusHours * 1.5 * mentor.salaryInHour;
        }

    }
}
