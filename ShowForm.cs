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
     partial class ShowForm : Form
    {
        Evaluation evaluation;
        public ShowForm()
        {
            InitializeComponent();
        }
        EvaluationForm mini;
        public ShowForm(EvaluationForm p)
        {
            InitializeComponent();
            mini = p;
            listBox1.Items.Clear();
            foreach (Employee a in mini.Base.loginForm.employee)
            {
                listBox1.Items.Add(a.firstName + " " + a.lastName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex > -1)
            {

                avg = 0;
                listBox2.Items.Clear();
                foreach (Evaluation a in mini.Base.loginForm.employee[listBox1.SelectedIndex].evaluations)
                {
                    avg = avg + a.evaluation;
                    listBox2.Items.Add(a.skill.name);
                }
                avg = avg / mini.Base.loginForm.employee[listBox1.SelectedIndex].evaluations.Count();
            }
        }
        double avg;

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex > -1 && listBox1.SelectedIndex > -1)
            {
                evaluation = mini.Base.loginForm.employee[listBox1.SelectedIndex].evaluations[listBox2.SelectedIndex];
                textBox1.Text = Convert.ToString(avg);
                textBox2.Text = evaluation.skill.name;
                textBox3.Text = Convert.ToString(evaluation.evaluation);
                textBox4.Text = evaluation.evaluator.firstName + " " + evaluation.evaluator.lastName;
                richTextBox1.Text = evaluation.review;

            }
        }
    }
    
}
