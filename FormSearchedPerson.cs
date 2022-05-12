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
     partial class FormSearchedPerson : Form
    {
        public FormSearchedPerson()
        {
            InitializeComponent();
        }
        FormMain Base;
        public FormSearchedPerson(FormMain p)
        {
            Base = p;
            InitializeComponent();
            listBox1.Items.Clear();
            foreach(ClassCriminal a in Base.Main.CF)
            {
                listBox1.Items.Add(a.FName+" " + a.LName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Please select person", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                listBox2.Items.Clear();
                foreach (ClassCase b in Base.Main.CC)
                    foreach (ClassCriminal c in b.criminal)
                        if (Base.Main.CF[listBox1.SelectedIndex] == c)
                            listBox2.Items.Add(b.Name);
            }
        }
    }
}
