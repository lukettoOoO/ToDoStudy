using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoStudy
{
    public partial class Calculator : UserControl
    {
        public Calculator()
        {
            InitializeComponent();
        }
        int num1;
        int num2;
        string option;
        int result;
        private void button1_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button0.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textTotal.Text);
            if (option == "+")
                result = num1 + num2;
            if (option == "-")
                result = num1 - num2;
            if(option == "*")
                result = num1 * num2;
            if (option == "/")
                result = num1 / num2;
            textTotal.Text = result.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}
