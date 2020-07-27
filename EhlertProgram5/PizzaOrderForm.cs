using System;
using System.Windows.Forms;

/*  ID
 *      Pizza Order Form, Kaleb Ehlert, 2/11/2018
 *  Purpose
 *      The purpose of the program is to take the order of the user and process it to get a total price and output what is stated below.
 *  Form Controls
 *      picLogo: Displays the companies logo,   lblPizzaSelection: Display's tabs reason for existing,  lblSize: Labels the cmbSize control
 *      cmbSize: Allows the selection of different sizes,   lblPizzaType: Labels the cmbPizzaType control,  cmbPizzaType: Allows the user
 *      to select the pizza type,   lblPizzaQuantity: Labels the cmbPizzaQuantity control,  cmbPizzaQuantity: Allows the user to select
 *      the number of pizzas desired,   lblToppings: Labels the ckLstToppings control,  lblBeverages: Labels the beverages list side,
 *      lblBeverageQuantity: Labels the quantity side,      lstBeverages: List the different beverages,     txtMtnDewOriginalQuantity:
 *      Allows the user to enter the quantity of mountain dew desired,  txtMtnDewCodeRedQuantity: Allows the user to enter the quantity of
 *      code red mountain dew they desire,  txtSpriteQuantity: Allows them to order the quantity of sprite they want,   txtMugRootBeerQuantity:
 *      Allows the user to enter the quantity of root beer they want,   txtDrPepperQuantity: Allows the user to enter the quantity of Dr. Pepper
 *      they want,  lblBeverageWarning: Provides disclaimers to the user about beverages,   lblDesserts: Labels the dessert/sides side of the form,
 *      lblDesertQuantity: Labels the quantity side of the form,    lstDessertsSides: List the sides/desserts,  txtChocolateChipQuantity:
 *      Allows the user to enter the quantity of chocolate chip pizzas, txtCarmelChocolateChipQuantity: Allows the user to enter the quantity of
 *      carmel chocolate chip pizzas,   txtBrownieQuantity: Allows the user to enter the quantity of brownies,   txtCinnamonPullApartsQuantity:
 *      Allows the user to enter the quantity of cinnamon pull aparts,  txtCheeseSticksQuantity: Allows the user to enter the quantity of cheese
 *      sticks, lblDessertWarning: Provides a disclaimer on the dessert/side section,   lblCustomerInfo: Labels what is need on this tab,
 *      lstCustomerInfo: Lists the info needed, txtName: The control for the name input,  txtAddress: The control for the address input,
 *      txtPhoneNumber: The control for the phone number input, txtEmail: The control for the email input,    txtCreditCard: The control for the
 *      credit card input,  cmbCreditCardType: The control for the credit card type,    txtOrder: The control for the output,   btnPlaceOrder:
 *      The button to place the order,  btnReset: The button to reset all the controls with a text component
 *  Code & Logic
 *      The input is the order of pizzas, beverages, and sides/desserts the user desires.
 *      The processing determines the total price of the order.
 *      The output is the name, address, phone number, email, social security number and type. As well as, the total price for the order.
 */

namespace EhlertProgram5
{
    public partial class PizzaOrderForm : Form
    {
        // Constructor
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        // Processes the order when clicked
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int price = 0;
            
            // Empties the txtOrder field
            txtOrder.Text = "";

            // Add the name and address on one line. Then add phone number and email on the next line
            txtOrder.Text += txtName.Text + "   " + txtAddress.Text + "\r\n" +
                txtPhoneNumber.Text + "   " + txtEmail.Text + "\r\n" + "\r\n";

            // Add the credit card number and credit card type on one line
            txtOrder.Text += txtCreditCard.Text + "   " + cmbCreditCardType.Text + "\r\n";

            // Calculates the final price of the product
            price = Price();

            // Outputs the price of the order
            txtOrder.Text += " The total price is $" + price + ".00.";

            // Show message to confirm order and show the price of the order
            MessageBox.Show("Your order is placed. The total price is $" + price + ".00. Check the order tab for more info.");
        }

        // Sets all fields empty when clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Empties the txtOrder field
            txtOrder.Text = " ";

            // Empties the customer tab fields
            txtName.Text = "";

            txtAddress.Text = " ";

            txtPhoneNumber.Text = " ";

            txtEmail.Text = " ";

            txtCreditCard.Text = " ";

            cmbCreditCardType.Text = " ";

            // Empty the Pizza tab fields
            cmbSize.Text = "";

            cmbPizzaType.Text = "";

            cmbPizzaQuantity.Text = "";

            for (int index = 0; index < ckLstToppings.Items.Count; index++) {
                ckLstToppings.SetItemChecked(index, false);
            }

            // Empty the beverage tab fields
            txtMtnDewOriginalQuantity.Text = "";

            txtMtnDewCodeRedQuantity.Text = "";

            txtSpriteQuantity.Text = "";

            txtMugRootBeerQuantity.Text = "";

            txtDrPepperQuantity.Text = "";

            // Empty the side/desserts fields
            txtChocolateChipQuantity.Text = "";

            txtCarmelChocolateChipQuantity.Text = "";

            txtBrownieQuantity.Text = "";

            txtCinnamonPullApartsQuantity.Text = "";

            txtCheeseSticksQuantity.Text = "";

            // Empty the order tab
            txtOrder.Text = "";
        }

        // Calculates the price of the order (price = (size price * quantity) + $3.00 + berverage total + side/dessert total)
        private int Price()
        {
            int price = 0;
            
            // Calculate the price based off the size and add three dollars, even if there is no toppings
            if (cmbSize.Text == "Small         $11.00") {
                price += 11;
            } else if (cmbSize.Text == "Medium    $13.00") {
                price += 13;
            } else if (cmbSize.Text == "Large         $15.00") {
                price += 15;
            } else if (cmbSize.Text == "X-Large     $17.00") {
                price += 17;
            }

            // Multiply by the number of pizzas and then add three dollars
            price = (price * int.Parse(cmbPizzaQuantity.Text)) + 3;

            // Add the total price of beverages
            if (txtMtnDewOriginalQuantity.Text != "")
                price = (int.Parse(txtMtnDewOriginalQuantity.Text) * 3) + price;

            if (txtMtnDewCodeRedQuantity.Text != "")
                price = ( int.Parse(txtMtnDewCodeRedQuantity.Text) * 3 ) + price;

            if (txtSpriteQuantity.Text != "")
                price = ( int.Parse(txtSpriteQuantity.Text) * 3 ) + price;

            if (txtMugRootBeerQuantity.Text != "")
                price = ( int.Parse(txtMugRootBeerQuantity.Text) * 3 ) + price;

            if (txtDrPepperQuantity.Text != "")
                price = ( int.Parse(txtDrPepperQuantity.Text) * 3 ) + price;

            // Add the total price of sides/desserts
            if (txtChocolateChipQuantity.Text != "")
                price = ( int.Parse(txtChocolateChipQuantity.Text) * 6 ) + price;

            if (txtCarmelChocolateChipQuantity.Text != "")
                price = ( int.Parse(txtCarmelChocolateChipQuantity.Text) * 6 ) + price;

            if (txtBrownieQuantity.Text != "")
                price = ( int.Parse(txtBrownieQuantity.Text) * 6 ) + price;

            if (txtCinnamonPullApartsQuantity.Text != "")
                price = ( int.Parse(txtCinnamonPullApartsQuantity.Text) * 6 ) + price;

            if (txtCheeseSticksQuantity.Text != "")
                price = ( int.Parse(txtCheeseSticksQuantity.Text) * 6 ) + price;

            return price;
        }
    }
}
