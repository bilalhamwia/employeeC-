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
     partial class FormDepartemetnUpdate : Form
    {
        public FormDepartemetnUpdate()
        {
            InitializeComponent();
        }
            FormDepartment mini;
            List<ClassOfficer> notoff = new List<ClassOfficer>();
            List<ClassOfficer> off = new List<ClassOfficer>();
        public FormDepartemetnUpdate(FormDepartment p)
            {
                InitializeComponent();
                mini = p;
                listBox1.Items.Clear();
                foreach (ClassDepartment a in mini.Base.Main.DP)
                listBox1.Items.Add(a.Location);
            
        }
        void refresh()
        {


            notoff.Clear();
            off.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                foreach (ClassOfficer a in mini.Base.Main.OF)
                {   if (listBox1.SelectedIndex>-1)
                     if (a.DepName != mini.Base.Main.DP[listBox1.SelectedIndex].Location)
                    {
                        listBox2.Items.Add(a.FName + " " + a.LName);
                        notoff.Add(a);
                    }
                    else
                    {
                            if (a.isManger)
                            {
                                listBox3.Items.Add(a.FName + " " + a.LName + " Manger");
                                off.Add(a);
                            }
                            else
                            {
                                listBox3.Items.Add(a.FName + " " +a.LName);
                                off.Add(a);
                            }
                    }
                }
            }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex!=-1)
            foreach (ClassDepartment a in mini.Base.Main.DP)
                if (notoff[listBox2.SelectedIndex].DepName==a.Location)
                {
                    a.officers.Clear();
                    foreach (ClassOfficer b in mini.Base.Main.OF)
                        if (b.DepName == a.Location)
                            a.officers.Add(b);
                    break;
                }
        

            notoff[listBox2.SelectedIndex].DepName = mini.Base.Main.DP[listBox1.SelectedIndex].Location;
            notoff[listBox2.SelectedIndex].isManger = false;
            mini.Base.Main.DP[listBox1.SelectedIndex].officers.Add(notoff[listBox1.SelectedIndex]);
            refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
                foreach (ClassDepartment a in mini.Base.Main.DP)
                if (off[listBox3.SelectedIndex].DepName == a.Location)
                    if (!off[listBox3.SelectedIndex].isManger)
                    {
                        a.officers.Clear();
                        foreach (ClassOfficer b in mini.Base.Main.OF)
                            if (b.DepName == a.Location)
                                a.officers.Add(b);
                        off[listBox3.SelectedIndex].DepName = "";
                        refresh();
                        break;
                    }
                    else
                        MessageBox.Show("Can't Remove Manger", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = listBox3.SelectedIndex;
            int j= listBox1.SelectedIndex;
            foreach (ClassOfficer a in mini.Base.Main.DP[j].officers)
                if (a.isManger)
                { a.isManger = false;
                    mini.Base.Main.DP[j].officers[i].isManger = true;
                    refresh();
                    break;
                }


        }
    }
}
