using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPage
{
     partial class LoginForm : Form
    {
        public List<Employee> employee= new List<Employee>();
        public List<Position> position = new List<Position>();
        public List<Skills> skill = new List<Skills>();
        public List<Team> team = new List<Team>();
        public Employee loggedUser;

        public LoginForm()
        {
            employee.Add(new Employee("bilal", "hamwia", 1, 1, null));
            employee[0].IsManager = true;
            //employee[0].userName = "test";
            employee[0].password = "admin";
            employee.Add(new Employee("", "", 1, 1, null));
            employee[1].password = "";
            InitializeComponent();
            employee.Add(new Employee("Abeer", "Hamwia", 1, 1, null));
            employee.Add(new Employee("admin", "admin", 1, 1, null));
            // employee[3].IsManager = true;
            Console.WriteLine(employee[0].userName);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool correctLogin = false;
             foreach (Employee A in employee)
             {
             if (A.password==TPassword.Text && A.userName == TUserName.Text)
              {
                loggedUser = A;
                correctLogin = true;
                break;
              }
             
             }

            if(correctLogin)
            {
                MessageBox.Show("Login Successfully", "Congratulataion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm formMain = new MainForm(this);
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please type admin,admin to Enter","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}