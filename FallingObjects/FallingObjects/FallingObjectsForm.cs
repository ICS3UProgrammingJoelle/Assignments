/*
 * Created by: Joelle Ishimwe
 * Created on: 18-Feb.-2020
 * Created for: ICS3U Programming
 * Assignment #2 - Falling Objects
 * This program will calculate the height of the falling 
 * object, according to the time, given by the user.
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

namespace FallingObjects
{
    public partial class FallingObjectsForm : Form
    {
        public FallingObjectsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //declare the local variable
            double time, answer;

            //declare constants
            const double GRAVITY = 9.81;

            //convert the time inserted in the textbot to a double
            time = double.Parse(txtTime.Text);

            //calculate height of the object above the ground
            answer = 100 - 0.5 * GRAVITY * Math.Pow(time, 2);

            // show calculated height (rounded off to 2 decimal places), according to the time given
            this.lblAnswer.Show();
            this.lblAnswer.Text = "The height of the object is:  " + Convert.ToString(Math.Round(answer, 2));
            this.lblAnswer.Text = "The height of the object is:  " + Convert.ToString(Math.Round(answer, 2)) + " meters";

            //display a text if the height is lower then 0
            if (answer < 0)
                this.lblAnswer.Text = "The object has already hit the ground, Try again.";

            //display text if the time given is lower then 0 (negative time)
            if (time < 0)
                this.lblAnswer.Text = "There cannot be a negative time";

        }

        private void TxtTime_TextChanged(object sender, EventArgs e)
        {
            //only allow numbers and periods (dots) to be inserted

        }
     }
}
