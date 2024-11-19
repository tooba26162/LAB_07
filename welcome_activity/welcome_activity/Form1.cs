using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace welcome_activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreetMe_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                // Display a personalized greeting message
                lblGreeting.Text = $"Hello, {txtName.Text}! Welcome!";
            }
            else
            {
                // Prompt the user to enter a name if the TextBox is empty
                lblGreeting.Text = "Please enter your name.";
            }
        }
       

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
