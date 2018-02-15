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
        double FirstNumber;
        string Operation;
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0")
            {
                answerBox.Clear();
            }
            Button b = (Button)sender;
            answerBox.Text += b.Text;
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text.TrimStart('0') + "0";
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(answerBox.Text);
            answerBox.Text = "0";
            Operation = "*";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(answerBox.Text);
            answerBox.Text = "0";
            Operation = "/";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(answerBox.Text);
            answerBox.Text = "0";
            Operation = "+";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(answerBox.Text);
            answerBox.Text = "0";
            Operation = "-";
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(answerBox.Text);
            answerBox.Text = "0";
            Operation = "^";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerBox.Clear();
            answerBox.Text = "0";
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            answerBox.Text = "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!answerBox.Text.Contains(".")) {
                answerBox.Text += ".";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Answer;

            SecondNumber = Convert.ToDouble(answerBox.Text);

            if (Operation == "*")
            {
                Answer = FirstNumber * SecondNumber;
                answerBox.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    MessageBox.Show("Zero division is not a valid operation.");
                    answerBox.Text = FirstNumber.ToString();
                }
                else
                {
                    Answer = FirstNumber / SecondNumber;
                    answerBox.Text = Convert.ToString(Answer);
                    FirstNumber = Answer;
                }
            }

            if (Operation == "+")
            {
                Answer = FirstNumber + SecondNumber;
                answerBox.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }

            if (Operation == "-")
            {
                Answer = FirstNumber - SecondNumber;
                answerBox.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }

            if (Operation == "^")
            {
                Answer = Math.Pow(FirstNumber, SecondNumber);
                answerBox.Text = Convert.ToString(Answer);
                FirstNumber = Answer;
            }
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
    }
}
