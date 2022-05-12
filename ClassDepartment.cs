using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class ClassDepartment
    {

        public string Location { get; set; }
        //don't forget to add manager and adding officer's in the department
        public List<ClassOfficer> officers = new List<ClassOfficer>();
        public ClassDepartment(string location, List<ClassOfficer> officer)
        {
            Location = location;
            officers.AddRange(officer);
        }
        public void AddOfficer(ClassOfficer O)
        {
            officers.Add(O);
        }
    }
}
