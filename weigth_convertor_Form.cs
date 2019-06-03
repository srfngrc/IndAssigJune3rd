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
    public partial class weigth_convertor_Form : Form
    {
        Double numDouble = 0.00;
        Double numDouble2 = 0.00;
        public weigth_convertor_Form()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (TBlbsTOkgs.Text == "0")
            {
                MessageBox.Show("Please enter a numeric value different to 0", "No valid data entered");
                TBlbsTOkgs.Focus();
            }
            else
            {
                if (double.TryParse(TBlbsTOkgs.Text, out numDouble))
                {
                    numDouble2 = numDouble * 0.453592;
                    TBlbsTOkgs.Text = numDouble2.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a numeric value to convert", "No valid data entered");
                    TBlbsTOkgs.Focus();
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (TBlbsTOkgs.Text == "0")
            {
                MessageBox.Show("Please enter a numeric value different to 0", "No valid data entered");
                TBlbsTOkgs.Focus();

            }
            else
            {
                if (double.TryParse(TBlbsTOkgs.Text, out numDouble))
                {
                    numDouble2 = numDouble * 2.20462;
                    TBlbsTOkgs.Text = numDouble2.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a numeric value to convert", "No valid data entered");
                    TBlbsTOkgs.Focus();

                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBlbsTOkgs.Text = "";
            numDouble = 0.00;
            numDouble2 = 0.00;
            TBlbsTOkgs.Focus();
        }
    }
}
