/*
 * Created by: Joelle Ishimwe
 * Created on: 11-03-2020
 * Created for: ICS3U Programming
 * Assignment #4b - Area and Volume Assignement #4b
 * This program will calculate the are or volume of a shape. 
 * The user choses the shape and the dimensions. 
 * The program calculate the are or volume, according 
 * to what the user choses.
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

namespace AreaVolumeJoelle
{
    public partial class frmAreaVolume : Form
    {
        public frmAreaVolume()
        {
            InitializeComponent();

            //hide the items that are not needed
            lblDimension1.Hide();
            lblDimension2.Hide();
            lblDimension3.Hide();
            txtDimension1.Hide();
            txtDimension2.Hide();
            txtDimension3.Hide();
            btnCalculateTrapezoid.Hide();
            lblShapeName.Hide();
            lblAnswerStatement.Hide();
            lblAnswer.Hide();
            
            //hide the calculate buttons
            btnCalculateTrapezoid.Hide();
            btnCalculateSphere.Hide();
            btnCalculateCylinder.Hide();
            btnCalculateTriangle.Hide();
            btnCalculateSquareBasedPyramid.Hide();
            btnCalculateCube.Hide();
            btnCalculateCone.Hide();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Label5_Click(object sender, EventArgs e)
        {
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void LblDimension1_Click(object sender, EventArgs e)
        {
        }

        private void BtnChosenShape_Click(object sender, EventArgs e)
        {
            //hide some the name of shapes labels
            lblTrapezoid.Hide();
            lblSphere.Hide();
            lblCylinder.Hide();
            lblTriangle.Hide();
            lblSqureBasedPyramid.Hide();
            lblCube.Hide();
            lblCone.Hide();
            
            //hide the other items
            lblWhatShapeStatement.Hide();
            numChosenShape.Hide();
            
            //hide labels that give the user the calculation answers 
            lblAnswerStatement.Hide();

            //declare the variables
            int shape;

            //convert the string into a intger
            shape = Convert.ToInt32(numChosenShape.Value);

            //statement that determinine what happens when a shape is chosen\
            //Trapezoid is chosen
            if (shape == 1)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes and the calculate button
                lblDimension1.Show();
                lblDimension2.Show();
                lblDimension3.Show();
                txtDimension1.Show();
                txtDimension2.Show();
                txtDimension3.Show();
                btnCalculateTrapezoid.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "How long is the top? (in centimeters)";
                this.lblDimension2.Text = "How long is the bottom? (in centimeters)";
                this.lblDimension3.Text = "What is the height?";
                this.lblShapeName.Text = "Trapezoid";
            }

            //Sphere is chosen
            else if (shape == 2)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes and the calculate button
                lblDimension1.Show();
                txtDimension1.Show();
                btnCalculateSphere.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "What is the radius? (in centimeters)";
                this.lblShapeName.Text = "Sphere";

            }

            //Cylinder is chosen
            else if (shape == 3)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes, the calculate button and the answer statement
                lblDimension1.Show();
                lblDimension2.Show();
                txtDimension1.Show();
                txtDimension2.Show();
                btnCalculateCylinder.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "What is the height? (in centimeters)";
                this.lblDimension2.Text = "What is the radius (in cemtimeters)";
                this.lblShapeName.Text = "Cylinder";

            }

            //Triangle is chosen
            else if (shape == 4)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes, the calculate button and the answer statement
                lblDimension1.Show();
                lblDimension2.Show();
                txtDimension1.Show();
                txtDimension2.Show();
                btnCalculateTriangle.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "What is the length of the base? (in centimeters)";
                this.lblDimension2.Text = "What is the length of the height? (in cemtimeters)";
                this.lblShapeName.Text = "Triangle";

            }

            //Square Based Pyramid is chosen
            if (shape == 5)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes and the calculate button
                lblDimension1.Show();
                lblDimension2.Show();
                lblDimension3.Show();
                txtDimension1.Show();
                txtDimension2.Show();
                txtDimension3.Show();
                btnCalculateSquareBasedPyramid.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "What is the length? (in centimeters)";
                this.lblDimension2.Text = "What is the length of the width? (in centimeters)";
                this.lblDimension3.Text = "What is the length of the height? (in cemtimeters)";
                this.lblShapeName.Text = "Square Based Pyramid";


            }

            //Cube is chosen
            if (shape == 6)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes and the calculate button
                lblDimension1.Show();
                lblDimension2.Show();
                lblDimension3.Show();
                txtDimension1.Show();
                txtDimension2.Show();
                txtDimension3.Show();
                btnCalculateCube.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "What is the length? (in centimeters)";
                this.lblDimension2.Text = "What is the length of the width? (in centimeters)";
                this.lblDimension3.Text = "What is the length of the height? (in cemtimeters)";
                this.lblShapeName.Text = "Cube";


            }

            //Cone is chosen
            else if (shape == 7)
            {
                //hide the Enter button
                btnChosenShape.Hide();

                //display the name of the chosen shape, the labels of the demensions, with the textboxes and the calculate button
                lblDimension1.Show();
                lblDimension2.Show();
                txtDimension1.Show();
                txtDimension2.Show();
                btnCalculateCone.Show();
                lblShapeName.Show();
                lblAnswerStatement.Show();


                //Have the labels ask the appropriate questions and the name of the shape say the correct name
                this.lblDimension1.Text = "What is the radius? (in centimeters)";
                this.lblDimension2.Text = "what is the height? (in centimeters)";
                this.lblShapeName.Text = "Cone";

            }


        }
        private void BtnCalculateTrapezoid_Click(object sender, EventArgs e)
        {
        }
        private void FrmAreaVolume_Load(object sender, EventArgs e)
        {
        }

        private void BtnCalculateTrapezoid_Click_1(object sender, EventArgs e)
        {
            //declare variables
            double area, topLength, bottomLength, height;

            //convert from a string into a double
            topLength = double.Parse(txtDimension1.Text);
            bottomLength = double.Parse(txtDimension2.Text);
            height = double.Parse(txtDimension3.Text);

            //the formula of a trapezoid
            area = ((topLength + bottomLength) * height) / 2;

            //convert from a double to a string
            this.lblAnswer.Text = Convert.ToString(area) + " cm²";

            //display the answer
            lblAnswer.Show();
        }

        private void BtnCalculateSphere_Click(object sender, EventArgs e)
        {
            //declare variables
            double volume, radius;

            // state constants
            const double PI = 3.14;

            //convert from a string into a double
            radius = double.Parse(txtDimension1.Text);

            //the formula of a sphere
            volume = 0.75 * PI * (radius * radius);

            //convert from a double to a string
            this.lblAnswer.Text = Convert.ToString(volume) + " cm";

            //display the answer
            lblAnswer.Show();
        }

        private void BtnCalculateCylinder_Click(object sender, EventArgs e)
        {
            //declare variables
            double area, radius, height;

            // state constants
            const double PI = 3.14;

            //convert from a string into a double
            radius = double.Parse(txtDimension1.Text);
            height = double.Parse(txtDimension2.Text);

            //the formula of a cylinder
            area = (PI * (radius * radius)) * height;

            //convert from a double to a string
            this.lblAnswer.Text = Convert.ToString(area) + " cm²";

            //display the answer
            lblAnswer.Show();
        }

        private void BtnCalculateTriangle_Click(object sender, EventArgs e)
        {
            //declare variables
            double volume, basee, height;

            //convert from a string into a double
            basee = double.Parse(txtDimension1.Text);
            height = double.Parse(txtDimension2.Text);

            //the formula of a triangle
            volume = 0.5 * basee * height;

            //convert from a double to a string
            this.lblAnswer.Text = Convert.ToString(volume) + " cm";

            //display the answer
            lblAnswer.Show();
        }

        private void BtnCalculateSquareBasedPyramid_Click(object sender, EventArgs e)
        {
            //declare variables
            double area, length, width, height;

            //convert from a string into a double
            length = double.Parse(txtDimension1.Text);
            width = double.Parse(txtDimension2.Text);
            height = double.Parse(txtDimension3.Text);

            //the formula of a square based pyramid
            area = length * width * height;

            //convert from a double to a string
            this.lblAnswer.Text = Convert.ToString(area) + " cm²";

            //display the answer
            lblAnswer.Show();
        }

        private void BtnCalculateCube_Click(object sender, EventArgs e)
        {
            //declare variables
            double area, length, width, height;

            //convert from a string into a double
            length = double.Parse(txtDimension1.Text);
            width = double.Parse(txtDimension2.Text);
            height = double.Parse(txtDimension3.Text);

            //the formula of a square based pyramid
            area = (length * width * height) / 3;

            //convert from a double to a cube
            this.lblAnswer.Text = Convert.ToString(area) + " cm²";

            //display the answer
            lblAnswer.Show();
        }

        private void BtnCalculateCone_Click(object sender, EventArgs e)
        {
            //declare variables
            double area, radius, height;

            //declare constants
            const double PI = 3.14;

            //convert from a string into a double
            radius = double.Parse(txtDimension1.Text);
            height = double.Parse(txtDimension2.Text);

            //the formula of a cone
            area = (PI * (radius * radius) * height) / 3 ;

            //convert from a double to a string
            this.lblAnswer.Text = Convert.ToString(area) + " cm²";

            //display the answer
            lblAnswer.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit the program
            this.Close();
        }
    }
}
