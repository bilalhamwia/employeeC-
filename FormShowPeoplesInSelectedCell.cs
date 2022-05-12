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
     partial class FormShowPeoplesInSelectedCell : Form
    {
        public FormShowPeoplesInSelectedCell()
        {
            InitializeComponent();
        }
        FormMain Base;
        public FormShowPeoplesInSelectedCell(FormMain p)
        {
            InitializeComponent();
            Base = p;
            listBox1.Items.Clear();
            foreach (ClassCell a in Base.Main.CL)
                listBox1.Items.Add(a.IDNum);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Please Select a Cell", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                listBox2.Items.Clear();
                foreach (ClassCriminal a in Base.Main.CL[listBox1.SelectedIndex].CR)

                    listBox2.Items.Add(a.FName + " " + a.LName);

            }
        }
    }
}
