using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA2_CALCULATOR_srfn
{
    public partial class distance_convertor_Form : Form
    {
        double numDouble3 = 0.0;
        double numDouble4 = 0.0;
        public distance_convertor_Form()
        {
            InitializeComponent();
        }

        private void BtnClose2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {
            TBmilesTOkms.Text = "";
            numDouble3 = 0.00;
            numDouble4 = 0.00;
            TBmilesTOkms.Focus();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (TBmilesTOkms.Text == "0")
            {
                MessageBox.Show("Please enter a numeric value different to 0", "No valid data entered");
                TBmilesTOkms.Focus();

            }
            else
            {
                if (double.TryParse(TBmilesTOkms.Text, out numDouble3))
                {
                    numDouble4 = numDouble3 / 1.609;
                    TBmilesTOkms.Text = numDouble4.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a numeric value to convert", "No valid data entered");
                    TBmilesTOkms.Focus();

                }
            }
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            if (TBmilesTOkms.Text == "0")
            {
                MessageBox.Show("Please enter a numeric value different to 0", "No valid data entered");
                TBmilesTOkms.Focus();
            }
            else
            {
                if (double.TryParse(TBmilesTOkms.Text, out numDouble3))
                {
                    numDouble4 = numDouble3 * 1.609;
                    TBmilesTOkms.Text = numDouble4.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a numeric value to convert", "No valid data entered");
                    TBmilesTOkms.Focus();
                }
            }
        }
    }
}
