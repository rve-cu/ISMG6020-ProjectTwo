using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptuneCalculator
{
    public partial class frmNeptune : Form
    {
        public frmNeptune()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYTDCalc f2 = new frmYTDCalc();
            f2.ShowDialog();
        }

        private void btnMortgage_Click(object sender, EventArgs e)
        {

        }
    }
}
