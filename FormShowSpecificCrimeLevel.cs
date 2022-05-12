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
     partial class FormShowSpecificCrimeLevel : Form
    {
        public FormShowSpecificCrimeLevel()
        {
            InitializeComponent();
        }
        FormMain Base;
        public FormShowSpecificCrimeLevel(FormMain p)
        {
            Base = p;
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 10;
            numericUpDown1.Minimum = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = Convert.ToInt32(numericUpDown1.Value);
            foreach (ClassCriminal a in Base.Main.CF)
                if (a.crimelvl == i)
                    listBox1.Items.Add(a.FName + " " + a.LName);
        }
    }
}
