/*
 * Created by: Joelle Ishiwme
 * Created on: 4-April-2020
 * Created for: ICS3U Programming
 * Assignment #3b - Pizza Order
 * This program calculates the cost of a pizza order
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderJoelle
{
    public partial class frmPizzaOrder : Form
    {
        //declare variables
        double taxes;
        int taxPercentage;
        double pizzaSizeCost;
        double pizzaToppingCost;
        double frieBoxSizeCost;

        public frmPizzaOrder()
        {
            InitializeComponent();

            //hide pizza size items
            this.lblPizzaSize.Hide();
            this.lblLarge.Hide();
            this.lblExtraLarge.Hide();
            this.picLargePizzaSize.Hide();
            this.picExtraLargePizzaSize.Hide();

            //hide pizza toppings items
            this.lblPizzaTopping.Hide();
            this.nudToppings.Hide();
            this.btnToppingsNext.Hide();
            this.lblOneTopping.Hide();
            this.lblNoToppings.Hide();
            this.lblTwoToppings.Hide();
            this.lblThreeToppings.Hide();
            this.lblFourToppings.Hide();

            //hide frie box size items
            this.lblSmallFries.Hide();
            this.lblLargeFries.Hide();
            this.lblNoFries.Hide();
            this.lblFries.Hide();
            this.picSmallFries.Hide();
            this.picLargeFries.Hide();
            this.picNoFries.Hide();

            //hide calculation items
            this.lstTotalCost.Hide();
            this.lblTotalCost.Hide();
            this.lblRecipt.Hide();

        }

        private void btnProvinceNext_Click(object sender, EventArgs e)
        {
            //declare variables
            int province;

            //convert the value from the numberic up down into an integer
            province = Convert.ToInt32(nudProvince.Value);

            //if statement for the chosen province, therefore taxes
            if (province == 1)
            {
                //set the tax according to province
                taxes = 1.12;
                taxPercentage = 12;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 2)
            {
                taxes = 1.05;
                taxPercentage = 5;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 3)
            {
                taxes = 1.10;
                taxPercentage = 10;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 4)
            {
                taxes = 1.12;
                taxPercentage = 12;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show(); ;
            }

            else if (province == 5)
            {
                taxes = 1.13;
                taxPercentage = 13;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 6)
            {
                taxes = 1.15;
                taxPercentage = 15;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 7)
            {
                taxes = 1.13;
                taxPercentage = 13;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 8)
            {
                taxes = 1.15;
                taxPercentage = 15;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else if (province == 9)
            {
                taxes = 1.13;
                taxPercentage = 13;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }

            else
            {
                taxes = 1.15;
                taxPercentage = 15;

                //hide the province items
                this.lblProvince.Hide();
                this.nudProvince.Hide();
                this.lblBritishColumbia.Hide();
                this.lblAlberta.Hide();
                this.lblSaskatchewan.Hide();
                this.lblManitoba.Hide();
                this.lblOntario.Hide();
                this.lblQuebec.Hide();
                this.lblNewfoundland.Hide();
                this.lblPrinceEdwardIsland.Hide();
                this.lblNewBruswick.Hide();
                this.lblNovaScotia.Hide();
                this.btnProvinceNext.Hide();

                //show pizza size items
                this.lblPizzaSize.Show();
                this.lblLarge.Show();
                this.lblExtraLarge.Show();
                this.picLargePizzaSize.Show();
                this.picExtraLargePizzaSize.Show();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void btnPizzaSizeNext_Click(object sender, EventArgs e)
        {
        }
        private void picLargePizzaSize_Click(object sender, EventArgs e)
        {

            //assigne the cost of the pizza size
            pizzaSizeCost = 9.99;

            //hide pizza size items
            this.lblPizzaSize.Hide();
            this.lblLarge.Hide();
            this.lblExtraLarge.Hide();
            this.picLargePizzaSize.Hide();
            this.picExtraLargePizzaSize.Hide();

            //show pizza toppings items
            this.lblPizzaTopping.Show();
            this.nudToppings.Show();
            this.btnToppingsNext.Show();
            this.lblOneTopping.Show();
            this.lblNoToppings.Show();
            this.lblTwoToppings.Show();
            this.lblThreeToppings.Show();
            this.lblFourToppings.Show();

        }

        private void picExtraLargePizzaSize_Click(object sender, EventArgs e)
        {
            //assigne the cost of the pizza size
            pizzaSizeCost = 12.99;

            //hide pizza size items
            this.lblPizzaSize.Hide();
            this.lblLarge.Hide();
            this.lblExtraLarge.Hide();
            this.picLargePizzaSize.Hide();
            this.picExtraLargePizzaSize.Hide();

            //show pizza toppings items
            this.lblPizzaTopping.Show();
            this.nudToppings.Show();
            this.btnToppingsNext.Show();
            this.lblOneTopping.Show();
            this.lblNoToppings.Show();
            this.lblTwoToppings.Show();
            this.lblThreeToppings.Show();
            this.lblFourToppings.Show();

        }

        private void btnToppingsNext_Click(object sender, EventArgs e)
        {
            //declare variables
            int toppings;

            //convert the value from the numberic up down into an integer
            toppings = Convert.ToInt32(nudProvince.Value);

            //if statement for the chosen province, therefore taxes
            if (toppings == 1)
            {
                pizzaToppingCost = 0.75;

                //hide pizza toppings items
                this.lblPizzaTopping.Hide();
                this.nudToppings.Hide();
                this.btnToppingsNext.Hide();
                this.lblOneTopping.Hide();
                this.lblNoToppings.Hide();
                this.lblTwoToppings.Hide();
                this.lblThreeToppings.Hide();
                this.lblFourToppings.Hide();

                //show frie box size items
                this.lblFries.Show();
                this.lblSmallFries.Show();
                this.lblLargeFries.Show();
                this.lblNoFries.Show();
                this.picSmallFries.Show();
                this.picLargeFries.Show();
                this.picNoFries.Show();
            }

            else if (toppings == 2)
            {
                pizzaToppingCost = 1.35;

                //hide pizza toppings items
                this.lblPizzaTopping.Hide();
                this.nudToppings.Hide();
                this.btnToppingsNext.Hide();
                this.lblOneTopping.Hide();
                this.lblNoToppings.Hide();
                this.lblTwoToppings.Hide();
                this.lblThreeToppings.Hide();
                this.lblFourToppings.Hide();

                //show frie box size items
                this.lblFries.Show();
                this.lblSmallFries.Show();
                this.lblLargeFries.Show();
                this.lblNoFries.Show();
                this.picSmallFries.Show();
                this.picLargeFries.Show();
                this.picNoFries.Show();
            }

            else if (toppings == 3)
            {
                pizzaToppingCost = 2.15;

                //hide pizza toppings items
                this.lblPizzaTopping.Hide();
                this.nudToppings.Hide();
                this.btnToppingsNext.Hide();
                this.lblOneTopping.Hide();
                this.lblNoToppings.Hide();
                this.lblTwoToppings.Hide();
                this.lblThreeToppings.Hide();
                this.lblFourToppings.Hide();

                //show frie box size items
                this.lblFries.Show();
                this.lblSmallFries.Show();
                this.lblLargeFries.Show();
                this.lblNoFries.Show();
                this.picSmallFries.Show();
                this.picLargeFries.Show();
                this.picNoFries.Show();
            }

            else if (toppings == 4)
            {
                pizzaToppingCost = 2.75;

                //hide pizza toppings items
                this.lblPizzaTopping.Hide();
                this.nudToppings.Hide();
                this.btnToppingsNext.Hide();
                this.lblOneTopping.Hide();
                this.lblNoToppings.Hide();
                this.lblTwoToppings.Hide();
                this.lblThreeToppings.Hide();
                this.lblFourToppings.Hide();

                //show frie box size items
                this.lblFries.Show();
                this.lblSmallFries.Show();
                this.lblLargeFries.Show();
                this.lblNoFries.Show();
                this.picSmallFries.Show();
                this.picLargeFries.Show();
                this.picNoFries.Show();
            }

            else
            {
                pizzaToppingCost = 0;

                //hide pizza toppings items
                this.lblPizzaTopping.Hide();
                this.nudToppings.Hide();
                this.btnToppingsNext.Hide();
                this.lblOneTopping.Hide();
                this.lblNoToppings.Hide();
                this.lblTwoToppings.Hide();
                this.lblThreeToppings.Hide();
                this.lblFourToppings.Hide();

                //show frie box size items
                this.lblFries.Show();
                this.lblSmallFries.Show();
                this.lblLargeFries.Show();
                this.lblNoFries.Show();
                this.picSmallFries.Show();
                this.picLargeFries.Show();
                this.picNoFries.Show();
            }
        }

        private void picSmallFries_Click(object sender, EventArgs e)
        {
            //assigne the cost of a small frie box
            frieBoxSizeCost = 6.00;

            //hide frie box size items
            this.lblSmallFries.Hide();
            this.lblLargeFries.Hide();
            this.lblNoFries.Hide();
            this.lblFries.Hide();
            this.picSmallFries.Hide();
            this.picLargeFries.Hide();
            this.picNoFries.Hide();

            //show calculation items
            this.lstTotalCost.Show();
            this.lblRecipt.Show();

            //declare local variables
            double totalCost;

            //clear the listbox
            this.lstTotalCost.Items.Clear();

            //calculate the total price
            totalCost = (pizzaSizeCost + pizzaToppingCost + frieBoxSizeCost) * taxes;

            //dipslay the prices in list box
            this.lstTotalCost.Items.Add("$ " + pizzaSizeCost + "  for the pizza size");
            this.lstTotalCost.Items.Add("+   $ " + pizzaToppingCost + "  for the pizza topping(s)");
            this.lstTotalCost.Items.Add("+   $ " + frieBoxSizeCost + "  for the size of the fries");
            this.lstTotalCost.Items.Add("+   " + taxPercentage + " % taxes");

            //display the total in a label
            this.lblTotalCost.Text = Convert.ToString(Math.Round(totalCost, 2)) + "  is your total";

            //display the label that display's the answer
            this.lblTotalCost.Show();
        }

        private void picLargeFries_Click(object sender, EventArgs e)
        {
            //assigne the cost of a large frie box
            frieBoxSizeCost = 12.00;

            //hide frie box size items
            this.lblSmallFries.Hide();
            this.lblLargeFries.Hide();
            this.lblNoFries.Hide();
            this.lblFries.Hide();
            this.picSmallFries.Hide();
            this.picLargeFries.Hide();
            this.picNoFries.Hide();

            //show calculation items
            this.lstTotalCost.Show();
            this.lblRecipt.Show();


            //declare local variables
            double totalCost;

            //clear the listbox
            this.lstTotalCost.Items.Clear();

            //calculate the total price
            totalCost = (pizzaSizeCost + pizzaToppingCost + frieBoxSizeCost) * taxes;

            //dipslay the prices in list box
            this.lstTotalCost.Items.Add("$ " + pizzaSizeCost + "  for the pizza size");
            this.lstTotalCost.Items.Add("+   $ " + pizzaToppingCost + "  for the pizza topping(s)");
            this.lstTotalCost.Items.Add("+   $ " + frieBoxSizeCost + "  for the size of the fries");
            this.lstTotalCost.Items.Add("+   " + taxPercentage + " % taxes");

            //display the total in a label
            this.lblTotalCost.Text = Convert.ToString(Math.Round(totalCost, 2)) + "  is your total";

            //display the label that display's the answer
            this.lblTotalCost.Show();

        }

        private void picNoFries_Click(object sender, EventArgs e)
        {
            //assigne the cost of no fries
            frieBoxSizeCost = 0.00;

            //hide frie box size items
            this.lblSmallFries.Hide();
            this.lblLargeFries.Hide();
            this.lblNoFries.Hide();
            this.lblFries.Hide();
            this.picSmallFries.Hide();
            this.picLargeFries.Hide();
            this.picNoFries.Hide();

            //show calculation items
            this.lstTotalCost.Show();
            this.lblRecipt.Show();

            //declare local variables
            double totalCost;

            //clear the listbox
            this.lstTotalCost.Items.Clear();

            //calculate the total price
            totalCost = (pizzaSizeCost + pizzaToppingCost + frieBoxSizeCost) * taxes;

            //dipslay the prices in list box
            this.lstTotalCost.Items.Add("$ " + pizzaSizeCost + "  for the pizza size");
            this.lstTotalCost.Items.Add("+   $ " + pizzaToppingCost + "  for the pizza topping(s)");
            this.lstTotalCost.Items.Add("+   $ " + frieBoxSizeCost + "  for the size of the fries");
            this.lstTotalCost.Items.Add("+   " + taxPercentage + " % taxes");

            //display the total in a label
            this.lblTotalCost.Text = Convert.ToString(Math.Round(totalCost, 2)) + "  is your total";

            //display the label that display's the answer
            this.lblTotalCost.Show();
        }

        private void lblTwoToppings_Click(object sender, EventArgs e)
        {
        }
    }
}
