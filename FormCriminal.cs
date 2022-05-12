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
     partial class FormCriminal : Form
    {
        FormMain Base;
        public FormCriminal()
        {
            InitializeComponent();
        }
        public FormCriminal(FormMain P)
        {
            Base = P;
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtCFN.Text == "" || TxtCLN.Text == "" || TXtCNN.Text == "" || TxtCA.Text == "")
            {
                MessageBox.Show("There is an Empty TextBox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Base.Main.CF.Add(new ClassCriminal(TxtCFN.Text, TxtCLN.Text,  TxtCA.Text,theDate, Convert.ToDouble(TXtCNN.Text)));
                MessageBox.Show("Success\nYou Have Just Added A new Criminal", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FormCriminal_Load(object sender, EventArgs e)
        {

        }
    }
}
