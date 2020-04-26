/*
 * Created by: Joelle Ishimwe
 * Created on: 21-April-2020
 * Created for: ICS3U Programming
 * Assignment #5b - Simplified 21
 * This program simulates a simplified version of the game 21 against the computer
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

namespace Simplified_21
{
    public partial class frmSimplified21 : Form
    {       
            //declare variables
            int usersCards, usersCards2, usersCards3, usersCards4, usersTotalCards;
            int dealersCards, dealersCards2, dealersTotalCards;


        //set the random genrator
        Random aRandomNumber = new Random();


        public frmSimplified21()
        {
            InitializeComponent();
    
            //hide items
            this.btnHit.Hide();
            this.btnHit2.Hide();
            this.btnStay.Hide();
            this.picDealersCard1.Hide();
            this.picDealersCard2.Hide();
            this.picUsersCard1.Hide();
            this.picUsersCard2.Hide();
            this.picUsersCard3.Hide();
            this.picUsersCard4.Hide();
            this.lblAce.Hide();
            this.radOne.Hide();
            this.radEleven.Hide();
            this.lblUsersValue.Hide();
            this.lblDealersValue.Hide();
            this.lblComment.Hide();

            //assign random numbers to each card for the user
            usersCards = aRandomNumber.Next(1, 10 + 1);
            usersCards2 = aRandomNumber.Next(1, 10 + 1);
            usersCards3 = aRandomNumber.Next(1, 10 + 1);
            usersCards4 = aRandomNumber.Next(1, 10 + 1);
        
            //assign random numbers to each card for the dealer
            dealersCards = aRandomNumber.Next(1, 10 + 1);
            dealersCards2 = aRandomNumber.Next(1, 10 + 1);

        }

        private void radOne_CheckedChanged(object sender, EventArgs e)
        {
            //if statement that user's decison
            if (usersCards == 1)
            {
                //sets appropriate ace value
                usersCards = 1;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            if (usersCards2 == 1)
            {
                //sets appropriate ace value
                usersCards2 = 1;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            if (usersCards3 == 1)
            {
                //sets appropriate ace value
                usersCards3 = 1;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            if (usersCards4 == 1)
            {
                //sets appropriate ace value
                usersCards4 = 1;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            //calculate the user's cards
            usersTotalCards = usersCards + usersCards2 + usersCards3 + usersCards4;

            //display user's cards   and card value  
            lblUsersValue.Text = "Player's value is  " + usersTotalCards;
        }

        private void radEleven_CheckedChanged(object sender, EventArgs e)
        {
            //if statement that user's decison
            if (usersCards == 1)
            {
                //sets appropriate ace value
                usersCards = 11;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            if (usersCards2 == 1)
            {
                //sets appropriate ace value
                usersCards2 = 11;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            if (usersCards3 == 1)
            {
                //sets appropriate ace value
                usersCards3 = 11;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            if (usersCards4 == 1)
            {
                //sets appropriate ace value
                usersCards4 = 11;

                //hide items need for the ace
                this.lblAce.Hide();
                this.radOne.Hide();
                this.radEleven.Hide();
            }
            //calculate the user's cards
            usersTotalCards = usersCards + usersCards2 + usersCards3 + usersCards4;

            //display user's cards   and card value  
            lblUsersValue.Text = "Player's value is  " + usersTotalCards;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //hide items
            this.btnNewGame.Hide();

            //show items
            this.btnHit.Show();
            this.btnStay.Show();
            this.picUsersCard1.Show();
            this.picUsersCard2.Show();
            this.lblUsersValue.Show();

            //assign a number from the random genrator to the first card image for the user
            if (usersCards == 1)
            {
                this.picUsersCard1.Image = Properties.Resources.cardAce;

                //show items need for the ace
                this.lblAce.Show();
                this.radOne.Show();
                this.radEleven.Show();
            }
            else if (usersCards == 2)
            {
                this.picUsersCard1.Image = Properties.Resources.card2;
                usersCards = 2;
            }
            else if (usersCards == 3)
            {
                this.picUsersCard1.Image = Properties.Resources.card3;
                usersCards = 3;
            }
            else if (usersCards == 4)
            {
                this.picUsersCard1.Image = Properties.Resources.card4;
                usersCards = 4;

            }
            else if (usersCards == 5)
            {
                this.picUsersCard1.Image = Properties.Resources.card5;
                usersCards = 5;

            }
            else if (usersCards == 6)
            {
                this.picUsersCard1.Image = Properties.Resources.card6;
                usersCards = 6;

            }
            else if (usersCards == 7)
            {
                this.picUsersCard1.Image = Properties.Resources.card7;
                usersCards = 7;

            }
            else if (usersCards == 8)
            {
                this.picUsersCard1.Image = Properties.Resources.card8;
                usersCards = 8;

            }
            else if (usersCards == 9)
            {
                this.picUsersCard1.Image = Properties.Resources.card9;
                usersCards = 9;

            }
            else 
            {
                this.picUsersCard1.Image = Properties.Resources.card10;
                usersCards = 10;

            }

            //assign a number from the random genrator to the second card image for the user
            if (usersCards2 == 1)
            {
                this.picUsersCard2.Image = Properties.Resources.cardAce;

                //show items need for the ace
                this.lblAce.Show();
                this.radOne.Show();
                this.radEleven.Show();
            }
            else if (usersCards2 == 2)
            {
                this.picUsersCard2.Image = Properties.Resources.card2;
                usersCards2 = 2;
            }
            else if (usersCards2 == 3)
            {
                this.picUsersCard2.Image = Properties.Resources.card3;
                usersCards2 = 3;

            }
            else if (usersCards2 == 4)
            {
                this.picUsersCard2.Image = Properties.Resources.card4;
                usersCards2 = 4;

            }
            else if (usersCards2 == 5)
            {
                this.picUsersCard2.Image = Properties.Resources.card5;
                usersCards2 = 5;

            }
            else if (usersCards2 == 6)
            {
                this.picUsersCard2.Image = Properties.Resources.card6;
                usersCards2 = 6;

            }
            else if (usersCards2 == 7)
            {
                this.picUsersCard2.Image = Properties.Resources.card7;
                usersCards2 = 7;

            }
            else if (usersCards2 == 8)
            {
                this.picUsersCard2.Image = Properties.Resources.card8;
                usersCards2 = 8;

            }
            else if (usersCards2 == 9)
            {
                this.picUsersCard2.Image = Properties.Resources.card9;
                usersCards2 = 9;

            }
            else
            {
                this.picUsersCard2.Image = Properties.Resources.card10;
                usersCards2 = 10;

            }

            //calculate the user's cards
            usersTotalCards = usersCards + usersCards2;

            //display user's cards   and card value  
            lblUsersValue.Text = "Player's value is  " + usersTotalCards;



            //assign a number from the random genrator to the first card image for the user
            if (dealersCards == 1)
            {
                picDealersCard1.Image = Properties.Resources.cardAce;

                //set a random ace value genarator
                Random ace = new Random();

                //set the dealer's cards to euqal the value the generator choose
                dealersCards = ace.Next(1, 11);
            }

            else if (dealersCards == 2)
            {
                picDealersCard1.Image = Properties.Resources.card2;
                dealersCards = 2;
            }
            else if (dealersCards == 3)
            {
                picDealersCard1.Image = Properties.Resources.card3;
                dealersCards = 3;
            }
            else if (dealersCards == 4)
            {
                picDealersCard1.Image = Properties.Resources.card4;
                dealersCards = 4;
            }
            else if (dealersCards == 5)
            {
                picDealersCard1.Image = Properties.Resources.card5;
                dealersCards = 5;
            }
            else if (dealersCards == 6)
            {
                picDealersCard1.Image = Properties.Resources.card6;
                dealersCards = 6;
            }
            else if (dealersCards == 7)
            {
                picDealersCard1.Image = Properties.Resources.card7;
                dealersCards = 7;
            }
            else if (dealersCards == 8)
            {
                picDealersCard1.Image = Properties.Resources.card8;
                dealersCards = 8;
            }
            else if (dealersCards == 9)
            {
                picDealersCard1.Image = Properties.Resources.card9;
                dealersCards = 9;
            }
            else
            {
                picDealersCard1.Image = Properties.Resources.card10;
                dealersCards = 10;
            }

            //assign a number from the random genrator to the first card image for the user
            if (dealersCards2 == 1)
            {
                picDealersCard2.Image = Properties.Resources.cardAce;

                //set a random ace value genarator
                Random ace = new Random();

                //set the dealer's cards to euqal the value the generator choose
                dealersCards = ace.Next(1, 11);
            }

            else if (dealersCards2 == 2)
            {
                picDealersCard2.Image = Properties.Resources.card2;
                dealersCards2 = 2;
            }
            else if (dealersCards2 == 3)
            {
                picDealersCard2.Image = Properties.Resources.card3;
                dealersCards2 = 3;
            }
            else if (dealersCards2 == 4)
            {
                picDealersCard2.Image = Properties.Resources.card4;
                dealersCards2 = 4;
            }
            else if (dealersCards2 == 5)
            {
                picDealersCard2.Image = Properties.Resources.card5;
                dealersCards2 = 5;
            }
            else if (dealersCards2 == 6)
            {
                picDealersCard2.Image = Properties.Resources.card6;
                dealersCards2 = 6;
            }
            else if (dealersCards2 == 7)
            {
                picDealersCard2.Image = Properties.Resources.card7;
                dealersCards2 = 7;
            }
            else if (dealersCards2 == 8)
            {
                picDealersCard2.Image = Properties.Resources.card8;
                dealersCards2 = 8;
            }
            else if (dealersCards2 == 9)
            {
                picDealersCard2.Image = Properties.Resources.card9;
                dealersCards2 = 9;
            }
            else
            {
                picDealersCard2.Image = Properties.Resources.card10;
                dealersCards = 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hide items
            this.btnHit.Hide();
            this.lblAce.Hide();
            this.radOne.Hide();
            this.radEleven.Hide();

            //show items
            this.btnHit2.Show();
            this.picUsersCard3.Show();

            //assign a number from the random genrator to the first card image for the user
            if (usersCards3 == 1)
            {
                this.picUsersCard3.Image = Properties.Resources.cardAce;

                //show items need for the ace
                this.lblAce.Show();
                this.radOne.Show();
                this.radEleven.Show();

            }
            else if (usersCards3 == 2)
            {
                this.picUsersCard3.Image = Properties.Resources.card2;
                usersCards3 = 2;
            }
            else if (usersCards3 == 3)
            {
                this.picUsersCard3.Image = Properties.Resources.card3;
                usersCards3 = 3;
            }
            else if (usersCards3 == 4)
            {
                this.picUsersCard3.Image = Properties.Resources.card4;
                usersCards3 = 4;

            }
            else if (usersCards3 == 5)
            {
                this.picUsersCard3.Image = Properties.Resources.card5;
                usersCards3 = 5;

            }
            else if (usersCards3 == 6)
            {
                this.picUsersCard3.Image = Properties.Resources.card6;
                usersCards3 = 6;

            }
            else if (usersCards3 == 7)
            {
                this.picUsersCard3.Image = Properties.Resources.card7;
                usersCards3 = 7;

            }
            else if (usersCards3 == 8)
            {
                this.picUsersCard3.Image = Properties.Resources.card8;
                usersCards3 = 8;

            }
            else if (usersCards3 == 9)
            {
                this.picUsersCard3.Image = Properties.Resources.card9;
                usersCards3 = 9;

            }
            else
            {
                this.picUsersCard3.Image = Properties.Resources.card10;
                usersCards3 = 10;
            }

            //calculate the user's cards
            usersTotalCards = usersCards + usersCards2 + usersCards3;

            //display user's cards
            lblUsersValue.Text = "Player's value is  " + usersTotalCards;
        }

        private void btnHit2_Click(object sender, EventArgs e)
        {
            //hide items
            this.btnHit2.Hide();
            this.lblAce.Hide();
            this.radOne.Hide();
            this.radEleven.Hide();

            //show items
            this.picUsersCard4.Show();

            //assign a number from the random genrator to the first card image for the user
            if (usersCards4 == 1)
            {
                this.picUsersCard4.Image = Properties.Resources.cardAce;

                //show items need for the ace
                this.lblAce.Show();
                this.radOne.Show();
                this.radEleven.Show();

            }
            else if (usersCards4 == 2)
            {
                this.picUsersCard4.Image = Properties.Resources.card2;
                usersCards4 = 2;
            }
            else if (usersCards4 == 3)
            {
                this.picUsersCard4.Image = Properties.Resources.card3;
                usersCards4 = 3;
            }
            else if (usersCards4 == 4)
            {
                this.picUsersCard4.Image = Properties.Resources.card4;
                usersCards4 = 4;

            }
            else if (usersCards4 == 5)
            {
                this.picUsersCard4.Image = Properties.Resources.card5;
                usersCards4 = 5;

            }
            else if (usersCards4 == 6)
            {
                this.picUsersCard4.Image = Properties.Resources.card6;
                usersCards4 = 6;

            }
            else if (usersCards4 == 7)
            {
                this.picUsersCard4.Image = Properties.Resources.card7;
                usersCards4 = 7;

            }
            else if (usersCards4 == 8)
            {
                this.picUsersCard4.Image = Properties.Resources.card8;
                usersCards4 = 8;

            }
            else if (usersCards4 == 9)
            {
                this.picUsersCard4.Image = Properties.Resources.card9;
                usersCards4 = 9;

            }
            else
            {
                this.picUsersCard4.Image = Properties.Resources.card10;
                usersCards4 = 10;
            }

            //calculate the user's cards
            usersTotalCards = usersCards + usersCards2 + usersCards3 + usersCards4;

            //display user's cards
            lblUsersValue.Text = "Player's value is  " + usersTotalCards;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //hide items
            this.btnHit.Hide();
            this.btnHit2.Hide();
            this.btnStay.Hide();

            //display the dealer's hand of cards and other items
            this.picDealersCard1.Show();
            this.picDealersCard2.Show();
            this.lblDealersValue.Show();
            this.lblComment.Show();

            //calculate the dealer's cards
            dealersTotalCards = dealersCards + dealersCards2;

            //display dealer's label with the value of his hand of cards
            lblDealersValue.Text = "Dealer's card's value " + dealersTotalCards;

            //if statement that evealuates who = 21, >21 or < 21. it also compares
            //both the dealer's total with the user's total
            if (usersTotalCards > 21)
            {
                //display who won
                lblComment.Text = "Dealer won, you're busted :/";
                
                //play sound

            }

            else if (usersTotalCards == 21)
            {
                if (dealersTotalCards > 21)
                {
                    //display who won
                    lblComment.Text = "Dealer is a bust, YOU WON!";

                    //play sound

                }
                else if (dealersTotalCards == 21)
                {
                    //display who won
                    lblComment.Text = "You've both hit the jackpot. It's a tie";

                    //play sound

                }
                else
                {
                    //display who won
                    lblComment.Text = "YOU WON!";

                    //play sound

                }
            }
            else
            {
                if (usersTotalCards > dealersTotalCards)
                {
                    //display who won
                    lblComment.Text = "YOU WON!";

                    //play sound

                }
                else if (usersTotalCards ==dealersTotalCards)
                {
                    //display who won
                    lblComment.Text = "It's a tie";

                    //play sound

                }
                else
                {
                    //display who won
                    lblComment.Text = "Dealer's closer to 21. You lost :/";

                    //play sound

                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restart the game
            Application.Restart();
        }
    }
}
