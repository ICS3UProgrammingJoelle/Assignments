namespace PizzaOrderJoelle
{
    partial class frmPizzaOrder
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
            this.lblProvince = new System.Windows.Forms.Label();
            this.btnProvinceNext = new System.Windows.Forms.Button();
            this.nudProvince = new System.Windows.Forms.NumericUpDown();
            this.lblBritishColumbia = new System.Windows.Forms.Label();
            this.lblAlberta = new System.Windows.Forms.Label();
            this.lblSaskatchewan = new System.Windows.Forms.Label();
            this.lblManitoba = new System.Windows.Forms.Label();
            this.lblOntario = new System.Windows.Forms.Label();
            this.lblQuebec = new System.Windows.Forms.Label();
            this.lblNewfoundland = new System.Windows.Forms.Label();
            this.lblPrinceEdwardIsland = new System.Windows.Forms.Label();
            this.lblNewBruswick = new System.Windows.Forms.Label();
            this.lblNovaScotia = new System.Windows.Forms.Label();
            this.lblFries = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblExtraLarge = new System.Windows.Forms.Label();
            this.lblPizzaTopping = new System.Windows.Forms.Label();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.btnToppingsNext = new System.Windows.Forms.Button();
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.picNoFries = new System.Windows.Forms.PictureBox();
            this.picSmallFries = new System.Windows.Forms.PictureBox();
            this.picLargeFries = new System.Windows.Forms.PictureBox();
            this.picExtraLargePizzaSize = new System.Windows.Forms.PictureBox();
            this.picLargePizzaSize = new System.Windows.Forms.PictureBox();
            this.lblSmallFries = new System.Windows.Forms.Label();
            this.lblLargeFries = new System.Windows.Forms.Label();
            this.lblNoFries = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstTotalCost = new System.Windows.Forms.ListBox();
            this.lblNoToppings = new System.Windows.Forms.Label();
            this.lblOneTopping = new System.Windows.Forms.Label();
            this.lblTwoToppings = new System.Windows.Forms.Label();
            this.lblThreeToppings = new System.Windows.Forms.Label();
            this.lblFourToppings = new System.Windows.Forms.Label();
            this.lblRecipt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLargeFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtraLargePizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLargePizzaSize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(12, 31);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(460, 26);
            this.lblProvince.TabIndex = 1;
            this.lblProvince.Text = "What Canadian province are you from?";
            // 
            // btnProvinceNext
            // 
            this.btnProvinceNext.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvinceNext.Location = new System.Drawing.Point(679, 389);
            this.btnProvinceNext.Name = "btnProvinceNext";
            this.btnProvinceNext.Size = new System.Drawing.Size(84, 27);
            this.btnProvinceNext.TabIndex = 2;
            this.btnProvinceNext.Text = "Next";
            this.btnProvinceNext.UseVisualStyleBackColor = true;
            this.btnProvinceNext.Click += new System.EventHandler(this.btnProvinceNext_Click);
            // 
            // nudProvince
            // 
            this.nudProvince.Location = new System.Drawing.Point(531, 39);
            this.nudProvince.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudProvince.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProvince.Name = "nudProvince";
            this.nudProvince.Size = new System.Drawing.Size(120, 20);
            this.nudProvince.TabIndex = 3;
            this.nudProvince.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBritishColumbia
            // 
            this.lblBritishColumbia.AutoSize = true;
            this.lblBritishColumbia.Location = new System.Drawing.Point(58, 87);
            this.lblBritishColumbia.Name = "lblBritishColumbia";
            this.lblBritishColumbia.Size = new System.Drawing.Size(156, 13);
            this.lblBritishColumbia.TabIndex = 4;
            this.lblBritishColumbia.Text = "1 = British Columbia (12% taxes)";
            this.lblBritishColumbia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAlberta
            // 
            this.lblAlberta.AutoSize = true;
            this.lblAlberta.Location = new System.Drawing.Point(58, 122);
            this.lblAlberta.Name = "lblAlberta";
            this.lblAlberta.Size = new System.Drawing.Size(109, 13);
            this.lblAlberta.TabIndex = 5;
            this.lblAlberta.Text = "2 = Alberta (5% taxes)";
            // 
            // lblSaskatchewan
            // 
            this.lblSaskatchewan.AutoSize = true;
            this.lblSaskatchewan.Location = new System.Drawing.Point(58, 153);
            this.lblSaskatchewan.Name = "lblSaskatchewan";
            this.lblSaskatchewan.Size = new System.Drawing.Size(153, 13);
            this.lblSaskatchewan.TabIndex = 6;
            this.lblSaskatchewan.Text = "3 = Saskatchewan (10% taxes)";
            // 
            // lblManitoba
            // 
            this.lblManitoba.AutoSize = true;
            this.lblManitoba.Location = new System.Drawing.Point(58, 189);
            this.lblManitoba.Name = "lblManitoba";
            this.lblManitoba.Size = new System.Drawing.Size(126, 13);
            this.lblManitoba.TabIndex = 7;
            this.lblManitoba.Text = "4 = Manitoba (12% taxes)";
            // 
            // lblOntario
            // 
            this.lblOntario.AutoSize = true;
            this.lblOntario.Location = new System.Drawing.Point(58, 221);
            this.lblOntario.Name = "lblOntario";
            this.lblOntario.Size = new System.Drawing.Size(116, 13);
            this.lblOntario.TabIndex = 8;
            this.lblOntario.Text = "5 = Ontario (13% taxes)";
            // 
            // lblQuebec
            // 
            this.lblQuebec.AutoSize = true;
            this.lblQuebec.Location = new System.Drawing.Point(58, 257);
            this.lblQuebec.Name = "lblQuebec";
            this.lblQuebec.Size = new System.Drawing.Size(120, 13);
            this.lblQuebec.TabIndex = 9;
            this.lblQuebec.Text = "6 = Quebec (15% taxes)";
            // 
            // lblNewfoundland
            // 
            this.lblNewfoundland.AutoSize = true;
            this.lblNewfoundland.Location = new System.Drawing.Point(58, 292);
            this.lblNewfoundland.Name = "lblNewfoundland";
            this.lblNewfoundland.Size = new System.Drawing.Size(151, 13);
            this.lblNewfoundland.TabIndex = 10;
            this.lblNewfoundland.Text = "7 = Newfoundland (13% taxes)";
            // 
            // lblPrinceEdwardIsland
            // 
            this.lblPrinceEdwardIsland.AutoSize = true;
            this.lblPrinceEdwardIsland.Location = new System.Drawing.Point(58, 325);
            this.lblPrinceEdwardIsland.Name = "lblPrinceEdwardIsland";
            this.lblPrinceEdwardIsland.Size = new System.Drawing.Size(182, 13);
            this.lblPrinceEdwardIsland.TabIndex = 11;
            this.lblPrinceEdwardIsland.Text = "8 = Prince Edward Island (15% taxes)";
            // 
            // lblNewBruswick
            // 
            this.lblNewBruswick.AutoSize = true;
            this.lblNewBruswick.Location = new System.Drawing.Point(58, 360);
            this.lblNewBruswick.Name = "lblNewBruswick";
            this.lblNewBruswick.Size = new System.Drawing.Size(150, 13);
            this.lblNewBruswick.TabIndex = 12;
            this.lblNewBruswick.Text = "9 = New Bruswick (13% taxes)";
            // 
            // lblNovaScotia
            // 
            this.lblNovaScotia.AutoSize = true;
            this.lblNovaScotia.Location = new System.Drawing.Point(58, 397);
            this.lblNovaScotia.Name = "lblNovaScotia";
            this.lblNovaScotia.Size = new System.Drawing.Size(147, 13);
            this.lblNovaScotia.TabIndex = 13;
            this.lblNovaScotia.Text = "10 = Nova Scotia (15% taxes)";
            // 
            // lblFries
            // 
            this.lblFries.AutoSize = true;
            this.lblFries.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFries.Location = new System.Drawing.Point(210, 76);
            this.lblFries.Name = "lblFries";
            this.lblFries.Size = new System.Drawing.Size(342, 24);
            this.lblFries.TabIndex = 14;
            this.lblFries.Text = "What size frie box would you like?";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(194, 221);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(98, 16);
            this.lblLarge.TabIndex = 16;
            this.lblLarge.Text = "Large ($9.00)";
            // 
            // lblExtraLarge
            // 
            this.lblExtraLarge.AutoSize = true;
            this.lblExtraLarge.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLarge.Location = new System.Drawing.Point(450, 221);
            this.lblExtraLarge.Name = "lblExtraLarge";
            this.lblExtraLarge.Size = new System.Drawing.Size(145, 16);
            this.lblExtraLarge.TabIndex = 17;
            this.lblExtraLarge.Text = "Extra Large ($12.00)";
            // 
            // lblPizzaTopping
            // 
            this.lblPizzaTopping.AutoSize = true;
            this.lblPizzaTopping.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaTopping.Location = new System.Drawing.Point(78, 116);
            this.lblPizzaTopping.Name = "lblPizzaTopping";
            this.lblPizzaTopping.Size = new System.Drawing.Size(377, 24);
            this.lblPizzaTopping.TabIndex = 21;
            this.lblPizzaTopping.Text = "How many topping(s) would you like?\r\n";
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(531, 120);
            this.nudToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 22;
            this.nudToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnToppingsNext
            // 
            this.btnToppingsNext.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToppingsNext.Location = new System.Drawing.Point(679, 389);
            this.btnToppingsNext.Name = "btnToppingsNext";
            this.btnToppingsNext.Size = new System.Drawing.Size(84, 27);
            this.btnToppingsNext.TabIndex = 23;
            this.btnToppingsNext.Text = "Next";
            this.btnToppingsNext.UseVisualStyleBackColor = true;
            this.btnToppingsNext.Click += new System.EventHandler(this.btnToppingsNext_Click);
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.Location = new System.Drawing.Point(235, 122);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(317, 48);
            this.lblPizzaSize.TabIndex = 25;
            this.lblPizzaSize.Text = "What size pizza would you like?\r\n(click on the image to choose)";
            // 
            // picNoFries
            // 
            this.picNoFries.Image = global::PizzaOrderJoelle.Properties.Resources.noFries;
            this.picNoFries.Location = new System.Drawing.Point(573, 271);
            this.picNoFries.Name = "picNoFries";
            this.picNoFries.Size = new System.Drawing.Size(91, 102);
            this.picNoFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoFries.TabIndex = 28;
            this.picNoFries.TabStop = false;
            this.picNoFries.Click += new System.EventHandler(this.picNoFries_Click);
            // 
            // picSmallFries
            // 
            this.picSmallFries.Image = global::PizzaOrderJoelle.Properties.Resources.fries;
            this.picSmallFries.Location = new System.Drawing.Point(99, 273);
            this.picSmallFries.Name = "picSmallFries";
            this.picSmallFries.Size = new System.Drawing.Size(84, 102);
            this.picSmallFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmallFries.TabIndex = 27;
            this.picSmallFries.TabStop = false;
            this.picSmallFries.Click += new System.EventHandler(this.picSmallFries_Click);
            // 
            // picLargeFries
            // 
            this.picLargeFries.Image = global::PizzaOrderJoelle.Properties.Resources.fries;
            this.picLargeFries.Location = new System.Drawing.Point(313, 219);
            this.picLargeFries.Name = "picLargeFries";
            this.picLargeFries.Size = new System.Drawing.Size(142, 154);
            this.picLargeFries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLargeFries.TabIndex = 26;
            this.picLargeFries.TabStop = false;
            this.picLargeFries.Click += new System.EventHandler(this.picLargeFries_Click);
            // 
            // picExtraLargePizzaSize
            // 
            this.picExtraLargePizzaSize.Image = global::PizzaOrderJoelle.Properties.Resources.pizzaSize;
            this.picExtraLargePizzaSize.Location = new System.Drawing.Point(442, 257);
            this.picExtraLargePizzaSize.Name = "picExtraLargePizzaSize";
            this.picExtraLargePizzaSize.Size = new System.Drawing.Size(171, 140);
            this.picExtraLargePizzaSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExtraLargePizzaSize.TabIndex = 20;
            this.picExtraLargePizzaSize.TabStop = false;
            this.picExtraLargePizzaSize.Click += new System.EventHandler(this.picExtraLargePizzaSize_Click);
            // 
            // picLargePizzaSize
            // 
            this.picLargePizzaSize.Image = global::PizzaOrderJoelle.Properties.Resources.pizzaSize;
            this.picLargePizzaSize.Location = new System.Drawing.Point(174, 257);
            this.picLargePizzaSize.Name = "picLargePizzaSize";
            this.picLargePizzaSize.Size = new System.Drawing.Size(133, 116);
            this.picLargePizzaSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLargePizzaSize.TabIndex = 19;
            this.picLargePizzaSize.TabStop = false;
            this.picLargePizzaSize.Click += new System.EventHandler(this.picLargePizzaSize_Click);
            // 
            // lblSmallFries
            // 
            this.lblSmallFries.AutoSize = true;
            this.lblSmallFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallFries.Location = new System.Drawing.Point(93, 384);
            this.lblSmallFries.Name = "lblSmallFries";
            this.lblSmallFries.Size = new System.Drawing.Size(112, 13);
            this.lblSmallFries.TabIndex = 29;
            this.lblSmallFries.Text = "Small Fries ($6.00)";
            // 
            // lblLargeFries
            // 
            this.lblLargeFries.AutoSize = true;
            this.lblLargeFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargeFries.Location = new System.Drawing.Point(315, 384);
            this.lblLargeFries.Name = "lblLargeFries";
            this.lblLargeFries.Size = new System.Drawing.Size(121, 13);
            this.lblLargeFries.TabIndex = 30;
            this.lblLargeFries.Text = "Large Fries ($12.00)";
            // 
            // lblNoFries
            // 
            this.lblNoFries.AutoSize = true;
            this.lblNoFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFries.Location = new System.Drawing.Point(575, 384);
            this.lblNoFries.Name = "lblNoFries";
            this.lblNoFries.Size = new System.Drawing.Size(98, 13);
            this.lblNoFries.TabIndex = 31;
            this.lblNoFries.Text = "No Fries ($0.00)";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(361, 412);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(31, 28);
            this.lblTotalCost.TabIndex = 33;
            this.lblTotalCost.Text = "hi";
            // 
            // lstTotalCost
            // 
            this.lstTotalCost.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTotalCost.FormattingEnabled = true;
            this.lstTotalCost.ItemHeight = 35;
            this.lstTotalCost.Location = new System.Drawing.Point(214, 165);
            this.lstTotalCost.Name = "lstTotalCost";
            this.lstTotalCost.Size = new System.Drawing.Size(364, 144);
            this.lstTotalCost.TabIndex = 34;
            // 
            // lblNoToppings
            // 
            this.lblNoToppings.AutoSize = true;
            this.lblNoToppings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoToppings.Location = new System.Drawing.Point(310, 186);
            this.lblNoToppings.Name = "lblNoToppings";
            this.lblNoToppings.Size = new System.Drawing.Size(135, 16);
            this.lblNoToppings.TabIndex = 35;
            this.lblNoToppings.Text = "No topping = $0.00";
            // 
            // lblOneTopping
            // 
            this.lblOneTopping.AutoSize = true;
            this.lblOneTopping.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneTopping.Location = new System.Drawing.Point(310, 219);
            this.lblOneTopping.Name = "lblOneTopping";
            this.lblOneTopping.Size = new System.Drawing.Size(147, 16);
            this.lblOneTopping.TabIndex = 36;
            this.lblOneTopping.Text = "One Topping = $0.75";
            // 
            // lblTwoToppings
            // 
            this.lblTwoToppings.AutoSize = true;
            this.lblTwoToppings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoToppings.Location = new System.Drawing.Point(310, 252);
            this.lblTwoToppings.Name = "lblTwoToppings";
            this.lblTwoToppings.Size = new System.Drawing.Size(156, 16);
            this.lblTwoToppings.TabIndex = 37;
            this.lblTwoToppings.Text = "Two Toppings = $1.35";
            this.lblTwoToppings.Click += new System.EventHandler(this.lblTwoToppings_Click);
            // 
            // lblThreeToppings
            // 
            this.lblThreeToppings.AutoSize = true;
            this.lblThreeToppings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeToppings.Location = new System.Drawing.Point(310, 289);
            this.lblThreeToppings.Name = "lblThreeToppings";
            this.lblThreeToppings.Size = new System.Drawing.Size(166, 16);
            this.lblThreeToppings.TabIndex = 38;
            this.lblThreeToppings.Text = "Three Toppings = $2.15";
            // 
            // lblFourToppings
            // 
            this.lblFourToppings.AutoSize = true;
            this.lblFourToppings.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourToppings.Location = new System.Drawing.Point(310, 322);
            this.lblFourToppings.Name = "lblFourToppings";
            this.lblFourToppings.Size = new System.Drawing.Size(157, 16);
            this.lblFourToppings.TabIndex = 39;
            this.lblFourToppings.Text = "Four Toppings = $2.75";
            // 
            // lblRecipt
            // 
            this.lblRecipt.AutoSize = true;
            this.lblRecipt.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipt.Location = new System.Drawing.Point(206, 87);
            this.lblRecipt.Name = "lblRecipt";
            this.lblRecipt.Size = new System.Drawing.Size(369, 46);
            this.lblRecipt.TabIndex = 40;
            this.lblRecipt.Text = "Here\'s your recipt";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecipt);
            this.Controls.Add(this.lblFourToppings);
            this.Controls.Add(this.lblThreeToppings);
            this.Controls.Add(this.lblTwoToppings);
            this.Controls.Add(this.lblOneTopping);
            this.Controls.Add(this.lblNoToppings);
            this.Controls.Add(this.lstTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblNoFries);
            this.Controls.Add(this.lblLargeFries);
            this.Controls.Add(this.lblSmallFries);
            this.Controls.Add(this.picNoFries);
            this.Controls.Add(this.picSmallFries);
            this.Controls.Add(this.picLargeFries);
            this.Controls.Add(this.lblPizzaSize);
            this.Controls.Add(this.btnToppingsNext);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.lblPizzaTopping);
            this.Controls.Add(this.picExtraLargePizzaSize);
            this.Controls.Add(this.picLargePizzaSize);
            this.Controls.Add(this.lblExtraLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblFries);
            this.Controls.Add(this.lblNovaScotia);
            this.Controls.Add(this.lblNewBruswick);
            this.Controls.Add(this.lblPrinceEdwardIsland);
            this.Controls.Add(this.lblNewfoundland);
            this.Controls.Add(this.lblQuebec);
            this.Controls.Add(this.lblOntario);
            this.Controls.Add(this.lblManitoba);
            this.Controls.Add(this.lblSaskatchewan);
            this.Controls.Add(this.lblAlberta);
            this.Controls.Add(this.lblBritishColumbia);
            this.Controls.Add(this.nudProvince);
            this.Controls.Add(this.btnProvinceNext);
            this.Controls.Add(this.lblProvince);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order       by: Joelle Ishimwe";
            ((System.ComponentModel.ISupportInitialize)(this.nudProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNoFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmallFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLargeFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExtraLargePizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLargePizzaSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Button btnProvinceNext;
        private System.Windows.Forms.NumericUpDown nudProvince;
        private System.Windows.Forms.Label lblBritishColumbia;
        private System.Windows.Forms.Label lblAlberta;
        private System.Windows.Forms.Label lblSaskatchewan;
        private System.Windows.Forms.Label lblManitoba;
        private System.Windows.Forms.Label lblOntario;
        private System.Windows.Forms.Label lblQuebec;
        private System.Windows.Forms.Label lblNewfoundland;
        private System.Windows.Forms.Label lblPrinceEdwardIsland;
        private System.Windows.Forms.Label lblNewBruswick;
        private System.Windows.Forms.Label lblNovaScotia;
        private System.Windows.Forms.Label lblFries;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblExtraLarge;
        private System.Windows.Forms.PictureBox picLargePizzaSize;
        private System.Windows.Forms.PictureBox picExtraLargePizzaSize;
        private System.Windows.Forms.Label lblPizzaTopping;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.Button btnToppingsNext;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.PictureBox picLargeFries;
        private System.Windows.Forms.PictureBox picSmallFries;
        private System.Windows.Forms.PictureBox picNoFries;
        private System.Windows.Forms.Label lblSmallFries;
        private System.Windows.Forms.Label lblLargeFries;
        private System.Windows.Forms.Label lblNoFries;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstTotalCost;
        private System.Windows.Forms.Label lblNoToppings;
        private System.Windows.Forms.Label lblOneTopping;
        private System.Windows.Forms.Label lblTwoToppings;
        private System.Windows.Forms.Label lblThreeToppings;
        private System.Windows.Forms.Label lblFourToppings;
        private System.Windows.Forms.Label lblRecipt;
    }
}

