using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TshirtForm
{
    public partial class TShirtOrderForm : Form
    {
        public TShirtOrderForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Check if user entered a valid number of T-shirts
            if (!int.TryParse(txtNumberOfTShirts.Text, out int numTShirts) || numTShirts <= 0)
            {
                MessageBox.Show("Please enter a valid number of T-shirts.");
                return;
            }

            // Get the selected size price
            decimal pricePerTShirt = 0;
            if (cmbSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a T-shirt size.");
                return;
            }

            switch (cmbSize.SelectedItem.ToString())
            {
                case "Small":
                    pricePerTShirt = 125m;
                    break;
                case "Medium":
                    pricePerTShirt = 175m;
                    break;
                case "Large":
                    pricePerTShirt = 250m;
                    break;
                default:
                    MessageBox.Show("Invalid size selected.");
                    return;
            }

            // Apply the promo code discount (10% off if "TRUEBLUE")
            decimal discount = 0;
           

            // Calculate the order price before GST
            decimal orderPrice = numTShirts * pricePerTShirt;
            decimal discountedPrice = orderPrice - (orderPrice * discount);

            // Apply 9% GST
            decimal gst = 0.09m;
            decimal finalPrice = discountedPrice + (discountedPrice * gst);

            // Display the final price
            lblFinalPrice.Text = "Final Price: Rs. " + finalPrice.ToString("0.00");
        }

    }
}
