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
     partial class FormPatrol : Form
    {
        public FormMain Base;
        public FormPatrol()
        {
            InitializeComponent();
        }
         
        public FormPatrol(FormMain p)
        {

            Base = p;
            InitializeComponent();
            Base = p;
            listBox1.Items.Clear();
            foreach (ClassDepartment a in Base.Main.DP)
            {
                listBox1.Items.Add(a.Location);
             
            }
        }
        List<ClassOfficer> off = new List<ClassOfficer>();
        List<ClassOfficer> cff = new List<ClassOfficer>();
        int dpi = -1;


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TxtPAC.Text != "" && TxtPAL.Text != "")
                if(Convert.ToInt32(TxtPAL.Text )> 0 && Convert.ToInt32(TxtPAL.Text)<=3)
            {
                listBox3.Items.Clear();
                List<int> index = new List<int>();
                foreach (object o in listBox2.SelectedItems)
                    index.Add(listBox2.Items.IndexOf(o));
                if (index.Count() >=2)
                {
                    
                    if (!Base.Main.DP[dpi].officers[index[0]].isPatrol && !Base.Main.DP[dpi].officers[index[1]].isPatrol)
                    {
                        off.Clear();
                            foreach(int a in index)

                            {
                                listBox3.Items.Add(cff[a].FName+" "+cff[a].LName);
                                cff[a].isPatrol = true;
                                off.Add(cff[a]);
                            }
                        
                       

                        Base.Main.PA.Add(new ClassPatrol(Convert.ToDouble(TxtPAC.Text), Convert.ToInt32(TxtPAL.Text), off));
                    }
                    else
                        MessageBox.Show("Officers already in patrol please select another one","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please Selcet at Least 2 Officers","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }

            }
            else
                    MessageBox.Show("Arming level should be form 1-3", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Please enter Data","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
          
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if(listBox1.SelectedIndex!=-1)
            {
                dpi = listBox1.SelectedIndex;

                foreach (ClassOfficer a in Base.Main.DP[dpi].officers)
                    if (!a.isPatrol)
                    {
                        listBox2.Items.Add(a.FName + " " + a.LName);
                        cff.Add(a);
                    }

            }
            else
            {
                MessageBox.Show("Select a Department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (ClassDepartment a in Base.Main.DP)
                listBox1.Items.Add(a.Location);

        }
    }
}
