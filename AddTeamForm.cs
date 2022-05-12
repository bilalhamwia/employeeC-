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
    partial class AddTeamForm : Form
    {
      public  MainForm Base;
       public List<Employee> off = new List<Employee>();

        void refresh()
        {
            off.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            TxtDL.Clear();
            foreach (Employee a in Base.loginForm.employee)
            {
                if (a.team == null)
                {
                    listBox2.Items.Add(a.firstName + " " + a.lastName);
                    off.Add(a);

                }
            }
        }
        public AddTeamForm()
        {
            InitializeComponent();
        }
        public AddTeamForm(MainForm p)
        {

            Base = p;
            InitializeComponent();
            listBox2.Items.Clear();
            off.Clear();
            foreach (Employee a in Base.loginForm.employee)
            {
                if (a.team == null)
                {
                    listBox2.Items.Add(a.firstName + " " + a.lastName);
                    off.Add(a);

                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool isthere = true;
            if (TxtDL.Text != "")
            {

                foreach (Team a in Base.loginForm.team)
                    if (TxtDL.Text == a.name)
                    {
                        isthere = false;
                        break;
                    }

                if (isthere)
                {
                    string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    List<int> index = new List<int>();
                    foreach (object o in listBox2.SelectedItems)
                        index.Add(listBox2.Items.IndexOf(o));
                    if (listBox3.SelectedIndex != -1)
                    {
                        listBox1.Items.Clear();
                        int i = 0;
                        List<Employee> Employ = new List<Employee>();

                        Team T = (new Team(TxtDL.Text, theDate));
                        foreach (object o in listBox3.Items)

                            if (listBox3.Items.IndexOf(o) != listBox3.SelectedIndex)
                            {
                                listBox1.Items.Add(off[index[i]].firstName + " " + off[index[i]].lastName);
                                Employ.Add(off[index[i]]);
                                off[index[i]].team = T;
                                T.teamMembers.Add(off[index[i]]);
                                i++;
                            }
                            else
                            {
                                listBox1.Items.Add(off[index[i]].firstName + " " + off[index[i]].lastName + " Team Leader");
                                Employ.Add(off[index[i]]);
                                off[index[i]].team = T;
                                T.teamMembers.Add(off[index[i]]);
                                T.teamLeader = off[index[i]];
                                off[index[i]].IsTeamLeader = true;
                                i++;
                            }



                        Base.loginForm.team.Add(T);
                        refresh();

                    }
                    else
                    {
                        MessageBox.Show("Please Select a Team Leader", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Name  Already in use", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please Enter Team Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            if (listBox2.SelectedIndex == -1)
                MessageBox.Show("Please Select An Employee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<int> index = new List<int>();
                foreach (object o in listBox2.SelectedItems)
                {
                    index.Add(listBox2.Items.IndexOf(o));
                }
                foreach (int a in index)
                {
                    listBox3.Items.Add(off[a].FName + " " + off[a].LName);
                    listBox1.Items.Add(off[a].FName + " " + off[a].LName);
                }
            }

        } */

       

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            if (listBox2.SelectedIndex == -1)
                MessageBox.Show("Please Select An Employee", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                List<int> index = new List<int>();
                foreach (object o in listBox2.SelectedItems)
                {
                    index.Add(listBox2.Items.IndexOf(o));
                }
                foreach (int a in index)
                {
                    listBox3.Items.Add(off[a].firstName + " " + off[a].lastName);
                    listBox1.Items.Add(off[a].firstName + " " + off[a].lastName);
                }
            }
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            UpdateTeamsForm FE = new UpdateTeamsForm(this);
            FE.Show();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

 