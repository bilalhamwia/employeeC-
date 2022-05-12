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
     partial class FormPersonToCell : Form
    {
        public FormPersonToCell()
        {
            InitializeComponent();
        }
        FormMain Base;
        int index1=0;
        List<ClassCriminal> CR = new List<ClassCriminal>();
        public FormPersonToCell(FormMain p)
        {
            Base = p;
            InitializeComponent();
            refresh();
        }
        void refresh()
        {
            listBox1.Items.Clear();
            foreach (ClassCriminal a in Base.Main.CF)
            {
                if (!a.incell)
                {
                    listBox1.Items.Add(a.FName + " " + a.LName);
                    CR.Add(a);
                }
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 10;
            numericUpDown1.Minimum = 1;
            
        }
        ClassCriminal c;
        int i;
        int index=0;
        List<ClassCell> Cell = new List<ClassCell>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                index = listBox1.SelectedIndex;
                i = Convert.ToInt32(numericUpDown1.Value);
                c = Base.Main.CF[listBox1.SelectedIndex];
            
                foreach (ClassCell a in Base.Main.CL)
                {
                    if (i == a.Lev && !a.isfull)
                    {
                        Cell.Add(a);
                        listBox2.Items.Add(a.IDNum);
                        
                    }
                }
            }
            else
                MessageBox.Show("Please Select from the first Textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex==-1||listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select from the first and the Second Textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Cell[index1].AddPerson(CR[listBox1.SelectedIndex]);
                CR[index].incell = true;
                CR[index].crimelvl = i;
                refresh();
                listBox2.Items.Clear();

            }
        }

        private void FormPersonToCell_Load(object sender, EventArgs e)
        {

        }
     
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex!=-1)
            {
               index1= listBox2.SelectedIndex;
            }
        }
    }
}
