using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork12
{
    class SubjectAndMark : IEnumerable<KeyValuePair<string, int>>
    {
        private Dictionary<string, int> Subjects=new Dictionary<string, int>();

        public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
        {
            foreach (var grade in this.Subjects)
                yield return grade;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, int>>)Subjects).GetEnumerator();
        }

        public void AddSubject( string NameSabjectArg, int MarkArg)
        {
            this.Subjects.Add(NameSabjectArg, MarkArg);
        }

        public double AverageMark()
        {
            if (this.Subjects.Count() > 0)
            {
                int sum = 0;
                foreach (var item in this.Subjects)
                    sum += item.Value;
                return ((double)sum / Subjects.Count);
            }
            else
                return 0;  
        }
        public void ShowSubject()
        {
            foreach (var itemMark in this.Subjects)
            {
                Console.WriteLine("{0,-20} Б: {1}", itemMark.Key, itemMark.Value);
            }
        }
    }
}
