using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Curs
{
    public partial class Form1 : Form
    {
        private float firstNumber;
        private float secondNumber;
        private float result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + ".";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            float.TryParse(this.first_number_label.Text, out firstNumber);
            float.TryParse(this.textBox1.Text, out secondNumber);
            result = 0;
            switch (this.operator_label.Text)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    //float.TryParse(this.textBox1.Text, out result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    //float.TryParse(this.textBox1.Text, out result);
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    //float.TryParse(this.textBox1.Text, out result);
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    //float.TryParse(this.textBox1.Text, out result);
                    break;

            }
            if (firstNumber == 420 || firstNumber == 69)
            {
                if (secondNumber == 420 || secondNumber == 69)
                {
                    this.textBox1.Text = "Nice";
                }
            }
            else
            {
                this.textBox1.Text = result.ToString();
            }

            this.first_number_label.ResetText();
            this.operator_label.ResetText();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.first_number_label.Text = this.textBox1.Text;
            this.operator_label.Text = "+";
            this.textBox1.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.first_number_label.Text = this.textBox1.Text;
            this.operator_label.Text = "-";
            this.textBox1.ResetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.first_number_label.Text = this.textBox1.Text;
            this.operator_label.Text = "*";
            this.textBox1.ResetText();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            this.textBox1.ResetText();
            this.first_number_label.ResetText();
            this.operator_label.ResetText();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.first_number_label.Text = this.textBox1.Text;
            this.operator_label.Text = "/";
            this.textBox1.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void first_number_label_Click(object sender, EventArgs e)
        {

        }

    }
}
