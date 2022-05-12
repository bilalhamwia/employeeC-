
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class Evaluation
    {
        public string review;
        public double evaluation;
        public Employee evaluator;
        public Skills skill;

        public Evaluation(string review, double evaluation, Employee Evaluater,Skills skill)
        {
            this.review = review;
            this.skill = skill;
            this.evaluator = Evaluater;
            this.evaluation = evaluation;
        }
    }
}
