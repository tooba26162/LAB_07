namespace Lab_07_activity2_
{
    partial class Form1
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
            this.cmbPizzaSize = new System.Windows.Forms.ComboBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.rdoThickCrust = new System.Windows.Forms.RadioButton();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.grpCrustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPizzaSize
            // 
            this.cmbPizzaSize.FormattingEnabled = true;
            this.cmbPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbPizzaSize.Location = new System.Drawing.Point(301, 18);
            this.cmbPizzaSize.Name = "cmbPizzaSize";
            this.cmbPizzaSize.Size = new System.Drawing.Size(121, 21);
            this.cmbPizzaSize.TabIndex = 0;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(241, 60);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(62, 17);
            this.chkCheese.TabIndex = 1;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(311, 60);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 2;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(391, 60);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 3;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // grpCrustType
            // 
            this.grpCrustType.Controls.Add(this.rdoThickCrust);
            this.grpCrustType.Controls.Add(this.rdoThinCrust);
            this.grpCrustType.Location = new System.Drawing.Point(271, 92);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(200, 100);
            this.grpCrustType.TabIndex = 4;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type";
            // 
            // rdoThinCrust
            // 
            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Location = new System.Drawing.Point(7, 19);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rdoThinCrust.TabIndex = 0;
            this.rdoThinCrust.TabStop = true;
            this.rdoThinCrust.Text = "Thin Crust";
            this.rdoThinCrust.UseVisualStyleBackColor = true;
            // 
            // rdoThickCrust
            // 
            this.rdoThickCrust.AutoSize = true;
            this.rdoThickCrust.Location = new System.Drawing.Point(7, 44);
            this.rdoThickCrust.Name = "rdoThickCrust";
            this.rdoThickCrust.Size = new System.Drawing.Size(79, 17);
            this.rdoThickCrust.TabIndex = 1;
            this.rdoThickCrust.TabStop = true;
            this.rdoThickCrust.Text = "Thick Crust";
            this.rdoThickCrust.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(396, 198);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(351, 248);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(34, 13);
            this.lblOrderSummary.TabIndex = 6;
            this.lblOrderSummary.Text = "Hello!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.chkMushrooms);
            this.Controls.Add(this.chkPepperoni);
            this.Controls.Add(this.chkCheese);
            this.Controls.Add(this.cmbPizzaSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPizzaSize;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.RadioButton rdoThickCrust;
        private System.Windows.Forms.RadioButton rdoThinCrust;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblOrderSummary;
    }
}

