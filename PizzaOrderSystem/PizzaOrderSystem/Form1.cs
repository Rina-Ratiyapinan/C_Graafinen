using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzaOrderSystem
{
    public partial class Form1 : Form
    {
        private List<string> cartItems = new List<string>();
        private decimal totalAmount = 0;
        private List<string> orderSummaries = new List<string>(); // To store multiple orders
        private List<decimal> orderPrices = new List<decimal>(); // To store the price of each order

        public Form1()
        {
            InitializeComponent();
            SetupInitialState();  // Set default selection, UI states
            SetupEventHandlers(); // Link events to behaviors
        }

        private void SetupInitialState()
        {
            tabControl1.SelectedIndex = 0;
            textBoxTotalMain.Text = "0 €";
            textBoxDue.Text = "0 €";
            comboBoxMethod.Items.AddRange(new string[] { "Cash", "Card" });
            comboBoxMethod.SelectedIndex = 0;
            groupBoxCard.Visible = false;
            groupBoxCash.Visible = false;
            listBoxCart.HorizontalScrollbar = true;
        }

        // Set up event handlers for checkboxes and numeric up-down controls
        private void SetupEventHandlers()
        {
            // Drinks
            SetupMandatorySelection(checkBoxCoke, numericUpDownCoke);
            SetupMandatorySelection(checkBoxSprite, numericUpDownSprite);
            SetupMandatorySelection(checkBoxOJ, numericUpDownOJ);
            SetupMandatorySelection(checkBoxAJ, numericUpDownAPJ);

            // Other Items
            SetupMandatorySelection(checkBoxWings, numericUpDownChick);
            SetupMandatorySelection(checkBoxSalad, numericUpDownSalad);
            SetupMandatorySelection(checkBoxFries, numericUpDownFries);
            SetupMandatorySelection(checkBoxRings, numericUpDownOnion);
            SetupMandatorySelection(checkBoxGarlicBread, numericUpDownCheesy);
            SetupMandatorySelection(checkBoxCheesyDip, numericUpDownCheeseDip);
            SetupMandatorySelection(checkBoxGarlicDip, numericUpDownGarlicDip);
            SetupMandatorySelection(checkBoxSourDip, numericUpDownSourDip);

            // Desserts
            SetupMandatorySelection(checkBoxBrownie, numericUpDownBrown);
            SetupMandatorySelection(checkBoxCookie, numericUpDownCookies);
            SetupMandatorySelection(checkBoxCheeseCake, numericUpDownCheeseCake);
            SetupMandatorySelection(checkBoxIceCream, numericUpDownIceCream);

            // Add event handler for Amount Paid change to calculate change automatically
            textBoxPaid.TextChanged += (s, e) =>
            {
                if (comboBoxMethod.SelectedItem.ToString() == "Cash" && !string.IsNullOrEmpty(textBoxPaid.Text))
                {
                    if (decimal.TryParse(textBoxPaid.Text, out decimal paidAmount))
                    {
                        decimal change = paidAmount - totalAmount;
                        textBoxChange.Text = change >= 0 ? $"{change:F2} €" : "0.00 €";
                    }
                    else
                    {
                        textBoxChange.Text = "0.00 €";
                    }
                }
            };
        }

        private void SetupMandatorySelection(CheckBox checkBox, NumericUpDown numericUpDown)
        {
            checkBox.CheckedChanged += (s, e) =>
            {
                if (checkBox.Checked && numericUpDown.Value == 0)
                {
                    numericUpDown.Value = 1;
                }
                else if (!checkBox.Checked && numericUpDown.Value > 0)
                {
                    numericUpDown.Value = 0;
                }
            };

            numericUpDown.ValueChanged += (s, e) =>
            {
                if (numericUpDown.Value > 0 && !checkBox.Checked)
                {
                    checkBox.Checked = true;
                }
                else if (numericUpDown.Value == 0 && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            };
        }

        // Reset selections for all controls
        private void ResetSelections()
        {
            radioButtonSmall.Checked = false;
            radioButtonMedium.Checked = false;
            radioButtonLarge.Checked = false;
            radioButtonNormal.Checked = false;
            radioButtonThin.Checked = false;
            radioButtonThick.Checked = false;
            checkBoxPepperoni.Checked = false;
            checkBoxHam.Checked = false;
            checkBoxBacon.Checked = false;
            checkBoxOlives.Checked = false;
            checkBoxOnions.Checked = false;
            checkBoxCheese.Checked = false;
            checkBoxSausage.Checked = false;
            checkBoxMushroom.Checked = false;
            checkBoxPeppers.Checked = false;
            checkBoxWings.Checked = false;
            checkBoxSalad.Checked = false;
            checkBoxFries.Checked = false;
            checkBoxRings.Checked = false;
            checkBoxGarlicBread.Checked = false;
            checkBoxCheesyDip.Checked = false;
            checkBoxGarlicDip.Checked = false;
            checkBoxSourDip.Checked = false;
            numericUpDownChick.Value = 0;
            numericUpDownSalad.Value = 0;
            numericUpDownFries.Value = 0;
            numericUpDownOnion.Value = 0;
            numericUpDownCheesy.Value = 0;
            numericUpDownCheeseDip.Value = 0;
            numericUpDownGarlicDip.Value = 0;
            numericUpDownSourDip.Value = 0;
            checkBoxCoke.Checked = false;
            checkBoxSprite.Checked = false;
            checkBoxOJ.Checked = false;
            checkBoxAJ.Checked = false;
            numericUpDownCoke.Value = 0;
            numericUpDownSprite.Value = 0;
            numericUpDownOJ.Value = 0;
            numericUpDownAPJ.Value = 0;
            checkBoxBrownie.Checked = false;
            checkBoxCookie.Checked = false;
            checkBoxCheeseCake.Checked = false;
            checkBoxIceCream.Checked = false;
            numericUpDownBrown.Value = 0;
            numericUpDownCookies.Value = 0;
            numericUpDownCheeseCake.Value = 0;
            numericUpDownIceCream.Value = 0;
        }

        // Event handler for the "Add to Cart" button
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            List<string> currentOrderItems = new List<string>();
            decimal orderAmount = 0;

            // Pizza Size
            string pizzaSize = "";
            if (radioButtonSmall.Checked)
            {
                orderAmount += 8;
                pizzaSize = "Small Pizza";
            }
            else if (radioButtonMedium.Checked)
            {
                orderAmount += 12;
                pizzaSize = "Medium Pizza";
            }
            else if (radioButtonLarge.Checked)
            {
                orderAmount += 16;
                pizzaSize = "Large Pizza";
            }

            if (string.IsNullOrEmpty(pizzaSize))
            {
                MessageBox.Show("Please select a pizza size!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crust Type
            string crustType = "";
            if (radioButtonNormal.Checked) crustType = "Normal Crust";
            else if (radioButtonThin.Checked) crustType = "Thin Crust";
            else if (radioButtonThick.Checked) crustType = "Thick Crust";

            // Toppings
            List<string> toppings = new List<string>();
            if (checkBoxPepperoni.Checked) { toppings.Add("Pepperoni"); orderAmount += 1; }
            if (checkBoxHam.Checked) { toppings.Add("Ham"); orderAmount += 1; }
            if (checkBoxBacon.Checked) { toppings.Add("Bacon"); orderAmount += 1; }
            if (checkBoxOlives.Checked) { toppings.Add("Olives"); orderAmount += 1; }
            if (checkBoxOnions.Checked) { toppings.Add("Onions"); orderAmount += 1; }
            if (checkBoxCheese.Checked) { toppings.Add("Extra Cheese"); orderAmount += 1; }
            if (checkBoxSausage.Checked) { toppings.Add("Sausage"); orderAmount += 1; }
            if (checkBoxMushroom.Checked) { toppings.Add("Mushroom"); orderAmount += 1; }
            if (checkBoxPeppers.Checked) { toppings.Add("Peppers"); orderAmount += 1; }

            // Other Items
            List<string> otherItems = new List<string>();
            if (checkBoxWings.Checked && numericUpDownChick.Value > 0)
            {
                otherItems.Add($"Chicken Wings x{numericUpDownChick.Value}");
                orderAmount += 6 * numericUpDownChick.Value;
            }
            if (checkBoxSalad.Checked && numericUpDownSalad.Value > 0)
            {
                otherItems.Add($"Salad x{numericUpDownSalad.Value}");
                orderAmount += 4 * numericUpDownSalad.Value;
            }
            if (checkBoxFries.Checked && numericUpDownFries.Value > 0)
            {
                otherItems.Add($"French Fries x{numericUpDownFries.Value}");
                orderAmount += 3 * numericUpDownFries.Value;
            }
            if (checkBoxRings.Checked && numericUpDownOnion.Value > 0)
            {
                otherItems.Add($"Onion Rings x{numericUpDownOnion.Value}");
                orderAmount += 3 * numericUpDownOnion.Value;
            }
            if (checkBoxGarlicBread.Checked && numericUpDownCheesy.Value > 0)
            {
                otherItems.Add($"Cheesy Garlic Bread x{numericUpDownCheesy.Value}");
                orderAmount += 3 * numericUpDownCheesy.Value;
            }
            if (checkBoxCheesyDip.Checked && numericUpDownCheeseDip.Value > 0)
            {
                otherItems.Add($"Cheesy Dip x{numericUpDownCheeseDip.Value}");
                orderAmount += 1 * numericUpDownCheeseDip.Value;
            }
            if (checkBoxGarlicDip.Checked && numericUpDownGarlicDip.Value > 0)
            {
                otherItems.Add($"Garlic Dip x{numericUpDownGarlicDip.Value}");
                orderAmount += 1 * numericUpDownGarlicDip.Value;
            }
            if (checkBoxSourDip.Checked && numericUpDownSourDip.Value > 0)
            {
                otherItems.Add($"Sour Cream Dip x{numericUpDownSourDip.Value}");
                orderAmount += 1 * numericUpDownSourDip.Value;
            }

            // Drinks
            List<string> drinks = new List<string>();
            if (checkBoxCoke.Checked && numericUpDownCoke.Value > 0)
            {
                drinks.Add($"Coke x{numericUpDownCoke.Value}");
                orderAmount += 2 * numericUpDownCoke.Value;
            }
            if (checkBoxSprite.Checked && numericUpDownSprite.Value > 0)
            {
                drinks.Add($"Sprite x{numericUpDownSprite.Value}");
                orderAmount += 2 * numericUpDownSprite.Value;
            }
            if (checkBoxOJ.Checked && numericUpDownOJ.Value > 0)
            {
                drinks.Add($"Orange Juice x{numericUpDownOJ.Value}");
                orderAmount += 2.5m * numericUpDownOJ.Value;
            }
            if (checkBoxAJ.Checked && numericUpDownAPJ.Value > 0)
            {
                drinks.Add($"Apple Juice x{numericUpDownAPJ.Value}");
                orderAmount += 2.5m * numericUpDownAPJ.Value;
            }

            // Desserts
            List<string> desserts = new List<string>();
            if (checkBoxBrownie.Checked && numericUpDownBrown.Value > 0)
            {
                desserts.Add($"Brownies x{numericUpDownBrown.Value}");
                orderAmount += 2 * numericUpDownBrown.Value;
            }
            if (checkBoxCookie.Checked && numericUpDownCookies.Value > 0)
            {
                desserts.Add($"Cookies x{numericUpDownCookies.Value}");
                orderAmount += 2 * numericUpDownCookies.Value;
            }
            if (checkBoxCheeseCake.Checked && numericUpDownCheeseCake.Value > 0)
            {
                desserts.Add($"Cheesecake x{numericUpDownCheeseCake.Value}");
                orderAmount += 4 * numericUpDownCheeseCake.Value;
            }
            if (checkBoxIceCream.Checked && numericUpDownIceCream.Value > 0)
            {
                desserts.Add($"Ice Cream x{numericUpDownIceCream.Value}");
                orderAmount += 3 * numericUpDownIceCream.Value;
            }

            // The order summary in the listBox
            List<string> orderParts = new List<string> { $"{pizzaSize} with {crustType}" };
            if (toppings.Count > 0)
            {
                orderParts.Add($"Toppings: {string.Join(", ", toppings)}");
            }
            if (drinks.Count > 0)
            {
                orderParts.Add($"Drinks: {string.Join(", ", drinks)}");
            }
            if (otherItems.Count > 0)
            {
                orderParts.Add($"Other Items: {string.Join(", ", otherItems)}");
            }
            if (desserts.Count > 0)
            {
                orderParts.Add($"Desserts: {string.Join(", ", desserts)}");
            }

            string orderSummary = string.Join(" | ", orderParts);

            // Add to orders list and store the price
            orderSummaries.Add(orderSummary);
            orderPrices.Add(orderAmount);
            totalAmount += orderAmount;

            // Update listBoxCart with all orders
            listBoxCart.Items.Clear();
            foreach (var summary in orderSummaries)
            {
                listBoxCart.Items.Add(summary);
            }

            // Update total display
            textBoxTotalMain.Text = $"{totalAmount:F2} €";

            // Reset all selections after adding to cart
            ResetSelections();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order to edit!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = listBoxCart.SelectedIndex;
            string selectedOrder = orderSummaries[selectedIndex];

            ResetSelections();

            // Parse pizza size and crust
            if (selectedOrder.Contains("Small Pizza")) radioButtonSmall.Checked = true;
            else if (selectedOrder.Contains("Medium Pizza")) radioButtonMedium.Checked = true;
            else if (selectedOrder.Contains("Large Pizza")) radioButtonLarge.Checked = true;

            if (selectedOrder.Contains("Normal Crust")) radioButtonNormal.Checked = true;
            else if (selectedOrder.Contains("Thin Crust")) radioButtonThin.Checked = true;
            else if (selectedOrder.Contains("Thick Crust")) radioButtonThick.Checked = true;

            // Parse toppings
            if (selectedOrder.Contains("Pepperoni")) checkBoxPepperoni.Checked = true;
            if (selectedOrder.Contains("Ham")) checkBoxHam.Checked = true;
            if (selectedOrder.Contains("Bacon")) checkBoxBacon.Checked = true;
            if (selectedOrder.Contains("Olives")) checkBoxOlives.Checked = true;
            if (selectedOrder.Contains("Onions")) checkBoxOnions.Checked = true;
            if (selectedOrder.Contains("Extra Cheese")) checkBoxCheese.Checked = true;
            if (selectedOrder.Contains("Sausage")) checkBoxSausage.Checked = true;
            if (selectedOrder.Contains("Mushroom")) checkBoxMushroom.Checked = true;
            if (selectedOrder.Contains("Peppers")) checkBoxPeppers.Checked = true;

            // Parse other items
            ParseItem(selectedOrder, "Chicken Wings x", checkBoxWings, numericUpDownChick);
            ParseItem(selectedOrder, "Salad x", checkBoxSalad, numericUpDownSalad);
            ParseItem(selectedOrder, "French Fries x", checkBoxFries, numericUpDownFries);
            ParseItem(selectedOrder, "Onion Rings x", checkBoxRings, numericUpDownOnion);
            ParseItem(selectedOrder, "Cheesy Garlic Bread x", checkBoxGarlicBread, numericUpDownCheesy);
            ParseItem(selectedOrder, "Cheesy Dip x", checkBoxCheesyDip, numericUpDownCheeseDip);
            ParseItem(selectedOrder, "Garlic Dip x", checkBoxGarlicDip, numericUpDownGarlicDip);
            ParseItem(selectedOrder, "Sour Cream Dip x", checkBoxSourDip, numericUpDownSourDip);

            // Parse drinks
            ParseItem(selectedOrder, "Coke x", checkBoxCoke, numericUpDownCoke);
            ParseItem(selectedOrder, "Sprite x", checkBoxSprite, numericUpDownSprite);
            ParseItem(selectedOrder, "Orange Juice x", checkBoxOJ, numericUpDownOJ);
            ParseItem(selectedOrder, "Apple Juice x", checkBoxAJ, numericUpDownAPJ);

            // Parse desserts
            ParseItem(selectedOrder, "Brownies x", checkBoxBrownie, numericUpDownBrown);
            ParseItem(selectedOrder, "Cookies x", checkBoxCookie, numericUpDownCookies);
            ParseItem(selectedOrder, "Cheesecake x", checkBoxCheeseCake, numericUpDownCheeseCake);
            ParseItem(selectedOrder, "Ice Cream x", checkBoxIceCream, numericUpDownIceCream);

            // Remove the selected order and adjust the total
            totalAmount -= orderPrices[selectedIndex];
            orderSummaries.RemoveAt(selectedIndex);
            orderPrices.RemoveAt(selectedIndex);

            listBoxCart.Items.Clear();
            foreach (var summary in orderSummaries)
            {
                listBoxCart.Items.Add(summary);
            }
            textBoxTotalMain.Text = $"{totalAmount:F2} €";

            // Navigate to the first tab (Make Your Order)
            tabControl1.SelectedIndex = 0;
        }

        private void buttonCF_Click(object sender, EventArgs e)
        {
            if (orderSummaries.Count == 0)
            {
                MessageBox.Show("Please add items to your cart before confirming!", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Move to Confirm Order tab
            tabControl1.SelectedIndex = 1;

            // Clear the table and set up columns
            tableLayoutPanelCart.Controls.Clear();
            tableLayoutPanelCart.RowCount = orderSummaries.Count + 2; // +1 for header row, +1 for total row
            tableLayoutPanelCart.ColumnCount = 4; // Item, Qty, Price, Total

            // Add header row
            tableLayoutPanelCart.Controls.Add(new Label { Text = "Item", AutoSize = true }, 0, 0);
            tableLayoutPanelCart.Controls.Add(new Label { Text = "Qty", AutoSize = true }, 1, 0);
            tableLayoutPanelCart.Controls.Add(new Label { Text = "Price", AutoSize = true }, 2, 0);
            tableLayoutPanelCart.Controls.Add(new Label { Text = "Total", AutoSize = true }, 3, 0);

            // Populate table with orders in reverse order (newest at the top)
            for (int i = 0; i < orderSummaries.Count; i++)
            {
                int displayIndex = orderSummaries.Count - i - 1; // Reverse the order
                string order = orderSummaries[displayIndex];
                decimal price = orderPrices[displayIndex];

                // Add order details to the table
                tableLayoutPanelCart.Controls.Add(new Label { Text = order, AutoSize = true }, 0, i + 1);
                tableLayoutPanelCart.Controls.Add(new Label { Text = "1", AutoSize = true }, 1, i + 1); // Qty is always 1
                tableLayoutPanelCart.Controls.Add(new Label { Text = $"{price:F2} €", AutoSize = true }, 2, i + 1);
                tableLayoutPanelCart.Controls.Add(new Label { Text = $"{price:F2} €", AutoSize = true }, 3, i + 1);
            }

            // Add total row at the bottom
            tableLayoutPanelCart.Controls.Add(new Label { Text = "TOTAL:", AutoSize = true }, 2, orderSummaries.Count + 1);
            tableLayoutPanelCart.Controls.Add(new Label { Text = $"{totalAmount:F2} €", AutoSize = true }, 3, orderSummaries.Count + 1);
        }

        private void buttonEditOrderTab2_Click_1(object sender, EventArgs e)
        {
            // Navigate to the first tab (Make Your Order)
            tabControl1.SelectedIndex = 0;
        }
        private void buttonBackOC_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
        private void buttonPayTab2_Click(object sender, EventArgs e)
        {
            // Navigate to the third tab (Make Payment)
            tabControl1.SelectedIndex = 2;
            textBoxDue.Text = $"{totalAmount:F2} €";
        }
        private void comboBoxMethod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxMethod.SelectedItem.ToString() == "Card")
            {
                groupBoxCard.Visible = true;
                groupBoxCash.Visible = false;
                textBoxPaid.Text = "";
                textBoxChange.Text = "";
            }
            else
            {
                groupBoxCard.Visible = false;
                groupBoxCash.Visible = true;
                textBoxCardNum.Text = "";
                textBoxCardName.Text = "";
                textBoxEx.Text = "";
                textBoxCvv.Text = "";
            }
        }
        // Final Payment and validation on the third tab
        private void buttonPayTab3_Click(object sender, EventArgs e)
        {
            // Validate required customer information fields
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAddress.Text) ||
                string.IsNullOrEmpty(textBoxCity.Text) || string.IsNullOrEmpty(textBoxPost.Text) ||
                string.IsNullOrEmpty(textBoxNum.Text))
            {
                MessageBox.Show("Please fill in all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate payment method specific fields
            if (comboBoxMethod.SelectedItem.ToString() == "Card")
            {
                if (string.IsNullOrEmpty(textBoxCardNum.Text) || string.IsNullOrEmpty(textBoxCardName.Text) ||
                    string.IsNullOrEmpty(textBoxEx.Text) || string.IsNullOrEmpty(textBoxCvv.Text))
                {
                    MessageBox.Show("Please fill in all card details!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Card Number = 16 digits
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxCardNum.Text, @"^\d{16}$"))
                {
                    MessageBox.Show("Card number must be exactly 16 digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Expiry Date = MM/YY format
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEx.Text, @"^(0[1-9]|1[0-2])\/\d{2}$"))
                {
                    MessageBox.Show("Expiry date must be in MM/YY format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // CVV = 3 digits
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxCvv.Text, @"^\d{3}$"))
                {
                    MessageBox.Show("CVV must be exactly 3 digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (comboBoxMethod.SelectedItem.ToString() == "Cash")
            {
                if (string.IsNullOrEmpty(textBoxPaid.Text))
                {
                    MessageBox.Show("Please enter the amount paid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textBoxPaid.Text, out decimal paidAmount) || paidAmount < totalAmount)
                {
                    MessageBox.Show("Amount paid is insufficient!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Show thank you message
            MessageBox.Show("Thank you for your order!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset the form
            cartItems.Clear();
            orderSummaries.Clear();
            orderPrices.Clear();
            listBoxCart.Items.Clear();
            totalAmount = 0;
            textBoxTotalMain.Text = "0 €";
            textBoxDue.Text = "0 €";
            textBoxPaid.Text = "";
            textBoxChange.Text = "";
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            textBoxCity.Text = "";
            textBoxPost.Text = "";
            textBoxNum.Text = "";
            textBoxEmail.Text = "";
            textBoxinfo.Text = "";
            textBoxCardNum.Text = "";
            textBoxCardName.Text = "";
            textBoxEx.Text = "";
            textBoxCvv.Text = "";
            comboBoxMethod.SelectedIndex = 0;
            tabControl1.SelectedIndex = 0;
            ResetSelections();

            // Close the form after successful payment
            this.Close();
        }

        // To re-load an existing order into the form fields when editing
        private void ParseItem(string order, string itemName, CheckBox checkBox, NumericUpDown numericUpDown)
        {
            if (order.Contains(itemName))
            {
                checkBox.Checked = true;
                string quantityStr = order.Substring(order.IndexOf(itemName) + itemName.Length);
                if (int.TryParse(quantityStr.Split(' ')[0], out int quantity))
                {
                    numericUpDown.Value = quantity;
                }
            }
        }
    }
}