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
     partial class EvaForm : Form
    {
        public EvaForm()
        {
            InitializeComponent();
        }
        EvaluationForm mini;
        public EvaForm(EvaluationForm p)
        {
            InitializeComponent();
            mini = p;
            listBox1.Items.Clear();
            foreach (Skills a in mini.Employee.skills)
                listBox1.Items.Add(a.name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>-1 && textBox1.Text!="" && richTextBox1.Text!="")
            {
               
            }
                
        }
    }
}
