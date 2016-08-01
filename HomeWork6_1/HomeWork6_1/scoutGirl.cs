using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_1
{
    class scoutGirl : Scout
    {
        public new List<Sport> SportsList = new List<Sport> {
         new Sport() {nameSport= "Gymnastics", Id=1},
         new Sport() {nameSport= "Athletics", Id=2},
         new Sport() {nameSport= "Swimming", Id=3},
         new Sport() {nameSport= "Dancing", Id=4}
        };
    }
}
