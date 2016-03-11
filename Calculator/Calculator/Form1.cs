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

        private void Calculate(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result = firstNumber / secondNumber;
            switch (((Button)sender).Name)
            {
                case "button1":
                    result = firstNumber + secondNumber;
                    break;
                case "button2":
                    result = firstNumber - secondNumber;
                    break;
                case "button3":
                    result = firstNumber * secondNumber;
                    break;
                case "button4":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new Exception("Unknown peration");
            }
            label1.Text = result.ToString();

        }

    }

}
