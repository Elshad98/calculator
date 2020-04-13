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
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            input.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            input.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            input.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            input.Text += "+";
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            input.Text += "-";
        }

        private void bMultiply_Click(object sender, EventArgs e)
        {
            input.Text += "*";
        }

        private void bShare_Click(object sender, EventArgs e)
        {
            input.Text += "/";
        }

        private void bEqually_Click(object sender, EventArgs e)
        {
            input.Text += "/";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (input.Text.Length > 0)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1, 1);
            }
        }
    }
}
