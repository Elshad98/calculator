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
        private string act;
        private string number;
        private bool isSecondNumber = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            input.Text = "0";
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (isSecondNumber)
            {
                isSecondNumber = false;
                input.Text = "0";
            }
            Button B = (Button)sender;
            if (input.Text == "0")
            {
                input.Text = B.Text;
            }
            else
            {
                input.Text += B.Text;
            }
        }

        private void bShare_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            act = B.Text;
            number = input.Text;
            isSecondNumber = true;
        }

        private void bEqually_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber, result = 0;
            firstNumber = Convert.ToDouble(number);
            secondNumber = Convert.ToDouble(input.Text);

            if (act == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (act == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (act == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (act == "/")
            {
                result = firstNumber / secondNumber;
            }
            else if (act == "%")
            {
                result = firstNumber * secondNumber / 100;
            }

            ChangeAct();
            input.Text = result.ToString();
        }

        private void bSquareRoot_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = Math.Sqrt(number);
            ChangeAct();
            input.Text = result.ToString();
        }

        private void bSquare_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = Math.Pow(number, 2);
            ChangeAct();
            input.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = 1 / number;
            result = 1 / number;
            ChangeAct();
            input.Text = result.ToString();
        }

        private void ChangeAct()
        {
            act = "=";
            isSecondNumber = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = -number;
            ChangeAct();
            input.Text = result.ToString();
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            if (!input.Text.Contains(","))
            {
                input.Text += ",";
            }
        }
    }
}
