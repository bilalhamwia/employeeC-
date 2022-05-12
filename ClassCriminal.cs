using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class ClassCriminal:ClassPerson
    {
        //remember the need for Birthdate in Form
        public double nationalNum;
        public bool incase = false;
        public int crimelvl=0;
        public bool incell = false;

        public double NationalNum {
            get
            {
                return nationalNum;
            }
            }
        public ClassCriminal(string fname, string lname, string address,string bdate ,double nationalnum) :base(fname,lname,address,bdate)
        {
            this.nationalNum = nationalnum;
        }
    }
}
