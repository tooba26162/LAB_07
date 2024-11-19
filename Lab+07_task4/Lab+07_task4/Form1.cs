using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the Fahrenheit input
                double fahrenheit = double.Parse(textBox1.Text);

                // Convert to Celsius using the formula: (F - 32) * 5/9
                double celsius = (fahrenheit - 32) * 5 / 9;

                // Display the result in the Celsius textbox
                textBox2.Text = celsius.ToString("F2"); // Display with 2 decimal places
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for Fahrenheit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
