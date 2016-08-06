using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    interface IBonuses
    {
        int bonusHours { get; set; }
        void CalculationBonuses();
    }
}
