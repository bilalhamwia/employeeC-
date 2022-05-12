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
     partial class UpdateTeamsForm : Form
    {
        
        public UpdateTeamsForm()
        {
            InitializeComponent();
        }
        AddTeamForm addTeamForm;
        List<Employee> notoff = new List<Employee>();
        List<Employee> off = new List<Employee>();
        Team b;
        public UpdateTeamsForm(AddTeamForm p)
        {
            InitializeComponent();
            addTeamForm = p;
            listBox1.Items.Clear();
            foreach (Team a in addTeamForm.Base.loginForm.team)
                listBox1.Items.Add(a.name);
            

        }
        void refresh()
        {

           
            notoff.Clear();
            off.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
           
            if (listBox1.SelectedIndex > -1)
             b   = addTeamForm.Base.loginForm.team[listBox1.SelectedIndex];


            if (listBox1.SelectedIndex > -1)
                foreach (Employee a in addTeamForm.Base.loginForm.employee)
                {
                    if (a.team == addTeamForm.Base.loginForm.team[listBox1.SelectedIndex])
                    {
                        if (listBox1.SelectedIndex > -1)
                            if (a.IsTeamLeader)
                            {
                                listBox3.Items.Add(a.firstName + " " + a.lastName + " Team Leader");
                                off.Add(a);
                            }
                            else
                            {
                                listBox3.Items.Add(a.firstName + " " + a.lastName);
                                off.Add(a);
                            }
                    }
                        else
                        {
                            if(a.team!=null)
                        {
                            listBox2.Items.Add(a.firstName + " " + a.lastName+ " Already in Team " +a.team.name);
                            notoff.Add(a);
                        }
                           
                        else
                        {
                            listBox2.Items.Add(a.firstName + " " + a.lastName);
                            notoff.Add(a);
                        }
                       }
                }

        }

        
    


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                if (!notoff[listBox2.SelectedIndex].IsTeamLeader)
                {
                    if (notoff[listBox2.SelectedIndex].team == null)
                    {
                        notoff[listBox2.SelectedIndex].team = b;
                        b.teamMembers.Add(notoff[listBox2.SelectedIndex]);
                    }
                    else
                    {
                        notoff[listBox2.SelectedIndex].team.teamMembers.Remove(notoff[listBox2.SelectedIndex]);
                        notoff[listBox2.SelectedIndex].team = b;
                        b.teamMembers.Add(notoff[listBox2.SelectedIndex]);
                    }
                }
                else
                    MessageBox.Show("Can't Add TeamLeader To Another Team", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refresh();

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>-1)
            {
                foreach (Employee a in b.teamMembers)
                {
                    a.team = null;
                    a.IsTeamLeader = false;
                    addTeamForm.Base.loginForm.team.Remove(b);
                }
            }
            listBox1.Items.Clear();
            foreach (Team a in addTeamForm.Base.loginForm.team)
            listBox1.Items.Add(a.name);
            refresh();
        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                if (!off[listBox3.SelectedIndex].IsTeamLeader)
                {
                    b.teamLeader.IsTeamLeader = false;
                    b.teamLeader = off[listBox3.SelectedIndex];
                    off[listBox3.SelectedIndex].IsTeamLeader = true;

                }

                else
                    MessageBox.Show("This employee is Already Team Leader", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                if (!off[listBox3.SelectedIndex].IsTeamLeader)
                {
                    b.teamMembers.Remove(off[listBox3.SelectedIndex]);
                    off[listBox3.SelectedIndex].team = null;

                }

                else
                    MessageBox.Show("Can't Remove TeamLeader ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            refresh();
        }
    }
}
