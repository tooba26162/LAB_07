using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_activity2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string pizzaSize = cmbPizzaSize.SelectedItem?.ToString() ?? "Not selected";

            // Get selected toppings
            List<string> toppings = new List<string>();
            if (chkCheese.Checked) toppings.Add("Cheese");
            if (chkPepperoni.Checked) toppings.Add("Pepperoni");
            if (chkMushrooms.Checked) toppings.Add("Mushrooms");

            // Get selected crust type
            string crustType = rdoThinCrust.Checked ? "Thin Crust" :
                               rdoThickCrust.Checked ? "Thick Crust" :
                               "Not selected";

            // Build the order summary
            string summary = $"You ordered a {pizzaSize} pizza with:\n" +
                             $"- Toppings: {(toppings.Count > 0 ? string.Join(", ", toppings) : "None")}\n" +
                             $"- Crust Type: {crustType}";

            // Display the summary in the label
            lblOrderSummary.Text = summary;
        }
    }
}
