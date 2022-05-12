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


     partial class FormDepartment : Form
    {
        public FormMain Base;
        List<ClassOfficer> off = new List<ClassOfficer>();

        void refresh ()
        {
            off.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            TxtDL.Clear();
            foreach (ClassOfficer a in Base.Main.OF)
            {
                if (a.DepName == "")
                {
                    listBox2.Items.Add(a.FName + " " + a.LName);
                    off.Add(a);

                }
            }
        }
        public FormDepartment()
        {
            InitializeComponent();
        }
        public FormDepartment(FormMain p)
        {
           
           Base = p;
            InitializeComponent();
            listBox2.Items.Clear();
            off.Clear();
                foreach (ClassOfficer a in Base.Main.OF)
            {
                if (a.DepName=="")
                {
                    listBox2.Items.Add(a.FName + " " + a.LName);
                    off.Add(a);

                }
            }
            
        }
      
    private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isthere = true;
            if (TxtDL.Text != "")
            {
                
                foreach (ClassDepartment a in Base.Main.DP)
                    if (TxtDL.Text == a.Location)
                    {
                        isthere = false;
                        break;
                    }

                if (isthere)
                {
                    List<int> index = new List<int>();
                    foreach (object o in listBox2.SelectedItems)
                        index.Add(listBox2.Items.IndexOf(o));
                    if (listBox3.SelectedIndex != -1)
                    {
                        listBox1.Items.Clear();
                        int i = 0;
                        List<ClassOfficer> officers = new List<ClassOfficer>();
                        foreach (object o in listBox3.Items)

                            if (listBox3.Items.IndexOf(o) != listBox3.SelectedIndex)
                            {
                                listBox1.Items.Add(off[index[i]].FName + " " + off[index[i]].LName);
                                officers.Add(off[index[i]]);
                                off[index[i]].DepName = TxtDL.Text;
                                i++;
                            }
                            else
                            {
                                listBox1.Items.Add(off[index[i]].FName + " " + off[index[i]].LName + " Manger");
                                officers.Add(off[index[i]]);
                                off[index[i]].DepName = TxtDL.Text;
                                off[index[i]].isManger = true;
                                i++;
                            }
                        Base.Main.DP.Add(new ClassDepartment(TxtDL.Text, officers));
                        refresh();
                       
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Manger","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Location is Already in use","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please Enter Department Location","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            if (listBox2.SelectedIndex == -1)
                MessageBox.Show("Please Select An Officer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormDepartemetnUpdate FE = new FormDepartemetnUpdate(this);
            FE.Show();
        }
    }
}
