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
     partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }
       public MainForm Base;

        int PosIndex;
        public AddEmployeeForm(MainForm p)
        {
            InitializeComponent();
            Base = p;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Add New Position");
             PosIndex = -1;
            listBox1.Items.Clear();
            foreach (Employee a in Base.loginForm.employee)
            {
                listBox1.Items.Add(a.firstName + " " + a.lastName);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                if (listBox1.SelectedIndex > -1)
                {
                    if (TxtEFN.Text != "" && TxtELN.Text != "" && TxtESal.Text != "" && TxtEAge.Text != "")
                    {
                        PosIndex = comboBox1.SelectedIndex - 1;
                        if (Convert.ToDouble(TxtESal.Text) <= Base.loginForm.position[PosIndex].maximumSalary && Convert.ToDouble(TxtESal.Text) >= Base.loginForm.position[PosIndex].minimumSalary)
                        {
                            Base.loginForm.employee.Add(new Employee(TxtEFN.Text, TxtELN.Text, Convert.ToDouble(TxtESal.Text), Convert.ToInt32(TxtEAge.Text), Base.loginForm.position[PosIndex], Base.loginForm.employee[listBox1.SelectedIndex]));
                            Base.loginForm.employee[listBox1.SelectedIndex].IsManager = true;
                            MessageBox.Show("Employee Added");
                            listBox1.Items.Clear();
                            foreach (Employee a in Base.loginForm.employee)
                            {
                                listBox1.Items.Add(a.firstName + " " + a.lastName);
                            }
                        }
                        else
                            MessageBox.Show("Incorrect Salary");
                    }
                    else
                    {
                        MessageBox.Show("Erorr");
                    }
                }
                else
                {
                    if (TxtEFN.Text != "" && TxtELN.Text != "" && TxtESal.Text != "" && TxtEAge.Text != "")
                    {
                        PosIndex = comboBox1.SelectedIndex - 1;
                        if (Convert.ToDouble(TxtESal.Text) <= Base.loginForm.position[PosIndex].maximumSalary && Convert.ToDouble(TxtESal.Text) >= Base.loginForm.position[PosIndex].minimumSalary)
                        {
                            Base.loginForm.employee.Add(new Employee(TxtEFN.Text, TxtELN.Text, Convert.ToDouble(TxtESal.Text), Convert.ToInt32(TxtEAge.Text), Base.loginForm.position[PosIndex]));

                            MessageBox.Show("Employee Added");
                            listBox1.Items.Clear();
                            foreach (Employee a in Base.loginForm.employee)
                            {
                                listBox1.Items.Add(a.firstName + " " + a.lastName);
                            }
                        }
                        else
                            MessageBox.Show("Incorrect Salary");
                    }
                    else
                    {
                        MessageBox.Show("Erorr");
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                AddPositionForm formAddPosition = new AddPositionForm(this);
                formAddPosition.Show();
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Add New Position");
           
            foreach (Position a in Base.loginForm.position)
                         comboBox1.Items.Add(a.name);
           if (comboBox1.SelectedIndex == 0)
            {
                AddPositionForm formAddPosition = new AddPositionForm(this);
                formAddPosition.Show();
            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
                PosIndex = comboBox1.SelectedIndex - 1;
        }
    }
}
