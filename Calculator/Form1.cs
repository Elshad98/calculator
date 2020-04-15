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

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "0";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            if (input.Text == "") {
                input.Text = "0";
            }
        }

        private void two_Click(object sender, EventArgs e)
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

        private void share_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            act = B.Text;
            number = input.Text;
            isSecondNumber = true;
        }

        private void equally_Click(object sender, EventArgs e)
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

        private void squareRoot_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = Math.Sqrt(number);
            ChangeAct();
            input.Text = result.ToString();
        }

        private void square_Click(object sender, EventArgs e)
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
            ChangeAct();
            input.Text = result.ToString();
        }

        private void ChangeAct()
        {
            act = "=";
            isSecondNumber = true;
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = -number;
            ChangeAct();
            input.Text = result.ToString();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!input.Text.Contains(","))
            {
                input.Text += ",";
            }
        }

        private void cleanEntry_Click(object sender, EventArgs e)
        {
            input.Text = "0";
        }
    }
}
