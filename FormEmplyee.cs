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
     partial class FormEmplyee : Form
    {
        FormMain Base;
        public FormEmplyee()
        {
            InitializeComponent();
        }
        public FormEmplyee(FormMain P)
        {
            Base = P;
            InitializeComponent();
        }

         

        private void button2_Click(object sender, EventArgs e)
        {

            if (TxtEFN.Text == "" || TxtELN.Text == "" || TxtEUN.Text == "" || TxtEPN.Text == "" || TxtEPW.Text == "")
            {
                MessageBox.Show("Please Add All the Data Needed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                Base.Main.EMP.Add(new ClassEmployee(TxtEFN.Text, TxtELN.Text, Convert.ToDouble(TxtEPN.Text), TxtEUN.Text, TxtEPW.Text));

                MessageBox.Show("Thank You " + TxtEFN.Text + " " + TxtELN.Text + " \nNow you Can Login To The DataBase  :)", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // this.Hide();
                //var MainPage = new MainPage();
                //MainPage.Closed += (s, args) => this.Close();
                //MainPage.Show();
            }
        }
    }
}
