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
     partial class AddPositionForm : Form
    {
        MainForm Base;
        AddEmployeeForm addEmployeeForm;
        public AddPositionForm()
        {
            InitializeComponent();
        }
        public AddPositionForm(MainForm p)
        {
            InitializeComponent();
            Base = p;
        }
        public AddPositionForm(AddEmployeeForm p)
        {
            InitializeComponent();
            addEmployeeForm = p;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Base!=null)
            Base.loginForm.position.Add(new Position(TxtPN.Text, TxtPLG.Text, Convert.ToDouble(TxtPMinSal.Text), Convert.ToDouble(TxtPMaxSal.Text)));
            else 
                addEmployeeForm.Base.loginForm.position.Add(new Position(TxtPN.Text, TxtPLG.Text, Convert.ToDouble(TxtPMinSal.Text), Convert.ToDouble(TxtPMaxSal.Text)));
            MessageBox.Show("Position Added");
        }
    }
}
