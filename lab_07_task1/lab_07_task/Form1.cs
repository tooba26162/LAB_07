using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function to perform addition
        private double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Function to perform subtraction
        private double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Function to perform multiplication
        private double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Function to perform division
        private double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return num1 / num2;
        }
       

       

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);
            txtResult.Text = Add(num1, num2).ToString();

        }

        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);
            txtResult.Text = Subtract(num1, num2).ToString();
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);
            txtResult.Text = Multiply(num1, num2).ToString();

        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNumber1.Text);
            double num2 = double.Parse(txtNumber2.Text);
            txtResult.Text = Divide(num1, num2).ToString();
        }
    }
}
