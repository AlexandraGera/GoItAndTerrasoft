using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class scoutBoy : Scout
    {
        public new List<Sport> SportsList = new List<Sport> {
         new Sport() {nameSport= "Football", Id=1},
         new Sport() {nameSport= "Arm wrestling",Id=2},
         new Sport() {nameSport= "Basketball",Id=3},
         new Sport() {nameSport= "Boxing",Id=4}
        };
    }
}
