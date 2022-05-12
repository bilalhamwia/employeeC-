using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class Team
    {
        public string name;
        public string creationDate;
        public List<Employee> teamMembers = new List<Employee>();
        public Employee teamLeader;
        public Team(string Name, string CreationDate)
        { 
            this.name = Name;
            this.creationDate = CreationDate;
           
        }

    }
}
