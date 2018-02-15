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
    public partial class calculatorForm : Form
    {
        double value = 0;
        string operation;
        bool operation_pressed = false;

        public calculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((answerBox.Text == "0") || (operation_pressed))
            {
                answerBox.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!answerBox.Text.Contains("."))
                {
                    answerBox.Text += b.Text;
                }
            }
            else
            {
                answerBox.Text += b.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equalsButton.PerformClick();
                operation_pressed = true;
                operation = b.Text;
            }
            operation = b.Text;
            value = Convert.ToDouble(answerBox.Text);
            operation_pressed = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double answer;
            secondNumber = Convert.ToDouble(answerBox.Text);

            switch (operation)
            {
                case "*":
                    answer = value * secondNumber;
                    answerBox.Text = Convert.ToString(answer);
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        answerBox.Text = Convert.ToString(value);
                        break;
                    }
                    else
                    {
                        answer = value / secondNumber;
                        answerBox.Text = Convert.ToString(answer);
                        break;
                    }
                case "+":
                    answer = value + secondNumber;
                    answerBox.Text = Convert.ToString(answer);
                    break;
                case "-":
                    answer = value - secondNumber;
                    answerBox.Text = Convert.ToString(answer);
                    break;
                case "^":
                    answer = Math.Pow(value, secondNumber);
                    answerBox.Text = Convert.ToString(answer);
                    break;
                default:
                    break;
            }

            value = Convert.ToDouble(answerBox.Text);
            operation = "";
        }

        private void positiveNegative_Click(object sender, EventArgs e)
        {
            if (answerBox.Text.Contains("-"))
            {
                answerBox.Text = answerBox.Text.Remove(0, 1);
            }
            else
            {
                answerBox.Text = "-" + answerBox.Text;
            }
        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            if (answerBox.Text.Contains("-"))
            {
                MessageBox.Show("Negative numbers don't have real square roots.");
                answerBox.Text = "0";
            }
            else
            {
                answerBox.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(answerBox.Text)));
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerBox.Clear();
            value = 0;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            answerBox.Text = "0";
        }

        private void calculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    numberOne.PerformClick();
                    break;
                case "2":
                    numberTwo.PerformClick();
                    break;
                case "3":
                    numberThree.PerformClick();
                    break;
                case "4":
                    numberFour.PerformClick();
                    break;
                case "5":
                    numberFive.PerformClick();
                    break;
                case "6":
                    numberSix.PerformClick();
                    break;
                case "7":
                    numberSeven.PerformClick();
                    break;
                case "8":
                    numberEight.PerformClick();
                    break;
                case "9":
                    numberNine.PerformClick();
                    break;
                case "0":
                    numberZero.PerformClick();
                    break;
                case "*":
                    multiplicationButton.PerformClick();
                    break;
                case "/":
                    divisionButton.PerformClick();
                    break;
                case "-":
                    subtractionButton.PerformClick();
                    break;
                case "+":
                    additionButton.PerformClick();
                    break;
                case "=":
                    equalsButton.PerformClick();
                    break;
                default:
                    break;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                equalsButton.PerformClick();
            }
        }
    }
}
