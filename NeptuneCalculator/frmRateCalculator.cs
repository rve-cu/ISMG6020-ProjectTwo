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
    public partial class frmRateCalculator : Form
    {
        public frmRateCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateRate_Click(object sender, EventArgs e)
        {
            // Convert input
            int creditScore = Convert.ToInt32(txtCreditScore.Text);

            // Determine interest rate based on credit score
            double interestRate = 0; // Initialize interest rate var
            if (creditScore >= 750) // excellent
            {
                interestRate = 4.374;
            }
            else if (creditScore >=700 && creditScore < 750) // good
            {
                interestRate = 4.596;
            }
            else if (creditScore >= 650 && creditScore < 700) // fair
            {
                interestRate = 4.773;
            }
            else if (creditScore >= 600 && creditScore < 650) // poor
            {
                interestRate = 4.987;
            }
            else if (creditScore >= 550 && creditScore < 600) // bad
            {
                interestRate = 5.417;
            }
            else // terrible
            {
                interestRate = 5.963;
            }

            // Format and display calculated value
            txtInterestRate.Text = interestRate.ToString("f3");
        }

        private void btnExitRate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
