using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class Position
    {
        public string name;
        public string letterGrade;
        public double minimumSalary;
        public double maximumSalary;
        public Position(string name,string letterGrade, double minimumSalary, double maximumSalary)
        {
            this.name = name;
            this.letterGrade= letterGrade;
            this.minimumSalary= minimumSalary;
            this.maximumSalary= maximumSalary;
        }
    }
}
