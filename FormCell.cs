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
     partial class FormCell : Form
    {
        public FormCell()
        {
            InitializeComponent();
        }
        FormMain Base;
        public FormCell(FormMain p)
        {
            InitializeComponent();
            Base = p;
        }
        List<ClassCell> CCell = new List<ClassCell>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtCIN.Text == "" || TxtCCode.Text == "" || TxtCCapacity.Text == "" || TxtCCrimeLev.Text == "")
            {
                MessageBox.Show("Please fill all the Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Convert.ToInt32(TxtCCrimeLev.Text) < 0 && Convert.ToInt32(TxtCCrimeLev.Text) > 10)
                MessageBox.Show("The Crime LEvel Should be between 1 to 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                Base.Main.CL.Add(new ClassCell(Convert.ToInt32(TxtCIN.Text), TxtCCode.Text, Convert.ToDouble(TxtCCapacity.Text), Convert.ToInt32(TxtCCrimeLev.Text)));
                MessageBox.Show("You Have Added a new Cell successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
     }
}
