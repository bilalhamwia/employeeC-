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
     partial class EvaluationForm : Form
    {
        public EvaluationForm()
        {
            InitializeComponent();
        }
        public Employee Employee;
       public MainForm Base;
        public EvaluationForm(MainForm p)
        {
            InitializeComponent();
            Base = p;
            listBox1.Items.Clear();
            foreach (Team a in Base.loginForm.team)
            {
                listBox1.Items.Add(a.name);
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>-1)
            {
                listBox2.Items.Clear();
                foreach (Employee a in Base.loginForm.employee)
                {
                    listBox2.Items.Add(a.firstName+ " " +a.lastName);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                Employee = Base.loginForm.employee[listBox2.SelectedIndex];
                EvaForm FE = new EvaForm(this);
                FE.Show();
            }
        }
    }
}
