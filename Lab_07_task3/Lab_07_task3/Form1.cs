using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateSquares()
        {
            listBox1.Items.Clear(); // Clear the ListBox before adding new items

            for (int i = 1; i <= 10; i++)
            {
                int square = CalculateSquare(i);
                listBox1.Items.Add($" {i}\t\t{square}");
            }
        }
        private int CalculateSquare(int number)
        {
            return number * number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateSquares();
        }
    }
}
