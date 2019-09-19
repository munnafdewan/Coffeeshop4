namespace Coffeeshop
{
    partial class addButton
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
            this.customerInformation = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.contuctNo = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.quantityCoffee = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.customerContuctNo = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.customerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInformation
            // 
            this.customerInformation.Controls.Add(this.showButton);
            this.customerInformation.Controls.Add(this.quantity);
            this.customerInformation.Controls.Add(this.order);
            this.customerInformation.Controls.Add(this.address);
            this.customerInformation.Controls.Add(this.contuctNo);
            this.customerInformation.Controls.Add(this.customerName);
            this.customerInformation.Controls.Add(this.button);
            this.customerInformation.Controls.Add(this.quantityCoffee);
            this.customerInformation.Controls.Add(this.orderComboBox);
            this.customerInformation.Controls.Add(this.customerAddress);
            this.customerInformation.Controls.Add(this.customerContuctNo);
            this.customerInformation.Controls.Add(this.customerNameBox);
            this.customerInformation.Location = new System.Drawing.Point(12, 12);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.Size = new System.Drawing.Size(283, 277);
            this.customerInformation.TabIndex = 0;
            this.customerInformation.TabStop = false;
            this.customerInformation.Text = "Customer Information";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(96, 248);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(46, 213);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 13);
            this.quantity.TabIndex = 10;
            this.quantity.Text = "Quantity";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(46, 163);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(33, 13);
            this.order.TabIndex = 9;
            this.order.Text = "Order";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(46, 121);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 8;
            this.address.Text = "Address";
            // 
            // contuctNo
            // 
            this.contuctNo.AutoSize = true;
            this.contuctNo.Location = new System.Drawing.Point(46, 83);
            this.contuctNo.Name = "contuctNo";
            this.contuctNo.Size = new System.Drawing.Size(61, 13);
            this.contuctNo.TabIndex = 7;
            this.contuctNo.Text = "Contuct No";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(46, 42);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(82, 13);
            this.customerName.TabIndex = 6;
            this.customerName.Text = "Customer Name";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(193, 248);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Add";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // quantityCoffee
            // 
            this.quantityCoffee.Location = new System.Drawing.Point(161, 210);
            this.quantityCoffee.Name = "quantityCoffee";
            this.quantityCoffee.Size = new System.Drawing.Size(107, 20);
            this.quantityCoffee.TabIndex = 4;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(161, 160);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(107, 21);
            this.orderComboBox.TabIndex = 3;
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(161, 114);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(107, 20);
            this.customerAddress.TabIndex = 2;
            // 
            // customerContuctNo
            // 
            this.customerContuctNo.Location = new System.Drawing.Point(161, 76);
            this.customerContuctNo.Name = "customerContuctNo";
            this.customerContuctNo.Size = new System.Drawing.Size(107, 20);
            this.customerContuctNo.TabIndex = 1;
            // 
            // customerNameBox
            // 
            this.customerNameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerNameBox.Location = new System.Drawing.Point(161, 38);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(107, 20);
            this.customerNameBox.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(445, 31);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(250, 257);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // addButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.customerInformation);
            this.Name = "addButton";
            this.Text = "Coffeshop";
            this.customerInformation.ResumeLayout(false);
            this.customerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerInformation;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label contuctNo;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox quantityCoffee;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.TextBox customerContuctNo;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button showButton;
    }
}

