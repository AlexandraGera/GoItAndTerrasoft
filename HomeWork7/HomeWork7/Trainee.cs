using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    sealed class Trainee :Employee
    {
        public Employee mentor;
        public Trainee(Employee mentorArg)
        {
            this.mentor = mentorArg;
        }
        public new int bonusHours { get; set; }
        public override void CalculationBonuses()
        {
            mentor.salaryTotal += bonusHours * 1.5 * mentor.salaryInHour;
        }

    }
}
