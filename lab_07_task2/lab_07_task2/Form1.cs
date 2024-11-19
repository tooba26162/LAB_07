using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07_task2
{
    public partial class Form1 : Form
    {
        private string input = string.Empty; // Stores user input
        private string operand1 = string.Empty; // Stores the first operand
        private string operand2 = string.Empty; // Stores the second operand
        private char operation; // Stores the operator
        private double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operand1 = input;
            operation = button.Text[0]; // Store the operator (+, -, *, /)
            input = string.Empty;
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            txtDisplay.Text = input;
            txtDisplay.Text = input;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
           
            operand2 = input;

            double num1, num2;
            if (double.TryParse(operand1, out num1) && double.TryParse(operand2, out num2))
            {
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Division by zero is not allowed.");
                            return;
                        }
                        break;
                }
                txtDisplay.Text = result.ToString();
                input = result.ToString();
            }
        }



       
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            txtDisplay.Text = string.Empty;


        }


        private void button9_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);

        }

       

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OperatorButton_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }
    }
}
