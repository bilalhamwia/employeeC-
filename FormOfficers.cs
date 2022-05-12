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
     partial class FormOfficers : Form
    {
        FormMain Base;
        public FormOfficers()
        {
            InitializeComponent();
        }

        public FormOfficers(FormMain p)
        {
            Base = p;
            InitializeComponent();
        }
        

        private void FormOfficers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtOFN.Text == "" || TxtOP.Text == "" || TxtOLN.Text == "" || TxtOA.Text == "" || TxtOE.Text == "")
            {
                MessageBox.Show("There is an Empty TextBox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Base.Main.OF.Add(new ClassOfficer(TxtOFN.Text, TxtOLN.Text, TxtOA.Text,theDate, TxtOE.Text, Convert.ToDouble(TxtOP.Text)));
                MessageBox.Show("Success\nYou Have Just Added A new Officer", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //var form2 = new Form2();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
        }
    }
}
