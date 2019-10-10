namespace Lab_4_1
{
    partial class realEstateCalculator
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
            this.components = new System.ComponentModel.Container();
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.saleDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.propertyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.countyGroupBox = new System.Windows.Forms.GroupBox();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsborroughRadioButton = new System.Windows.Forms.RadioButton();
            this.propertyPriceLabel = new System.Windows.Forms.Label();
            this.propertyPriceTextBox = new System.Windows.Forms.TextBox();
            this.updatePropertyPriceButton = new System.Windows.Forms.Button();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.CountyLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.commissionPriceLabel = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.updateToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.propertyTypeGroupBox.SuspendLayout();
            this.countyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.Location = new System.Drawing.Point(81, 11);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(68, 21);
            this.saleDateLabel.TabIndex = 0;
            this.saleDateLabel.Text = "Sale Date :";
            // 
            // saleDateMaskedTextBox
            // 
            this.saleDateMaskedTextBox.Location = new System.Drawing.Point(155, 12);
            this.saleDateMaskedTextBox.Mask = "00/00/0000";
            this.saleDateMaskedTextBox.Name = "saleDateMaskedTextBox";
            this.saleDateMaskedTextBox.Size = new System.Drawing.Size(74, 20);
            this.saleDateMaskedTextBox.TabIndex = 1;
            this.saleDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // propertyTypeGroupBox
            // 
            this.propertyTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.residentialRadioButton);
            this.propertyTypeGroupBox.Location = new System.Drawing.Point(84, 38);
            this.propertyTypeGroupBox.Name = "propertyTypeGroupBox";
            this.propertyTypeGroupBox.Size = new System.Drawing.Size(145, 79);
            this.propertyTypeGroupBox.TabIndex = 2;
            this.propertyTypeGroupBox.TabStop = false;
            this.propertyTypeGroupBox.Text = "Property Type ";
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(36, 53);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(79, 17);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(36, 30);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(80, 17);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential ";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // countyGroupBox
            // 
            this.countyGroupBox.Controls.Add(this.polkRadioButton);
            this.countyGroupBox.Controls.Add(this.pascoRadioButton);
            this.countyGroupBox.Controls.Add(this.hillsborroughRadioButton);
            this.countyGroupBox.Location = new System.Drawing.Point(84, 123);
            this.countyGroupBox.Name = "countyGroupBox";
            this.countyGroupBox.Size = new System.Drawing.Size(145, 91);
            this.countyGroupBox.TabIndex = 3;
            this.countyGroupBox.TabStop = false;
            this.countyGroupBox.Text = "County ";
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.AutoSize = true;
            this.polkRadioButton.Location = new System.Drawing.Point(36, 65);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(49, 17);
            this.polkRadioButton.TabIndex = 4;
            this.polkRadioButton.Text = "Polk ";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(36, 42);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(55, 17);
            this.pascoRadioButton.TabIndex = 1;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            this.pascoRadioButton.CheckedChanged += new System.EventHandler(this.pascoRadioButton_CheckedChanged);
            // 
            // hillsborroughRadioButton
            // 
            this.hillsborroughRadioButton.AutoSize = true;
            this.hillsborroughRadioButton.Checked = true;
            this.hillsborroughRadioButton.Location = new System.Drawing.Point(36, 19);
            this.hillsborroughRadioButton.Name = "hillsborroughRadioButton";
            this.hillsborroughRadioButton.Size = new System.Drawing.Size(86, 17);
            this.hillsborroughRadioButton.TabIndex = 0;
            this.hillsborroughRadioButton.TabStop = true;
            this.hillsborroughRadioButton.Text = "Hillsborrough";
            this.hillsborroughRadioButton.UseVisualStyleBackColor = true;
            this.hillsborroughRadioButton.CheckedChanged += new System.EventHandler(this.hillsborroughRadioButton_CheckedChanged);
            // 
            // propertyPriceLabel
            // 
            this.propertyPriceLabel.Location = new System.Drawing.Point(69, 226);
            this.propertyPriceLabel.Name = "propertyPriceLabel";
            this.propertyPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyPriceLabel.TabIndex = 4;
            this.propertyPriceLabel.Text = "Property Price :";
            // 
            // propertyPriceTextBox
            // 
            this.propertyPriceTextBox.Location = new System.Drawing.Point(183, 226);
            this.propertyPriceTextBox.Name = "propertyPriceTextBox";
            this.propertyPriceTextBox.Size = new System.Drawing.Size(74, 20);
            this.propertyPriceTextBox.TabIndex = 5;
            this.propertyPriceTextBox.TextChanged += new System.EventHandler(this.propertyPriceTextBox_TextChanged);
            // 
            // updatePropertyPriceButton
            // 
            this.updatePropertyPriceButton.Location = new System.Drawing.Point(72, 262);
            this.updatePropertyPriceButton.Name = "updatePropertyPriceButton";
            this.updatePropertyPriceButton.Size = new System.Drawing.Size(181, 23);
            this.updatePropertyPriceButton.TabIndex = 6;
            this.updatePropertyPriceButton.Text = "&Update Property Price";
            this.exitToolTip.SetToolTip(this.updatePropertyPriceButton, "Use this button to update property price\r\n");
            this.updatePropertyPriceButton.UseVisualStyleBackColor = true;
            this.updatePropertyPriceButton.Click += new System.EventHandler(this.updatePropertyPriceButton_Click);
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.Location = new System.Drawing.Point(49, 309);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.stateTaxLabel.TabIndex = 7;
            this.stateTaxLabel.Text = "State Sales Tax :";
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(171, 309);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(82, 23);
            this.stateSalesTaxLabel.TabIndex = 8;
            // 
            // CountyLabel
            // 
            this.CountyLabel.Location = new System.Drawing.Point(49, 342);
            this.CountyLabel.Name = "CountyLabel";
            this.CountyLabel.Size = new System.Drawing.Size(100, 23);
            this.CountyLabel.TabIndex = 9;
            this.CountyLabel.Text = "County Sales Tax :";
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(171, 343);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(82, 23);
            this.countySalesTaxLabel.TabIndex = 10;
            // 
            // commissionPriceLabel
            // 
            this.commissionPriceLabel.Location = new System.Drawing.Point(49, 380);
            this.commissionPriceLabel.Name = "commissionPriceLabel";
            this.commissionPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.commissionPriceLabel.TabIndex = 11;
            this.commissionPriceLabel.Text = "Commission :";
            // 
            // commissionLabel
            // 
            this.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionLabel.Location = new System.Drawing.Point(171, 380);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(82, 23);
            this.commissionLabel.TabIndex = 12;
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(185, 417);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(68, 3);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(49, 428);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "Total Price :";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(171, 428);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(82, 23);
            this.totalPriceLabel.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(12, 468);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.saveToolTip.SetToolTip(this.saveButton, "Use this button to write property data to a file \r\n");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(111, 468);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "&Clear";
            this.clearToolTip.SetToolTip(this.clearButton, "Use this button to clear the form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(209, 468);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "E&xit";
            this.exitToolTip.SetToolTip(this.exitButton, "Use this button to close the form \r\n");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // updateToolTip
            // 
            this.updateToolTip.ToolTipTitle = "Update";
            // 
            // realEstateCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 503);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.commissionPriceLabel);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.CountyLabel);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.updatePropertyPriceButton);
            this.Controls.Add(this.propertyPriceTextBox);
            this.Controls.Add(this.propertyPriceLabel);
            this.Controls.Add(this.countyGroupBox);
            this.Controls.Add(this.propertyTypeGroupBox);
            this.Controls.Add(this.saleDateMaskedTextBox);
            this.Controls.Add(this.saleDateLabel);
            this.Name = "realEstateCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Estate Calculator";
            this.Load += new System.EventHandler(this.realEstateCalculator_Load);
            this.propertyTypeGroupBox.ResumeLayout(false);
            this.propertyTypeGroupBox.PerformLayout();
            this.countyGroupBox.ResumeLayout(false);
            this.countyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.MaskedTextBox saleDateMaskedTextBox;
        private System.Windows.Forms.GroupBox propertyTypeGroupBox;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.GroupBox countyGroupBox;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton hillsborroughRadioButton;
        private System.Windows.Forms.Label propertyPriceLabel;
        private System.Windows.Forms.TextBox propertyPriceTextBox;
        private System.Windows.Forms.Button updatePropertyPriceButton;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label CountyLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label commissionPriceLabel;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip updateToolTip;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
    }
}

