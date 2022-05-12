using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class ClassCell
    {
        public int IDNum;
        public string Code;
        public double Capacity;
        public int Level;
        public bool isfull = false;
        public int counter=0;
       public List<ClassCriminal> CR=new List<ClassCriminal>();
        public int Lev
        {
            get { return Level; }
            set
            {
                if (Level >= 1 && Level <= 10)
                    Level = value;
                
            }
        }
        public ClassCell(int idnum, string code, double capacity, int level)
        {
            IDNum = idnum;
            Code = code;
            Capacity = capacity;
            Level = level;
          
        }
        public void AddPerson(ClassCriminal a)
        {
            
            CR.Add(a);
            counter++;
            if (counter == Capacity)
                isfull = true;

        }
        
    }
}
