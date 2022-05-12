using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class ClassPatrol
    {
        //remember to add a condition for armlevel=0
        //add the number of officers
        public double Area;
        public int ArmLevel;
        public List<ClassOfficer> officer=new List<ClassOfficer>();


        public int arminlevel
        {
            get { return ArmLevel; }
            set
            {
                if (ArmLevel >= 1 && ArmLevel <= 3)
                {
                    ArmLevel = value;
                }
                else
                {
                    ArmLevel = 0;
                }
            }
        }
        public ClassPatrol(double area, int armlevel, List<ClassOfficer> officer)
        {
            Area = area;
            ArmLevel = armlevel;
            officer.AddRange(officer);

        }
    }
}
