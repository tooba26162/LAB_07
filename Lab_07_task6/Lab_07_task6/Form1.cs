using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_task6
{
    public partial class Form1 : Form
    {
        private int countdownTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                countdownTime = int.Parse(txtTime.Text); timer1.Interval = 1000; // 1 second intervals
                timer1.Start();
            } 
            catch (FormatException) 
            {
                MessageBox.Show("Please enter a valid number."); }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdownTime > 0) { 
                countdownTime--; 
                lblTimeLeft.Text = "Time Left: " + countdownTime + " seconds";
            } 
            else 
            { timer1.Stop(); MessageBox.Show("Time Over!"); }
        }
    }
}
