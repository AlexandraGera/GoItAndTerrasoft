using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class LearnerList : IEnumerable<Learner>
    {
        private List<Learner> learnerList=new List<Learner>();
        
        
        IEnumerator<Learner> IEnumerable<Learner>.GetEnumerator()
        {
            foreach (var item in learnerList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<Learner>)this;
        }

        public void AddLearner(string NameArg, int AgeArg, int IdArg)
        {
            this.learnerList.Add(new Learner {Id=IdArg, Name = NameArg,Age = AgeArg});
        }
        
    }
}
