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
        private bool isSecondNumber = false;
        private bool isAct = false;
        private double answer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void resetData()
        {
            output.Text = "";
            isSecondNumber = true;
            isAct = false;
            answer = 0;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            if (input.Text == "")
            {
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
            string number = input.Text;
            if (isAct)
            {
                getAnswer();
            }
            else
            {
                answer = Convert.ToDouble(number);
            }
            Button B = (Button)sender;
            act = B.Text;
            output.Text += number + " " + act + " ";
            isSecondNumber = true;
            isAct = true;
        }

        private void getAnswer()
        {
            double firstNumber, secondNumber, result = 0;
            firstNumber = Convert.ToDouble(answer);
            secondNumber = Convert.ToDouble(input.Text);

            if (act == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (act == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (act == "−")
            {
                result = firstNumber - secondNumber;
            }
            else if (act == "÷")
            {
                result = firstNumber / secondNumber;
            }
            else if (act == "%")
            {
                result = firstNumber * secondNumber / 100;
            }

            isSecondNumber = true;
            answer = result;
        }

        private void equally_Click(object sender, EventArgs e)
        {
            if (isAct)
            {
                getAnswer();
            }
            input.Text = answer.ToString();
            resetData();
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = Math.Sqrt(number);
            isSecondNumber = true;
            input.Text = result.ToString();
        }

        private void square_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = Math.Pow(number, 2);
            isSecondNumber = true;
            input.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = 1 / number;
            isSecondNumber = true;
            input.Text = result.ToString();
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            double result, number;
            number = Convert.ToDouble(input.Text);
            result = -number;
            isSecondNumber = true;
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.FromArgb(54, 56, 62);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            panel1.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "0";
            resetData();
        }
    }
}
