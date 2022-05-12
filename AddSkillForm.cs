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
     partial class AddSkillForm : Form
    {
        MainForm mainForm;
      
        public AddSkillForm()
        {
            InitializeComponent();
        }
        public AddSkillForm(MainForm p)
        {
            InitializeComponent();
            mainForm = p;
            listBox1.Items.Clear();
            foreach (Skills a in mainForm.loginForm.skill)
            {
                listBox1.Items.Add(a.name);
            }
        }
        void refresh()
        {
            listBox1.Items.Clear();
            foreach (Skills a in mainForm.loginForm.skill)
            {
                listBox1.Items.Add(a.name);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TSNa.Text != "" && TSWe.Text != "")
            {
                mainForm.loginForm.skill.Add(new Skills(TSNa.Text, Convert.ToInt32(TSWe.Text)));
                MessageBox.Show("DONE!");

            }
            else
                MessageBox.Show("ERROR");
          
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>-1)
            {
                foreach (Employee b in mainForm.loginForm.employee)
                {
                    foreach (Skills a in b.skills)
                    {
                        if(a==mainForm.loginForm.skill[listBox1.SelectedIndex])
                        {
                            b.skills.Remove(a);
                        }
                    }
                }
                mainForm.loginForm.skill.Remove(mainForm.loginForm.skill[listBox1.SelectedIndex]);
                refresh();
            }
        }
    }
}
