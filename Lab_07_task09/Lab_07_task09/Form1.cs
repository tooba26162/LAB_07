using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_task09
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            int charactersLeft = MaxCharacters - txtInput.Text.Length;
            lblCharCount.Text = $"Characters Left: {charactersLeft}";

        }
    }
}
