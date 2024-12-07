using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            string operation = comboBox1.SelectedItem.ToString();

            if (double.TryParse(textBox1.Text, out num1) && double.TryParse(textBox2.Text, out num2))
            {
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        resultLabel.Text = result.ToString();
                        operationLabel.Text= "Addition was Performed.";
                        break;
                    case "-":
                        result = num1 - num2;
                        resultLabel.Text = result.ToString();
                        operationLabel.Text = "Subtraction was Performed.";
                        break;
                    case "*":
                        result = num1 * num2;
                        resultLabel.Text = result.ToString();
                        operationLabel.Text = "Multiplication was Performed.";
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            resultLabel.Text = result.ToString();
                            operationLabel.Text = "Division was Performed.";
                        }
                        else
                        {
                            resultLabel.Text = "Cannot divide by zero.";
                        }
                        break;
                    default:
                        resultLabel.Text = "Invalid operation.";
                        break;
                }
            }
            else
            {
                resultLabel.Text = "Please enter valid numbers.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
