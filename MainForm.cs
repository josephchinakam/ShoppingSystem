using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShoppingCartSystem
{
    public partial class MainForm : Form
    {
        // List to store items
        private List<Item> shoppingCart = new List<Item>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Add item to the shopping cart
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                decimal itemPrice;

                // Validate the item price input
                if (!decimal.TryParse(txtItemPrice.Text, out itemPrice) || itemPrice <= 0)
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                // Create new item and add to the shopping cart
                Item item = new Item(itemName, itemPrice);
                shoppingCart.Add(item);

                // Display the added item in the ListBox
                lstShoppingCart.Items.Add($"{item.Name} - {item.Price:C}");

                // Clear input fields for the next item
                txtItemName.Clear();
                txtItemPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Calculate and display the subtotal, discount, and final total
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate subtotal
                decimal subtotal = 0;
                foreach (Item item in shoppingCart)
                {
                    subtotal += item.Price;
                }

                // Get membership type
                string membershipType = cboMembershipType.SelectedItem?.ToString();

                // Calculate discount
                decimal discount = CalculateDiscount(subtotal, membershipType);

                // Calculate final total
                decimal finalTotal = subtotal - discount;

                // Display results
                lblSubtotal.Text = $"Subtotal: {subtotal:C}";
                lblDiscount.Text = $"Discount: {discount:C}";
                lblTotal.Text = $"Total: {finalTotal:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Calculate discount based on membership and subtotal
        private decimal CalculateDiscount(decimal subtotal, string membershipType)
        {
            decimal discount = 0;

            if (string.IsNullOrEmpty(membershipType)) return discount;

            // Membership-based discount
            switch (membershipType)
            {
                case "Silver":
                    if (subtotal > 100)
                        discount += subtotal * 0.05m; // 5% if total > $100
                    break;
                case "Gold":
                    if (subtotal > 200)
                        discount += subtotal * 0.10m; // 10% if total > $200
                    break;
                case "Platinum":
                    if (subtotal > 300)
                        discount += subtotal * 0.15m; // 15% if total > $300
                    break;
            }

            // Additional 10% discount if total > $500
            if (subtotal > 500)
            {
                discount += subtotal * 0.10m; // 10% additional discount
            }

            return discount;
        }
    }
}
