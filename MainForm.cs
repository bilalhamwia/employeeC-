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
     partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public LoginForm loginForm;
        public MainForm(LoginForm x)
        {
            InitializeComponent();
            loginForm = x;
            TUser.Text = x.loggedUser.firstName + " " + x.loggedUser.lastName;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm FE = loginForm;
            FE.Show();
            this.Close();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            loginForm.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (loginForm.loggedUser.IsManager)
            {
                AddSkillForm FE = new AddSkillForm(this);
                FE.Show();
            }
            else
                MessageBox.Show("You Can't Add Skills YOu Are not a Manager");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (loginForm.loggedUser.IsManager)
            {
                AddSkillsToEmployeeForm FE = new AddSkillsToEmployeeForm(this);
                FE.Show();
            }
            else
                MessageBox.Show("You Can't Add Skills YOu Are not a Manager");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (loginForm.loggedUser.IsManager)
            {
                EvaluationForm FE = new EvaluationForm(this);
                FE.Show();
            }
            else
                MessageBox.Show("You Can't Add Skills YOu Are not a Manager");

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddEmployeeForm FE = new AddEmployeeForm(this);
            FE.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            AddPositionForm FE = new AddPositionForm(this);
            FE.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddTeamForm FE = new AddTeamForm(this);
            FE.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (loginForm.loggedUser.IsManager)
            {
                AddSkillForm FE = new AddSkillForm(this);
                FE.Show();
            }
            else
                MessageBox.Show("You Can't Add Skills YOu Are not a Manager");
        }
    }
}
