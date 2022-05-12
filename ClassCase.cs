using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class ClassCase
    {
        public string Date { set; get; }
        //related cases are unknown
        public string Name;
        public string Description;
        public string Location;
        private int CrimeLev;
        public List<ClassCriminal> criminal = new List<ClassCriminal>();
        public List<ClassCase> cases = new List<ClassCase>();
        public int crimelev
        {
            get { return CrimeLev; }
            set
            {
                if (CrimeLev > 0 && CrimeLev <= 10)
                    CrimeLev = value;
                else
                    CrimeLev = 0;
            }
        }
        public ClassOfficer Officer { set; get; }
        public ClassDepartment Dep { set; get; }
        public ClassCase(string name, string description, string location, int crimelevel,string s,ClassOfficer o,ClassDepartment D, List<ClassCase> c)
        {
            Name = name;
            Description = description;
            Location = location;
            crimelev = crimelevel;
            Officer = o;
            Dep = D;
            cases.AddRange(c);
           

        }
    }
}
