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
    public partial class BasicCalculator : Form
    {
        string textToOutput = "";
        int temporalcounter = 0; //Result of the parse of keyboard's data insertion to integer
        public int counter1 = 0; //Initial counter
        public int counter2 = 0; //Second counter
        bool boolvariable;
        public string operator2019 = "Empty";
        public BasicCalculator()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "1";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput,out temporalcounter);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "2";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        
        private void Button3_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "3";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "4";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "5";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "6";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "7";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "8";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "9";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textToOutput = textToOutput + "0";
            txtMain.Text = textToOutput;
            boolvariable = int.TryParse(textToOutput, out temporalcounter);
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            //All the variables names are gonna be reseted to their initial values.
            textToOutput = "";
            temporalcounter = 0;
            counter1 = 0;
            counter2 = 0;
            txtMain.Text = textToOutput;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "+";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "+";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
            
            
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "-";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
           
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "-";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "*";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "*";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                counter1 = temporalcounter;
                temporalcounter = 0;
                operator2019 = "/";

                textToOutput = "";
                txtMain.Text = textToOutput;
            }
            else
            {
                counter2 = temporalcounter;
                temporalcounter = 0;
                if (operator2019 == "+") { counter1 = counter1 + counter2; }
                else if (operator2019 == "-") { counter1 = counter1 - counter2; }
                else if (operator2019 == "*") { counter1 = counter1 * counter2; }
                else if (operator2019 == "/") { counter1 = counter1 / counter2; }
                else MessageBox.Show("Error by all means", "ERROR WINDOW");
                counter2 = 0;
                operator2019 = "/";

                textToOutput = counter1.ToString();
                txtMain.Text = textToOutput;
                textToOutput = "";
            }
        }


        private void Button12_Click(object sender, EventArgs e)
        {
            if (operator2019 == "Empty")
            {
                MessageBox.Show("At least 2 operands and 1 operator have to be selected", "NO DATA");
                return;
            }
            counter2 = temporalcounter;
            if (operator2019 == "+") { counter1 = counter1 + counter2; }
            else if (operator2019 == "-") { counter1 = counter1 - counter2; }
            else if (operator2019 == "*") { counter1 = counter1 * counter2; }
            else if (operator2019 == "/") { counter1 = counter1 / counter2; }
            else MessageBox.Show("Error by all means", "ERROR WINDOW");
            counter2 = 0;
            operator2019 = "Empty";
            temporalcounter = counter1;

            textToOutput = counter1.ToString();
            txtMain.Text = textToOutput;
            textToOutput = "";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //we open the weigth convertor window, keeping the Calculator window opened
            weigth_convertor_Form WCF_weigth = new weigth_convertor_Form();
            WCF_weigth.Show();
        }

        private void BtnCloseAll_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //we close all windows, not just the Calculator's.
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //we open the distance convertor window, keeping the Calculator window opened
            distance_convertor_Form DCF_distance = new distance_convertor_Form();
            DCF_distance.Show();
        }
    }
}
