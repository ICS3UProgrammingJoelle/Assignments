namespace AreaVolumeJoelle
{
    partial class frmAreaVolume
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWhatShapeStatement = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTrapezoid = new System.Windows.Forms.Label();
            this.lblSphere = new System.Windows.Forms.Label();
            this.lblCylinder = new System.Windows.Forms.Label();
            this.lblTriangle = new System.Windows.Forms.Label();
            this.lblSqureBasedTriangle = new System.Windows.Forms.Label();
            this.lblPyramid = new System.Windows.Forms.Label();
            this.lblCube = new System.Windows.Forms.Label();
            this.lblCone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWhatShapeStatement
            // 
            this.lblWhatShapeStatement.AutoSize = true;
            this.lblWhatShapeStatement.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatShapeStatement.Location = new System.Drawing.Point(50, 70);
            this.lblWhatShapeStatement.Name = "lblWhatShapeStatement";
            this.lblWhatShapeStatement.Size = new System.Drawing.Size(369, 19);
            this.lblWhatShapeStatement.TabIndex = 0;
            this.lblWhatShapeStatement.Text = "What shape do you want to calculate?";
            this.lblWhatShapeStatement.Click += new System.EventHandler(this.Label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(462, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // lblTrapezoid
            // 
            this.lblTrapezoid.AutoSize = true;
            this.lblTrapezoid.Location = new System.Drawing.Point(85, 120);
            this.lblTrapezoid.Name = "lblTrapezoid";
            this.lblTrapezoid.Size = new System.Drawing.Size(72, 13);
            this.lblTrapezoid.TabIndex = 2;
            this.lblTrapezoid.Text = "1 = Trapezoid";
            // 
            // lblSphere
            // 
            this.lblSphere.AutoSize = true;
            this.lblSphere.Location = new System.Drawing.Point(85, 145);
            this.lblSphere.Name = "lblSphere";
            this.lblSphere.Size = new System.Drawing.Size(59, 13);
            this.lblSphere.TabIndex = 3;
            this.lblSphere.Text = "2 = Sphere";
            // 
            // lblCylinder
            // 
            this.lblCylinder.AutoSize = true;
            this.lblCylinder.Location = new System.Drawing.Point(85, 176);
            this.lblCylinder.Name = "lblCylinder";
            this.lblCylinder.Size = new System.Drawing.Size(62, 13);
            this.lblCylinder.TabIndex = 4;
            this.lblCylinder.Text = "3 = Cylinder";
            // 
            // lblTriangle
            // 
            this.lblTriangle.AutoSize = true;
            this.lblTriangle.Location = new System.Drawing.Point(85, 206);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(63, 13);
            this.lblTriangle.TabIndex = 5;
            this.lblTriangle.Text = "4 = Triangle";
            // 
            // lblSqureBasedTriangle
            // 
            this.lblSqureBasedTriangle.AutoSize = true;
            this.lblSqureBasedTriangle.Location = new System.Drawing.Point(85, 237);
            this.lblSqureBasedTriangle.Name = "lblSqureBasedTriangle";
            this.lblSqureBasedTriangle.Size = new System.Drawing.Size(127, 13);
            this.lblSqureBasedTriangle.TabIndex = 6;
            this.lblSqureBasedTriangle.Text = "5 = Squre Based Triangle";
            // 
            // lblPyramid
            // 
            this.lblPyramid.AutoSize = true;
            this.lblPyramid.Location = new System.Drawing.Point(85, 270);
            this.lblPyramid.Name = "lblPyramid";
            this.lblPyramid.Size = new System.Drawing.Size(62, 13);
            this.lblPyramid.TabIndex = 7;
            this.lblPyramid.Text = "6 = Pyramid";
            // 
            // lblCube
            // 
            this.lblCube.AutoSize = true;
            this.lblCube.Location = new System.Drawing.Point(85, 299);
            this.lblCube.Name = "lblCube";
            this.lblCube.Size = new System.Drawing.Size(50, 13);
            this.lblCube.TabIndex = 8;
            this.lblCube.Text = "7 = Cube";
            this.lblCube.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblCone
            // 
            this.lblCone.AutoSize = true;
            this.lblCone.Location = new System.Drawing.Point(85, 333);
            this.lblCone.Name = "lblCone";
            this.lblCone.Size = new System.Drawing.Size(50, 13);
            this.lblCone.TabIndex = 9;
            this.lblCone.Text = "8 = Cone";
            // 
            // frmAreaVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCone);
            this.Controls.Add(this.lblCube);
            this.Controls.Add(this.lblPyramid);
            this.Controls.Add(this.lblSqureBasedTriangle);
            this.Controls.Add(this.lblTriangle);
            this.Controls.Add(this.lblCylinder);
            this.Controls.Add(this.lblSphere);
            this.Controls.Add(this.lblTrapezoid);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblWhatShapeStatement);
            this.Name = "frmAreaVolume";
            this.Text = "Area and Volume   By: Joelle Ishimwe";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhatShapeStatement;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblTrapezoid;
        private System.Windows.Forms.Label lblSphere;
        private System.Windows.Forms.Label lblCylinder;
        private System.Windows.Forms.Label lblTriangle;
        private System.Windows.Forms.Label lblSqureBasedTriangle;
        private System.Windows.Forms.Label lblPyramid;
        private System.Windows.Forms.Label lblCube;
        private System.Windows.Forms.Label lblCone;
    }
}

