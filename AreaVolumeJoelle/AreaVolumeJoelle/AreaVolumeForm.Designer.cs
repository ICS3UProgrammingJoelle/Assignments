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
            this.numChosenShape = new System.Windows.Forms.NumericUpDown();
            this.lblTrapezoid = new System.Windows.Forms.Label();
            this.lblSphere = new System.Windows.Forms.Label();
            this.lblCylinder = new System.Windows.Forms.Label();
            this.lblTriangle = new System.Windows.Forms.Label();
            this.lblSqureBasedPyramid = new System.Windows.Forms.Label();
            this.lblCube = new System.Windows.Forms.Label();
            this.lblCone = new System.Windows.Forms.Label();
            this.lblDimension1 = new System.Windows.Forms.Label();
            this.lblDimension2 = new System.Windows.Forms.Label();
            this.lblDimension3 = new System.Windows.Forms.Label();
            this.txtDimension1 = new System.Windows.Forms.TextBox();
            this.txtDimension3 = new System.Windows.Forms.TextBox();
            this.txtDimension2 = new System.Windows.Forms.TextBox();
            this.btnChosenShape = new System.Windows.Forms.Button();
            this.lblShapeName = new System.Windows.Forms.Label();
            this.lblAnswerStatement = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculateSphere = new System.Windows.Forms.Button();
            this.btnCalculateCone = new System.Windows.Forms.Button();
            this.btnCalculateCube = new System.Windows.Forms.Button();
            this.btnCalculateSquareBasedPyramid = new System.Windows.Forms.Button();
            this.btnCalculateTriangle = new System.Windows.Forms.Button();
            this.btnCalculateCylinder = new System.Windows.Forms.Button();
            this.btnCalculateTrapezoid = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numChosenShape)).BeginInit();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWhatShapeStatement
            // 
            this.lblWhatShapeStatement.AutoSize = true;
            this.lblWhatShapeStatement.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatShapeStatement.Location = new System.Drawing.Point(75, 92);
            this.lblWhatShapeStatement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhatShapeStatement.Name = "lblWhatShapeStatement";
            this.lblWhatShapeStatement.Size = new System.Drawing.Size(369, 19);
            this.lblWhatShapeStatement.TabIndex = 0;
            this.lblWhatShapeStatement.Text = "What shape do you want to calculate?";
            this.lblWhatShapeStatement.Click += new System.EventHandler(this.Label1_Click);
            // 
            // numChosenShape
            // 
            this.numChosenShape.Location = new System.Drawing.Point(693, 92);
            this.numChosenShape.Margin = new System.Windows.Forms.Padding(4);
            this.numChosenShape.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numChosenShape.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChosenShape.Name = "numChosenShape";
            this.numChosenShape.Size = new System.Drawing.Size(180, 25);
            this.numChosenShape.TabIndex = 1;
            this.numChosenShape.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChosenShape.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // lblTrapezoid
            // 
            this.lblTrapezoid.AutoSize = true;
            this.lblTrapezoid.Location = new System.Drawing.Point(94, 156);
            this.lblTrapezoid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrapezoid.Name = "lblTrapezoid";
            this.lblTrapezoid.Size = new System.Drawing.Size(98, 17);
            this.lblTrapezoid.TabIndex = 2;
            this.lblTrapezoid.Text = "1 = Trapezoid";
            // 
            // lblSphere
            // 
            this.lblSphere.AutoSize = true;
            this.lblSphere.Location = new System.Drawing.Point(94, 192);
            this.lblSphere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSphere.Name = "lblSphere";
            this.lblSphere.Size = new System.Drawing.Size(80, 17);
            this.lblSphere.TabIndex = 3;
            this.lblSphere.Text = "2 = Sphere";
            // 
            // lblCylinder
            // 
            this.lblCylinder.AutoSize = true;
            this.lblCylinder.Location = new System.Drawing.Point(94, 231);
            this.lblCylinder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCylinder.Name = "lblCylinder";
            this.lblCylinder.Size = new System.Drawing.Size(87, 17);
            this.lblCylinder.TabIndex = 4;
            this.lblCylinder.Text = "3 = Cylinder";
            // 
            // lblTriangle
            // 
            this.lblTriangle.AutoSize = true;
            this.lblTriangle.Location = new System.Drawing.Point(94, 268);
            this.lblTriangle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriangle.Name = "lblTriangle";
            this.lblTriangle.Size = new System.Drawing.Size(85, 17);
            this.lblTriangle.TabIndex = 5;
            this.lblTriangle.Text = "4 = Triangle";
            // 
            // lblSqureBasedPyramid
            // 
            this.lblSqureBasedPyramid.AutoSize = true;
            this.lblSqureBasedPyramid.Location = new System.Drawing.Point(94, 305);
            this.lblSqureBasedPyramid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSqureBasedPyramid.Name = "lblSqureBasedPyramid";
            this.lblSqureBasedPyramid.Size = new System.Drawing.Size(176, 17);
            this.lblSqureBasedPyramid.TabIndex = 6;
            this.lblSqureBasedPyramid.Text = "5 = Squre Based Pyramid";
            // 
            // lblCube
            // 
            this.lblCube.AutoSize = true;
            this.lblCube.Location = new System.Drawing.Point(94, 337);
            this.lblCube.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCube.Name = "lblCube";
            this.lblCube.Size = new System.Drawing.Size(68, 17);
            this.lblCube.TabIndex = 8;
            this.lblCube.Text = "6 = Cube";
            this.lblCube.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lblCone
            // 
            this.lblCone.AutoSize = true;
            this.lblCone.Location = new System.Drawing.Point(94, 369);
            this.lblCone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCone.Name = "lblCone";
            this.lblCone.Size = new System.Drawing.Size(68, 17);
            this.lblCone.TabIndex = 9;
            this.lblCone.Text = "7 = Cone";
            // 
            // lblDimension1
            // 
            this.lblDimension1.AutoSize = true;
            this.lblDimension1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension1.Location = new System.Drawing.Point(141, 150);
            this.lblDimension1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimension1.Name = "lblDimension1";
            this.lblDimension1.Size = new System.Drawing.Size(179, 19);
            this.lblDimension1.TabIndex = 10;
            this.lblDimension1.Text = "What is the legnth (in cm)";
            this.lblDimension1.Click += new System.EventHandler(this.LblDimension1_Click);
            // 
            // lblDimension2
            // 
            this.lblDimension2.AutoSize = true;
            this.lblDimension2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension2.Location = new System.Drawing.Point(141, 209);
            this.lblDimension2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimension2.Name = "lblDimension2";
            this.lblDimension2.Size = new System.Drawing.Size(174, 19);
            this.lblDimension2.TabIndex = 11;
            this.lblDimension2.Text = "What is the width (in cm)";
            // 
            // lblDimension3
            // 
            this.lblDimension3.AutoSize = true;
            this.lblDimension3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension3.Location = new System.Drawing.Point(142, 265);
            this.lblDimension3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimension3.Name = "lblDimension3";
            this.lblDimension3.Size = new System.Drawing.Size(181, 16);
            this.lblDimension3.TabIndex = 13;
            this.lblDimension3.Text = "What is the radius (in cm)";
            // 
            // txtDimension1
            // 
            this.txtDimension1.Location = new System.Drawing.Point(627, 150);
            this.txtDimension1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimension1.Name = "txtDimension1";
            this.txtDimension1.Size = new System.Drawing.Size(148, 25);
            this.txtDimension1.TabIndex = 14;
            this.txtDimension1.TextChanged += new System.EventHandler(this.TxtDimension1_TextChanged);
            // 
            // txtDimension3
            // 
            this.txtDimension3.Location = new System.Drawing.Point(627, 268);
            this.txtDimension3.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimension3.Name = "txtDimension3";
            this.txtDimension3.Size = new System.Drawing.Size(148, 25);
            this.txtDimension3.TabIndex = 15;
            // 
            // txtDimension2
            // 
            this.txtDimension2.Location = new System.Drawing.Point(627, 208);
            this.txtDimension2.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimension2.Name = "txtDimension2";
            this.txtDimension2.Size = new System.Drawing.Size(148, 25);
            this.txtDimension2.TabIndex = 16;
            // 
            // btnChosenShape
            // 
            this.btnChosenShape.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChosenShape.Location = new System.Drawing.Point(898, 226);
            this.btnChosenShape.Margin = new System.Windows.Forms.Padding(4);
            this.btnChosenShape.Name = "btnChosenShape";
            this.btnChosenShape.Size = new System.Drawing.Size(184, 59);
            this.btnChosenShape.TabIndex = 17;
            this.btnChosenShape.Text = "Enter";
            this.btnChosenShape.UseVisualStyleBackColor = true;
            this.btnChosenShape.Click += new System.EventHandler(this.BtnChosenShape_Click);
            // 
            // lblShapeName
            // 
            this.lblShapeName.AutoSize = true;
            this.lblShapeName.Font = new System.Drawing.Font("Monospac821 BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShapeName.Location = new System.Drawing.Point(42, 33);
            this.lblShapeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShapeName.Name = "lblShapeName";
            this.lblShapeName.Size = new System.Drawing.Size(240, 45);
            this.lblShapeName.TabIndex = 19;
            this.lblShapeName.Text = "Shape Name";
            // 
            // lblAnswerStatement
            // 
            this.lblAnswerStatement.AutoSize = true;
            this.lblAnswerStatement.Font = new System.Drawing.Font("Romantic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblAnswerStatement.Location = new System.Drawing.Point(178, 369);
            this.lblAnswerStatement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswerStatement.Name = "lblAnswerStatement";
            this.lblAnswerStatement.Size = new System.Drawing.Size(172, 25);
            this.lblAnswerStatement.TabIndex = 20;
            this.lblAnswerStatement.Text = "Answer statement";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(511, 377);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(58, 17);
            this.lblAnswer.TabIndex = 21;
            this.lblAnswer.Text = "Answer";
            // 
            // btnCalculateSphere
            // 
            this.btnCalculateSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSphere.Location = new System.Drawing.Point(922, 117);
            this.btnCalculateSphere.Name = "btnCalculateSphere";
            this.btnCalculateSphere.Size = new System.Drawing.Size(155, 33);
            this.btnCalculateSphere.TabIndex = 22;
            this.btnCalculateSphere.Text = "Calculate Sphere";
            this.btnCalculateSphere.UseVisualStyleBackColor = true;
            this.btnCalculateSphere.Click += new System.EventHandler(this.BtnCalculateSphere_Click);
            // 
            // btnCalculateCone
            // 
            this.btnCalculateCone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCone.Location = new System.Drawing.Point(917, 329);
            this.btnCalculateCone.Name = "btnCalculateCone";
            this.btnCalculateCone.Size = new System.Drawing.Size(133, 33);
            this.btnCalculateCone.TabIndex = 23;
            this.btnCalculateCone.Text = "Calculate Cone";
            this.btnCalculateCone.UseVisualStyleBackColor = true;
            this.btnCalculateCone.Click += new System.EventHandler(this.BtnCalculateCone_Click);
            // 
            // btnCalculateCube
            // 
            this.btnCalculateCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCube.Location = new System.Drawing.Point(917, 287);
            this.btnCalculateCube.Name = "btnCalculateCube";
            this.btnCalculateCube.Size = new System.Drawing.Size(133, 33);
            this.btnCalculateCube.TabIndex = 25;
            this.btnCalculateCube.Text = "Calculate Cube";
            this.btnCalculateCube.UseVisualStyleBackColor = true;
            this.btnCalculateCube.Click += new System.EventHandler(this.BtnCalculateCube_Click);
            // 
            // btnCalculateSquareBasedPyramid
            // 
            this.btnCalculateSquareBasedPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSquareBasedPyramid.Location = new System.Drawing.Point(911, 231);
            this.btnCalculateSquareBasedPyramid.Name = "btnCalculateSquareBasedPyramid";
            this.btnCalculateSquareBasedPyramid.Size = new System.Drawing.Size(166, 50);
            this.btnCalculateSquareBasedPyramid.TabIndex = 26;
            this.btnCalculateSquareBasedPyramid.Text = "Calculate Square Based Pyramid";
            this.btnCalculateSquareBasedPyramid.UseVisualStyleBackColor = true;
            this.btnCalculateSquareBasedPyramid.Click += new System.EventHandler(this.BtnCalculateSquareBasedPyramid_Click);
            // 
            // btnCalculateTriangle
            // 
            this.btnCalculateTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTriangle.Location = new System.Drawing.Point(917, 192);
            this.btnCalculateTriangle.Name = "btnCalculateTriangle";
            this.btnCalculateTriangle.Size = new System.Drawing.Size(160, 33);
            this.btnCalculateTriangle.TabIndex = 27;
            this.btnCalculateTriangle.Text = "Calculate Triangle";
            this.btnCalculateTriangle.UseVisualStyleBackColor = true;
            this.btnCalculateTriangle.Click += new System.EventHandler(this.BtnCalculateTriangle_Click);
            // 
            // btnCalculateCylinder
            // 
            this.btnCalculateCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCylinder.Location = new System.Drawing.Point(909, 150);
            this.btnCalculateCylinder.Name = "btnCalculateCylinder";
            this.btnCalculateCylinder.Size = new System.Drawing.Size(173, 36);
            this.btnCalculateCylinder.TabIndex = 28;
            this.btnCalculateCylinder.Text = "Calculate Cylinder";
            this.btnCalculateCylinder.UseVisualStyleBackColor = true;
            this.btnCalculateCylinder.Click += new System.EventHandler(this.BtnCalculateCylinder_Click);
            // 
            // btnCalculateTrapezoid
            // 
            this.btnCalculateTrapezoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTrapezoid.Location = new System.Drawing.Point(904, 78);
            this.btnCalculateTrapezoid.Name = "btnCalculateTrapezoid";
            this.btnCalculateTrapezoid.Size = new System.Drawing.Size(178, 33);
            this.btnCalculateTrapezoid.TabIndex = 29;
            this.btnCalculateTrapezoid.Text = "Calculate Trapezoid";
            this.btnCalculateTrapezoid.UseVisualStyleBackColor = true;
            this.btnCalculateTrapezoid.Click += new System.EventHandler(this.BtnCalculateTrapezoid_Click_1);
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(1200, 24);
            this.mnuFile.TabIndex = 30;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(93, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // frmAreaVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.btnCalculateTrapezoid);
            this.Controls.Add(this.btnCalculateCylinder);
            this.Controls.Add(this.btnCalculateTriangle);
            this.Controls.Add(this.btnCalculateSquareBasedPyramid);
            this.Controls.Add(this.btnCalculateCube);
            this.Controls.Add(this.btnCalculateCone);
            this.Controls.Add(this.btnCalculateSphere);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerStatement);
            this.Controls.Add(this.lblShapeName);
            this.Controls.Add(this.btnChosenShape);
            this.Controls.Add(this.txtDimension2);
            this.Controls.Add(this.txtDimension3);
            this.Controls.Add(this.txtDimension1);
            this.Controls.Add(this.lblDimension3);
            this.Controls.Add(this.lblDimension2);
            this.Controls.Add(this.lblDimension1);
            this.Controls.Add(this.lblCone);
            this.Controls.Add(this.lblCube);
            this.Controls.Add(this.lblSqureBasedPyramid);
            this.Controls.Add(this.lblTriangle);
            this.Controls.Add(this.lblCylinder);
            this.Controls.Add(this.lblSphere);
            this.Controls.Add(this.lblTrapezoid);
            this.Controls.Add(this.numChosenShape);
            this.Controls.Add(this.lblWhatShapeStatement);
            this.Controls.Add(this.mnuFile);
            this.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MainMenuStrip = this.mnuFile;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAreaVolume";
            this.Text = "Area and Volume   By: Joelle Ishimwe";
            this.Load += new System.EventHandler(this.FrmAreaVolume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChosenShape)).EndInit();
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhatShapeStatement;
        private System.Windows.Forms.NumericUpDown numChosenShape;
        private System.Windows.Forms.Label lblTrapezoid;
        private System.Windows.Forms.Label lblSphere;
        private System.Windows.Forms.Label lblCylinder;
        private System.Windows.Forms.Label lblTriangle;
        private System.Windows.Forms.Label lblSqureBasedPyramid;
        private System.Windows.Forms.Label lblCube;
        private System.Windows.Forms.Label lblCone;
        private System.Windows.Forms.Label lblDimension1;
        private System.Windows.Forms.Label lblDimension2;
        private System.Windows.Forms.Label lblDimension3;
        private System.Windows.Forms.TextBox txtDimension1;
        private System.Windows.Forms.TextBox txtDimension3;
        private System.Windows.Forms.TextBox txtDimension2;
        private System.Windows.Forms.Button btnChosenShape;
        private System.Windows.Forms.Label lblShapeName;
        private System.Windows.Forms.Label lblAnswerStatement;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculateSphere;
        private System.Windows.Forms.Button btnCalculateCone;
        private System.Windows.Forms.Button btnCalculateCube;
        private System.Windows.Forms.Button btnCalculateSquareBasedPyramid;
        private System.Windows.Forms.Button btnCalculateTriangle;
        private System.Windows.Forms.Button btnCalculateCylinder;
        private System.Windows.Forms.Button btnCalculateTrapezoid;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

