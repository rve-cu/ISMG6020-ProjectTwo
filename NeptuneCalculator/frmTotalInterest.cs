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
    public partial class frmTotalInterest : Form
    {
        public frmTotalInterest()
        {
            InitializeComponent();
        }

        private void frmTotalInterest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIntCalc_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(txtPaymentAmt.Text);
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double months = Convert.ToDouble(txtLength.Text);

            double totalPayment = payment * months;
            double totalInterest = totalPayment - principal;

            txtTotalInterest.Text = totalInterest.ToString();


        }
    }
}
