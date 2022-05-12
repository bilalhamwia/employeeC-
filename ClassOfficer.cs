using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
    class ClassOfficer:ClassPerson
    {
        //remember the need for birthdate in form
         string email;
         double phone;
        public string DepName { set; get; }
        public bool isManger { set; get; }
        public bool isPatrol { set; get; }
        public String Email
        {
            get
            {
                return email;
            }
        }
        public Double Phone
        {
            get
            {
                return phone;
            }
        }
    
    
        public ClassOfficer(string fname, string lname, string address, string bdate,string email, double phone):base(fname,lname,address,bdate)
        {
            isManger = false;
            DepName = "";
            this.email = email;
            this.phone = phone;
           
        }
    }
}
