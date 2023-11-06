namespace CS311_Project3_ABE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double subtotal = 0.00;
            double taxRate = 0.06;  // 6% tax rate

            // Determine the selected pizza size
            double pizzaPrice = 0.00;
            string selectedSize = "";
            if (cboSize.SelectedItem != null)
            {
                selectedSize = cboSize.SelectedItem.ToString();
                switch (selectedSize)
                {
                    case "Small":
                        pizzaPrice = 2.00;
                        break;
                    case "Medium":
                        pizzaPrice = 5.00;
                        break;
                    case "Large":
                        pizzaPrice = 10.00;
                        break;
                    case "X-Large":
                        pizzaPrice = 15.00;
                        break;
                    case "Ginormous":
                        pizzaPrice = 20.00;
                        break;
                }//end switch statement for size
            }//end size selection

            // Determine the selected crust type
            string crustType = "";
            double crustPrice = 0.00;
            if (rdoThin.Checked)
            {
                crustPrice = 0.00;
                crustType = "Thin";
            }
            else if (rdoThick.Checked)
            {
                crustPrice = 0.00;
                crustType = "Thick";
            }
            else if (rdoRegular.Checked)
            {
                crustPrice = 0.00;
                crustType = "Regular";
            }//end crust selection

            // Calculate the toppings price
            double toppingsPrice = 0.00;
            string toppingsList = "";
            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    double toppingPrice = 0.00; //initializes toppingPrice
                    string toppingName = control.Name.Substring(3); // Remove the "ckb" prefix

                    switch (toppingName)
                    {
                        case "Pepperoni":
                            toppingPrice = 2.00;
                            break;
                        case "Sausage":
                            toppingPrice = 2.00;
                            break;
                        case "CanadianBacon":
                            toppingName = "Canadian Bacon";
                            toppingPrice = 2.00;
                            break;
                        case "SpicyItalianSausage":
                            toppingName = "Spicy Italian Sausage";
                            toppingPrice = 2.00;
                            break;
                        case "GreenPepper":
                            toppingName = "Green Pepper";
                            toppingPrice = 1.00;
                            break;
                        case "BlackOlives":
                            toppingName = "Black Olives";
                            toppingPrice = 1.00;
                            break;
                        case "GreenOlives":
                            toppingName = "Green Olives";
                            toppingPrice = 1.00;
                            break;
                        case "BananaPeppers":
                            toppingName = "Banana Peppers";
                            toppingPrice = 1.00;
                            break;
                        case "ExtraCheese":
                            toppingName = "Extra Cheese";
                            toppingPrice = 1.00;
                            break;
                        default:
                            toppingPrice = 1.00;
                            break;
                    }//end switch statement
                    toppingsList += toppingName + "\n";
                    toppingsPrice += toppingPrice;
                }//end if statement
            }//end topping selection

            // Calculate the subtotal and tax
            subtotal = pizzaPrice + crustPrice + toppingsPrice;
            double tax = subtotal * taxRate;
            double total = subtotal + tax;

            // Display the order summary
            rtfOrderSummary.Text = "You ordered a " + selectedSize + " pizza with " + crustType + " crust and the following toppings:\n" + toppingsList;

            //bullets? Can't get them to work right.

            txtSubtotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
        }//end btnCalculate_Click

        private void ckbPepperoni_CheckedChanged(object sender, EventArgs e)
        {

        }
    }//end form
}//end namespace