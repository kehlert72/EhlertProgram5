namespace EhlertProgram5
{
    partial class PizzaOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrderForm));
            this.mstControl = new System.Windows.Forms.TabControl();
            this.mstPizza = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cmbPizzaQuantity = new System.Windows.Forms.ComboBox();
            this.lblPizzaQuantity = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckLstToppings = new System.Windows.Forms.CheckedListBox();
            this.cmbPizzaType = new System.Windows.Forms.ComboBox();
            this.lblPizzaType = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPizzaSelection = new System.Windows.Forms.Label();
            this.mstBeverages = new System.Windows.Forms.TabPage();
            this.lblBeverageWarning = new System.Windows.Forms.Label();
            this.lblBeverageQuantity = new System.Windows.Forms.Label();
            this.txtDrPepperQuantity = new System.Windows.Forms.TextBox();
            this.txtMugRootBeerQuantity = new System.Windows.Forms.TextBox();
            this.txtMtnDewCodeRedQuantity = new System.Windows.Forms.TextBox();
            this.txtSpriteQuantity = new System.Windows.Forms.TextBox();
            this.txtMtnDewOriginalQuantity = new System.Windows.Forms.TextBox();
            this.lstBeverages = new System.Windows.Forms.ListBox();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.mstSidesDesserts = new System.Windows.Forms.TabPage();
            this.txtCheeseSticksQuantity = new System.Windows.Forms.TextBox();
            this.lblDessertWarning = new System.Windows.Forms.Label();
            this.lblDesertQuantity = new System.Windows.Forms.Label();
            this.txtCinnamonPullApartsQuantity = new System.Windows.Forms.TextBox();
            this.txtCarmelChocolateChipQuantity = new System.Windows.Forms.TextBox();
            this.txtBrownieQuantity = new System.Windows.Forms.TextBox();
            this.txtChocolateChipQuantity = new System.Windows.Forms.TextBox();
            this.lstDessertsSides = new System.Windows.Forms.ListBox();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.mstCustomerInfo = new System.Windows.Forms.TabPage();
            this.cmbCreditCardType = new System.Windows.Forms.ComboBox();
            this.txtCreditCard = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstCustomerInfo = new System.Windows.Forms.ListBox();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.mstOrder = new System.Windows.Forms.TabPage();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.mstControl.SuspendLayout();
            this.mstPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.mstBeverages.SuspendLayout();
            this.mstSidesDesserts.SuspendLayout();
            this.mstCustomerInfo.SuspendLayout();
            this.mstOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstControl
            // 
            this.mstControl.Controls.Add(this.mstPizza);
            this.mstControl.Controls.Add(this.mstBeverages);
            this.mstControl.Controls.Add(this.mstSidesDesserts);
            this.mstControl.Controls.Add(this.mstCustomerInfo);
            this.mstControl.Controls.Add(this.mstOrder);
            this.mstControl.Location = new System.Drawing.Point(0, 0);
            this.mstControl.Margin = new System.Windows.Forms.Padding(4);
            this.mstControl.Name = "mstControl";
            this.mstControl.SelectedIndex = 0;
            this.mstControl.Size = new System.Drawing.Size(392, 286);
            this.mstControl.TabIndex = 0;
            // 
            // mstPizza
            // 
            this.mstPizza.Controls.Add(this.picLogo);
            this.mstPizza.Controls.Add(this.cmbPizzaQuantity);
            this.mstPizza.Controls.Add(this.lblPizzaQuantity);
            this.mstPizza.Controls.Add(this.lblToppings);
            this.mstPizza.Controls.Add(this.ckLstToppings);
            this.mstPizza.Controls.Add(this.cmbPizzaType);
            this.mstPizza.Controls.Add(this.lblPizzaType);
            this.mstPizza.Controls.Add(this.cmbSize);
            this.mstPizza.Controls.Add(this.lblSize);
            this.mstPizza.Controls.Add(this.lblPizzaSelection);
            this.mstPizza.Location = new System.Drawing.Point(4, 25);
            this.mstPizza.Margin = new System.Windows.Forms.Padding(4);
            this.mstPizza.Name = "mstPizza";
            this.mstPizza.Padding = new System.Windows.Forms.Padding(4);
            this.mstPizza.Size = new System.Drawing.Size(384, 257);
            this.mstPizza.TabIndex = 0;
            this.mstPizza.Text = "Pizza";
            this.mstPizza.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picLogo.ErrorImage")));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(163, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 47);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // cmbPizzaQuantity
            // 
            this.cmbPizzaQuantity.FormattingEnabled = true;
            this.cmbPizzaQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbPizzaQuantity.Location = new System.Drawing.Point(11, 172);
            this.cmbPizzaQuantity.Name = "cmbPizzaQuantity";
            this.cmbPizzaQuantity.Size = new System.Drawing.Size(121, 24);
            this.cmbPizzaQuantity.TabIndex = 9;
            // 
            // lblPizzaQuantity
            // 
            this.lblPizzaQuantity.AutoSize = true;
            this.lblPizzaQuantity.Location = new System.Drawing.Point(39, 153);
            this.lblPizzaQuantity.Name = "lblPizzaQuantity";
            this.lblPizzaQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblPizzaQuantity.TabIndex = 8;
            this.lblPizzaQuantity.Text = "Quantity";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(266, 54);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(66, 16);
            this.lblToppings.TabIndex = 7;
            this.lblToppings.Text = "Toppings";
            // 
            // ckLstToppings
            // 
            this.ckLstToppings.FormattingEnabled = true;
            this.ckLstToppings.Items.AddRange(new object[] {
            "Pepperoni",
            "Sasuage",
            "Bacon",
            "Chicken",
            "Pineapple",
            "Green Pepper",
            "Red Pepper",
            "Banana Pepper",
            "Jalapeno Pepper",
            "Mushrooms",
            "Artichoke",
            "Green Olives",
            "Black Olives"});
            this.ckLstToppings.Location = new System.Drawing.Point(241, 73);
            this.ckLstToppings.Name = "ckLstToppings";
            this.ckLstToppings.Size = new System.Drawing.Size(120, 123);
            this.ckLstToppings.TabIndex = 6;
            // 
            // cmbPizzaType
            // 
            this.cmbPizzaType.FormattingEnabled = true;
            this.cmbPizzaType.Items.AddRange(new object[] {
            "Thin",
            "Regular"});
            this.cmbPizzaType.Location = new System.Drawing.Point(11, 123);
            this.cmbPizzaType.Name = "cmbPizzaType";
            this.cmbPizzaType.Size = new System.Drawing.Size(121, 24);
            this.cmbPizzaType.TabIndex = 5;
            // 
            // lblPizzaType
            // 
            this.lblPizzaType.AutoSize = true;
            this.lblPizzaType.Location = new System.Drawing.Point(34, 104);
            this.lblPizzaType.Name = "lblPizzaType";
            this.lblPizzaType.Size = new System.Drawing.Size(75, 16);
            this.lblPizzaType.TabIndex = 4;
            this.lblPizzaType.Text = "Pizza Type";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small         $11.00",
            "Medium    $13.00",
            "Large         $15.00",
            "X-Large     $17.00"});
            this.cmbSize.Location = new System.Drawing.Point(11, 73);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 24);
            this.cmbSize.TabIndex = 3;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(48, 54);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(34, 16);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // lblPizzaSelection
            // 
            this.lblPizzaSelection.AutoSize = true;
            this.lblPizzaSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSelection.Location = new System.Drawing.Point(136, 54);
            this.lblPizzaSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPizzaSelection.Name = "lblPizzaSelection";
            this.lblPizzaSelection.Size = new System.Drawing.Size(114, 16);
            this.lblPizzaSelection.TabIndex = 1;
            this.lblPizzaSelection.Text = "Pizza Selection";
            // 
            // mstBeverages
            // 
            this.mstBeverages.Controls.Add(this.lblBeverageWarning);
            this.mstBeverages.Controls.Add(this.lblBeverageQuantity);
            this.mstBeverages.Controls.Add(this.txtDrPepperQuantity);
            this.mstBeverages.Controls.Add(this.txtMugRootBeerQuantity);
            this.mstBeverages.Controls.Add(this.txtMtnDewCodeRedQuantity);
            this.mstBeverages.Controls.Add(this.txtSpriteQuantity);
            this.mstBeverages.Controls.Add(this.txtMtnDewOriginalQuantity);
            this.mstBeverages.Controls.Add(this.lstBeverages);
            this.mstBeverages.Controls.Add(this.lblBeverages);
            this.mstBeverages.Location = new System.Drawing.Point(4, 25);
            this.mstBeverages.Margin = new System.Windows.Forms.Padding(4);
            this.mstBeverages.Name = "mstBeverages";
            this.mstBeverages.Padding = new System.Windows.Forms.Padding(4);
            this.mstBeverages.Size = new System.Drawing.Size(384, 257);
            this.mstBeverages.TabIndex = 1;
            this.mstBeverages.Text = "Beverages";
            this.mstBeverages.UseVisualStyleBackColor = true;
            // 
            // lblBeverageWarning
            // 
            this.lblBeverageWarning.AutoSize = true;
            this.lblBeverageWarning.Location = new System.Drawing.Point(8, 202);
            this.lblBeverageWarning.Name = "lblBeverageWarning";
            this.lblBeverageWarning.Size = new System.Drawing.Size(312, 16);
            this.lblBeverageWarning.TabIndex = 18;
            this.lblBeverageWarning.Text = "*All beverages are size large and cost three dollars";
            // 
            // lblBeverageQuantity
            // 
            this.lblBeverageQuantity.AutoSize = true;
            this.lblBeverageQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverageQuantity.Location = new System.Drawing.Point(210, 6);
            this.lblBeverageQuantity.Name = "lblBeverageQuantity";
            this.lblBeverageQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblBeverageQuantity.TabIndex = 16;
            this.lblBeverageQuantity.Text = "Quantity";
            // 
            // txtDrPepperQuantity
            // 
            this.txtDrPepperQuantity.Location = new System.Drawing.Point(213, 165);
            this.txtDrPepperQuantity.Name = "txtDrPepperQuantity";
            this.txtDrPepperQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtDrPepperQuantity.TabIndex = 14;
            // 
            // txtMugRootBeerQuantity
            // 
            this.txtMugRootBeerQuantity.Location = new System.Drawing.Point(213, 128);
            this.txtMugRootBeerQuantity.Name = "txtMugRootBeerQuantity";
            this.txtMugRootBeerQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtMugRootBeerQuantity.TabIndex = 13;
            // 
            // txtMtnDewCodeRedQuantity
            // 
            this.txtMtnDewCodeRedQuantity.Location = new System.Drawing.Point(213, 72);
            this.txtMtnDewCodeRedQuantity.Name = "txtMtnDewCodeRedQuantity";
            this.txtMtnDewCodeRedQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtMtnDewCodeRedQuantity.TabIndex = 12;
            // 
            // txtSpriteQuantity
            // 
            this.txtSpriteQuantity.Location = new System.Drawing.Point(213, 100);
            this.txtSpriteQuantity.Name = "txtSpriteQuantity";
            this.txtSpriteQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtSpriteQuantity.TabIndex = 11;
            // 
            // txtMtnDewOriginalQuantity
            // 
            this.txtMtnDewOriginalQuantity.Location = new System.Drawing.Point(213, 35);
            this.txtMtnDewOriginalQuantity.Name = "txtMtnDewOriginalQuantity";
            this.txtMtnDewOriginalQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtMtnDewOriginalQuantity.TabIndex = 10;
            // 
            // lstBeverages
            // 
            this.lstBeverages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBeverages.FormattingEnabled = true;
            this.lstBeverages.ItemHeight = 16;
            this.lstBeverages.Items.AddRange(new object[] {
            "Mountain Dew Original",
            "",
            "Mountain Dew Code Red",
            "",
            "Sprite",
            "",
            "Mug Root Beer",
            "",
            "Dr. Pepper"});
            this.lstBeverages.Location = new System.Drawing.Point(8, 35);
            this.lstBeverages.Name = "lstBeverages";
            this.lstBeverages.Size = new System.Drawing.Size(321, 164);
            this.lstBeverages.TabIndex = 9;
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverages.Location = new System.Drawing.Point(5, 6);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(84, 16);
            this.lblBeverages.TabIndex = 8;
            this.lblBeverages.Text = "Beverages";
            // 
            // mstSidesDesserts
            // 
            this.mstSidesDesserts.Controls.Add(this.txtCheeseSticksQuantity);
            this.mstSidesDesserts.Controls.Add(this.lblDessertWarning);
            this.mstSidesDesserts.Controls.Add(this.lblDesertQuantity);
            this.mstSidesDesserts.Controls.Add(this.txtCinnamonPullApartsQuantity);
            this.mstSidesDesserts.Controls.Add(this.txtCarmelChocolateChipQuantity);
            this.mstSidesDesserts.Controls.Add(this.txtBrownieQuantity);
            this.mstSidesDesserts.Controls.Add(this.txtChocolateChipQuantity);
            this.mstSidesDesserts.Controls.Add(this.lstDessertsSides);
            this.mstSidesDesserts.Controls.Add(this.lblDesserts);
            this.mstSidesDesserts.Location = new System.Drawing.Point(4, 25);
            this.mstSidesDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.mstSidesDesserts.Name = "mstSidesDesserts";
            this.mstSidesDesserts.Padding = new System.Windows.Forms.Padding(4);
            this.mstSidesDesserts.Size = new System.Drawing.Size(384, 257);
            this.mstSidesDesserts.TabIndex = 2;
            this.mstSidesDesserts.Text = "Sides/Desserts";
            this.mstSidesDesserts.UseVisualStyleBackColor = true;
            // 
            // txtCheeseSticksQuantity
            // 
            this.txtCheeseSticksQuantity.Location = new System.Drawing.Point(213, 163);
            this.txtCheeseSticksQuantity.Name = "txtCheeseSticksQuantity";
            this.txtCheeseSticksQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtCheeseSticksQuantity.TabIndex = 27;
            // 
            // lblDessertWarning
            // 
            this.lblDessertWarning.AutoSize = true;
            this.lblDessertWarning.Location = new System.Drawing.Point(8, 204);
            this.lblDessertWarning.Name = "lblDessertWarning";
            this.lblDessertWarning.Size = new System.Drawing.Size(369, 16);
            this.lblDessertWarning.TabIndex = 26;
            this.lblDessertWarning.Text = "*All Deserts/Sides cost six dollars and come in the size large.";
            // 
            // lblDesertQuantity
            // 
            this.lblDesertQuantity.AutoSize = true;
            this.lblDesertQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesertQuantity.Location = new System.Drawing.Point(210, 8);
            this.lblDesertQuantity.Name = "lblDesertQuantity";
            this.lblDesertQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblDesertQuantity.TabIndex = 25;
            this.lblDesertQuantity.Text = "Quantity";
            // 
            // txtCinnamonPullApartsQuantity
            // 
            this.txtCinnamonPullApartsQuantity.Location = new System.Drawing.Point(213, 130);
            this.txtCinnamonPullApartsQuantity.Name = "txtCinnamonPullApartsQuantity";
            this.txtCinnamonPullApartsQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtCinnamonPullApartsQuantity.TabIndex = 22;
            // 
            // txtCarmelChocolateChipQuantity
            // 
            this.txtCarmelChocolateChipQuantity.Location = new System.Drawing.Point(213, 74);
            this.txtCarmelChocolateChipQuantity.Name = "txtCarmelChocolateChipQuantity";
            this.txtCarmelChocolateChipQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtCarmelChocolateChipQuantity.TabIndex = 21;
            // 
            // txtBrownieQuantity
            // 
            this.txtBrownieQuantity.Location = new System.Drawing.Point(213, 102);
            this.txtBrownieQuantity.Name = "txtBrownieQuantity";
            this.txtBrownieQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtBrownieQuantity.TabIndex = 20;
            // 
            // txtChocolateChipQuantity
            // 
            this.txtChocolateChipQuantity.Location = new System.Drawing.Point(213, 37);
            this.txtChocolateChipQuantity.Name = "txtChocolateChipQuantity";
            this.txtChocolateChipQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtChocolateChipQuantity.TabIndex = 19;
            // 
            // lstDessertsSides
            // 
            this.lstDessertsSides.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstDessertsSides.FormattingEnabled = true;
            this.lstDessertsSides.ItemHeight = 16;
            this.lstDessertsSides.Items.AddRange(new object[] {
            "Chocolate Chip Pizza",
            "",
            "Salted Carmel Chocolate Chip",
            "",
            "Double Chocolate Chip Brownie",
            "",
            "Cinnamon Pull Aparts",
            "",
            "Cheese Sticks"});
            this.lstDessertsSides.Location = new System.Drawing.Point(8, 37);
            this.lstDessertsSides.Name = "lstDessertsSides";
            this.lstDessertsSides.Size = new System.Drawing.Size(321, 164);
            this.lstDessertsSides.TabIndex = 18;
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesserts.Location = new System.Drawing.Point(5, 8);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(115, 16);
            this.lblDesserts.TabIndex = 17;
            this.lblDesserts.Text = "Desserts/Sides";
            // 
            // mstCustomerInfo
            // 
            this.mstCustomerInfo.Controls.Add(this.cmbCreditCardType);
            this.mstCustomerInfo.Controls.Add(this.txtCreditCard);
            this.mstCustomerInfo.Controls.Add(this.txtEmail);
            this.mstCustomerInfo.Controls.Add(this.txtAddress);
            this.mstCustomerInfo.Controls.Add(this.txtPhoneNumber);
            this.mstCustomerInfo.Controls.Add(this.txtName);
            this.mstCustomerInfo.Controls.Add(this.lstCustomerInfo);
            this.mstCustomerInfo.Controls.Add(this.lblCustomerInfo);
            this.mstCustomerInfo.Location = new System.Drawing.Point(4, 25);
            this.mstCustomerInfo.Name = "mstCustomerInfo";
            this.mstCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.mstCustomerInfo.Size = new System.Drawing.Size(384, 257);
            this.mstCustomerInfo.TabIndex = 3;
            this.mstCustomerInfo.Text = "Customer Info";
            this.mstCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // cmbCreditCardType
            // 
            this.cmbCreditCardType.FormattingEnabled = true;
            this.cmbCreditCardType.Items.AddRange(new object[] {
            "MasterCard",
            "Visa",
            "American Express",
            "Discover",
            "Paypal"});
            this.cmbCreditCardType.Location = new System.Drawing.Point(138, 201);
            this.cmbCreditCardType.Name = "cmbCreditCardType";
            this.cmbCreditCardType.Size = new System.Drawing.Size(121, 24);
            this.cmbCreditCardType.TabIndex = 15;
            // 
            // txtCreditCard
            // 
            this.txtCreditCard.Location = new System.Drawing.Point(159, 164);
            this.txtCreditCard.Name = "txtCreditCard";
            this.txtCreditCard.Size = new System.Drawing.Size(100, 22);
            this.txtCreditCard.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(159, 66);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(159, 104);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 10;
            // 
            // lstCustomerInfo
            // 
            this.lstCustomerInfo.FormattingEnabled = true;
            this.lstCustomerInfo.ItemHeight = 16;
            this.lstCustomerInfo.Items.AddRange(new object[] {
            "Name",
            "",
            "Address",
            "",
            "Phone Number",
            "",
            "Email",
            "",
            "Credit Card",
            "",
            "Credit Card Type"});
            this.lstCustomerInfo.Location = new System.Drawing.Point(11, 38);
            this.lstCustomerInfo.Name = "lstCustomerInfo";
            this.lstCustomerInfo.Size = new System.Drawing.Size(248, 196);
            this.lstCustomerInfo.TabIndex = 9;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(8, 8);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(102, 16);
            this.lblCustomerInfo.TabIndex = 8;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // mstOrder
            // 
            this.mstOrder.Controls.Add(this.txtOrder);
            this.mstOrder.Location = new System.Drawing.Point(4, 25);
            this.mstOrder.Name = "mstOrder";
            this.mstOrder.Padding = new System.Windows.Forms.Padding(3);
            this.mstOrder.Size = new System.Drawing.Size(384, 257);
            this.mstOrder.TabIndex = 4;
            this.mstOrder.Text = "Order";
            this.mstOrder.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(8, 6);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(368, 245);
            this.txtOrder.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(15, 294);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(147, 37);
            this.btnPlaceOrder.TabIndex = 1;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(245, 294);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Order";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 345);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.mstControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PizzaOrderForm";
            this.Text = "Papa Johns Pizza";
            this.mstControl.ResumeLayout(false);
            this.mstPizza.ResumeLayout(false);
            this.mstPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.mstBeverages.ResumeLayout(false);
            this.mstBeverages.PerformLayout();
            this.mstSidesDesserts.ResumeLayout(false);
            this.mstSidesDesserts.PerformLayout();
            this.mstCustomerInfo.ResumeLayout(false);
            this.mstCustomerInfo.PerformLayout();
            this.mstOrder.ResumeLayout(false);
            this.mstOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mstControl;
        private System.Windows.Forms.TabPage mstPizza;
        private System.Windows.Forms.TabPage mstBeverages;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TabPage mstSidesDesserts;
        private System.Windows.Forms.Label lblPizzaSelection;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckedListBox ckLstToppings;
        private System.Windows.Forms.ComboBox cmbPizzaType;
        private System.Windows.Forms.Label lblPizzaType;
        private System.Windows.Forms.ComboBox cmbPizzaQuantity;
        private System.Windows.Forms.Label lblPizzaQuantity;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtDrPepperQuantity;
        private System.Windows.Forms.TextBox txtMugRootBeerQuantity;
        private System.Windows.Forms.TextBox txtMtnDewCodeRedQuantity;
        private System.Windows.Forms.TextBox txtSpriteQuantity;
        private System.Windows.Forms.TextBox txtMtnDewOriginalQuantity;
        private System.Windows.Forms.ListBox lstBeverages;
        private System.Windows.Forms.Label lblBeverages;
        private System.Windows.Forms.Label lblBeverageQuantity;
        private System.Windows.Forms.TabPage mstCustomerInfo;
        private System.Windows.Forms.ComboBox cmbCreditCardType;
        private System.Windows.Forms.TextBox txtCreditCard;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstCustomerInfo;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblDesertQuantity;
        private System.Windows.Forms.TextBox txtCinnamonPullApartsQuantity;
        private System.Windows.Forms.TextBox txtCarmelChocolateChipQuantity;
        private System.Windows.Forms.TextBox txtBrownieQuantity;
        private System.Windows.Forms.TextBox txtChocolateChipQuantity;
        private System.Windows.Forms.ListBox lstDessertsSides;
        private System.Windows.Forms.Label lblDesserts;
        private System.Windows.Forms.TextBox txtCheeseSticksQuantity;
        private System.Windows.Forms.Label lblDessertWarning;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabPage mstOrder;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblBeverageWarning;
    }
}

