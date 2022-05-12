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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void emplyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmplyee FE = new FormEmplyee();
            FE.Show();
        }

        private void officersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOfficers FO = new FormOfficers();
            FO.Show();
        }

        private void criminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCriminal FC = new FormCriminal();
            FC.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPatrol FP = new FormPatrol();
            FP.Show();
        }

        private void caseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCase FC = new FormCase();
            FC.Show();
        }
    }
}
