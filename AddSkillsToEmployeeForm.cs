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
     partial class AddSkillsToEmployeeForm : Form
    {
        MainForm mainForm;
        List<Skills> off = new List<Skills>();
        List<Skills> notoff = new List<Skills>();
        public AddSkillsToEmployeeForm()
        {
            InitializeComponent();
          
        }
        public AddSkillsToEmployeeForm(MainForm p)
        {
            InitializeComponent();
            mainForm = p;
            listBox1.Items.Clear();
            foreach (Employee a in mainForm.loginForm.employee)
            {
                listBox1.Items.Add(a.firstName + "  " + a.lastName);
            }
        }
        void refresh()
        {
            if(listBox1.SelectedIndex>-1)
            {
                off.Clear();
                notoff.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                
                foreach (Skills a in mainForm.loginForm.skill)
                {
                    bool found = false;
                    foreach (Skills b in mainForm.loginForm.employee[listBox1.SelectedIndex].skills)
                    {
                        if (a == b)
                        {
                            found = true;
                            listBox3.Items.Add(a.name);
                            off.Add(a);
                            break;
                        }
                    }
                    if (!found)
                    {
                        listBox2.Items.Add(a.name);
                        notoff.Add(a);
                    }
                       
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1 && listBox1.SelectedIndex > -1)
            {
                mainForm.loginForm.employee[listBox1.SelectedIndex].skills.Remove(off[listBox3.SelectedIndex]);
                refresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex>-1 && listBox1.SelectedIndex>-1)
            {
                mainForm.loginForm.employee[listBox1.SelectedIndex].skills.Add(notoff[listBox2.SelectedIndex]);
                refresh();
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
