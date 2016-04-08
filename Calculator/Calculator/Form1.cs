using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArgument;

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

            ICalculator calculator = Factory.Create(((Button) sender).Name);
            double result = calculator.Calculate(firstNumber, secondNumber);
            label1.Text = result.ToString();
        }

        private void SingleCalculate(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            ISingleCalculator calculator = SingleFactory.Create(((Button) sender).Name);
            double result = calculator.Calculate(firstNumber);
            label1.Text = result.ToString();
        }

    }

}
