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
     partial class FormViewCases : Form
    {
        public FormViewCases()
        {
            InitializeComponent();
        }
        FormMain Base;
        public FormViewCases(FormMain p)
        {
            Base = p;
            InitializeComponent();
            foreach (ClassCase a in Base.Main.CC)
                listBox1.Items.Add(a.Name);

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Clear();
                foreach (ClassCriminal a in Base.Main.CC[listBox1.SelectedIndex].criminal)
                    listBox2.Items.Add(a.FName+" "+a.LName);
            }
        }
    }
}
