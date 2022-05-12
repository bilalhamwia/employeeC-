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
     partial class FormCase : Form
    {
        public FormCase()
        {
            InitializeComponent();
        }
        FormMain Base;
        List<ClassOfficer> off = new List<ClassOfficer>();
        List<ClassCriminal> cff = new List<ClassCriminal>();
        public FormCase(FormMain p)
        {
            Base = p;
            InitializeComponent();
            listBox6.Items.Clear();
            listBox3.Items.Clear();
            foreach (ClassDepartment a in Base.Main.DP)
                listBox6.Items.Add(a.Location);
            foreach (ClassCase a in Base.Main.CC)
                listBox3.Items.Add(a.Name);
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox6.SelectedIndex == -1)
                MessageBox.Show("please select from the listBx of the Department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //show all Officers in the selected department
                //Add the Name of the department to the right textbox
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex == -1)
                MessageBox.Show("please select from the listBx of the Officers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //show all Officers in the selected department
                //add the name of the officer responsible in the right textbox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                //add Selected Case to the other listbox
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("please select from the listBx of the Criminals", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listBox2.Items.Clear();
                List<int> index = new List<int>();
                foreach (object o in listBox1.SelectedItems)
                    index.Add(listBox1.Items.IndexOf(o));
                bool x = true;

                foreach (int a in index)
                {
                    foreach(ClassCriminal b in Base.Main.CC[listBox3.SelectedIndex].criminal)
                        if (cff[a]==b)
                            {
                            x = false;
                            break;
                        }
                   if(x)
                    {
                        listBox2.Items.Add(cff[a].FName + " " + cff[a].LName);
                        if (cff[a].crimelvl < Base.Main.CC[listBox3.SelectedIndex].crimelev)
                        cff[a].crimelvl = Base.Main.CC[listBox3.SelectedIndex].crimelev;
                       
                        Base.Main.CC[listBox3.SelectedIndex].criminal.Add(cff[a]);
                        refresh();
                    }
                   
                }

            }
        }
        void refresh()
        {
            if (listBox3.SelectedIndex != -1)
            {
                listBox4.Items.Clear();
                listBox1.Items.Clear();
                foreach (ClassCase a in Base.Main.CC[listBox3.SelectedIndex].cases)
                {
                    listBox4.Items.Add(a.Name);
                }
                foreach (ClassCriminal a in Base.Main.CF)
                {
                    bool isth = true;
                    foreach (ClassCriminal b in Base.Main.CC[listBox3.SelectedIndex].criminal)
                        if (a == b)
                        {
                            isth = false;
                            break;
                        }
                    if (isth)
                    {
                        listBox1.Items.Add(a.FName + " " + a.LName);
                        cff.Add(a);
                    }
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TxtCCN.Text == "" || TxtCD.Text == "" || TxtCLocation.Text == "" || TxtCCrimeLev.Text == "")
                MessageBox.Show("please fill All the Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox1.Text==""||textBox2.Text=="")
                MessageBox.Show("please Select Department and Officer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(Convert.ToInt32(TxtCCrimeLev.Text )< 0 && Convert.ToInt32(TxtCCrimeLev.Text)>10)
                MessageBox.Show("The Crime LEvel Should be Between 1 to 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                string s = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                List<ClassCase> Case = new List<ClassCase>();
                foreach (ClassCase a in Base.Main.CC)
                {
                    if (off[listBox5.SelectedIndex] == a.Officer || TxtCLocation.Text == a.Location)
                        Case.Add(a);
                }


                    Base.Main.CC.Add(new ClassCase(TxtCCN.Text, TxtCD.Text, TxtCLocation.Text, Convert.ToInt32(TxtCCrimeLev.Text), s,off[listBox5.SelectedIndex], Base.Main.DP[listBox6.SelectedIndex],Case));

                listBox3.Items.Clear();
                foreach (ClassCase a in Base.Main.CC)
                    listBox3.Items.Add(a.Name);
                
                MessageBox.Show("All Data is Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Save all data for later
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox6.SelectedIndex!=-1)
            {
                textBox1.Text = Base.Main.DP[listBox6.SelectedIndex].Location;
                listBox5.Items.Clear();
                off.Clear();
                foreach (ClassOfficer a in Base.Main.DP[listBox6.SelectedIndex].officers)
                {
                    listBox5.Items.Add(a.FName + " " + a.LName);
                    off.Add(a);
                    
                }
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox5.SelectedIndex!=-1)
            {
                textBox2.Text = off[listBox5.SelectedIndex].FName + " " + off[listBox5.SelectedIndex].LName;

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
