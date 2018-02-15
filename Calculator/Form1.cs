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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberOne_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberOne.Text != null)
            {
                answerBox.Text = "1";
            }
            else
            {
                answerBox.Text = answerBox.Text + "1";
            }
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberTwo.Text != null)
            {
                answerBox.Text = "2";
            }
            else
            {
                answerBox.Text = answerBox.Text + "2";
            }
        }

        private void numberThree_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberThree.Text != null)
            {
                answerBox.Text = "3";
            }
            else
            {
                answerBox.Text = answerBox.Text + "3";
            }
        }

        private void numberFour_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberFour.Text != null)
            {
                answerBox.Text = "4";
            }
            else
            {
                answerBox.Text = answerBox.Text + "4";
            }
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberFive.Text != null)
            {
                answerBox.Text = "5";
            }
            else
            {
                answerBox.Text = answerBox.Text + "5";
            }
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberSix.Text != null)
            {
                answerBox.Text = "6";
            }
            else
            {
                answerBox.Text = answerBox.Text + "6";
            }
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberSeven.Text != null)
            {
                answerBox.Text = "7";
            }
            else
            {
                answerBox.Text = answerBox.Text + "7";
            }
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberEight.Text != null)
            {
                answerBox.Text = "8";
            }
            else
            {
                answerBox.Text = answerBox.Text + "8";
            }
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            if (answerBox.Text == "0" && numberNine.Text != null)
            {
                answerBox.Text = "9";
            }
            else
            {
                answerBox.Text = answerBox.Text + "9";
            }
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + "0";
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerBox.Text = "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + ".";
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
                    answerBox.Text = "Zero division is not a valid operation.";
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
        }
    }
}
