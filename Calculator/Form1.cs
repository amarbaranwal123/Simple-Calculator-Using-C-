using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string userInput = "";
        double resultValue;
        string  functions;
        string first = "";
        string second = "";
        double firstnum;
        double secondnum;


        public Form1()
        {
            InitializeComponent();
        }

        
       

    

         void buttonEqual_Click(object sender, EventArgs e)
        {
            
            double resultValue=0;
            second = userInput;
            firstnum = Convert.ToDouble(first);
            secondnum = Convert.ToDouble(second);

            if (functions == "+")
            { 
                resultValue = firstnum + secondnum;
                calculatorDisplay.Text = resultValue.ToString();
            }
            else if(functions == "-")
            {
                resultValue = firstnum - secondnum;
                calculatorDisplay.Text = resultValue.ToString();
            }
            else if (functions == "*")
            {
                resultValue = firstnum * secondnum;
                calculatorDisplay.Text = resultValue.ToString();
            }
            else if (functions == "/")
            {
                if (secondnum == 0)
                {
                    calculatorDisplay.Text = "No ZEROOO";
                }
                else
                {
                    resultValue = firstnum / secondnum;
                    calculatorDisplay.Text = resultValue.ToString();
                }
            }

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }


        private void buttonThree_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }


        private void buttonFour_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            userInput += ".";
            calculatorDisplay.Text = userInput;
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            functions = "";
            first = "";
            second = "";
            userInput = "";
            resultValue = 0.0;
            calculatorDisplay.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            userInput = "";
            calculatorDisplay.Text = "0";
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            functions = "+";
            first = userInput;
            userInput = "";
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            functions = "-";
            first = userInput;
            userInput = "";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            functions = "*";
            first = userInput;
            userInput = "";
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {
            functions = "/";
            first = userInput;
            userInput = "";
        }
    }
}
