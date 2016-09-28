using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeWork12
{
    [JsonObject(MemberSerialization.OptIn)]
    class Learner
    {
        
        public string Name { get; set; }
        
        public int Age { get; set; }
       
        public int Id { get; set; }
        
        public SubjectAndMark subjectAndMark = new SubjectAndMark();

    }
}
