namespace ResterauntBillingSystem
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
            this.lblTextTableNumber = new System.Windows.Forms.Label();
            this.cbxTableNumber = new System.Windows.Forms.ComboBox();
            this.lblTextMembership = new System.Windows.Forms.Label();
            this.cbxMembership = new System.Windows.Forms.ComboBox();
            this.lblTextitem = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.lblTextQuantity = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lsbItems = new System.Windows.Forms.ListBox();
            this.lblTextSubTotal = new System.Windows.Forms.Label();
            this.lblTextDiscount = new System.Windows.Forms.Label();
            this.lblTextGST = new System.Windows.Forms.Label();
            this.lblTextTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRecieptSaved = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimeDate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextTableNumber
            // 
            this.lblTextTableNumber.AutoSize = true;
            this.lblTextTableNumber.Location = new System.Drawing.Point(12, 54);
            this.lblTextTableNumber.Name = "lblTextTableNumber";
            this.lblTextTableNumber.Size = new System.Drawing.Size(77, 13);
            this.lblTextTableNumber.TabIndex = 0;
            this.lblTextTableNumber.Text = "Table Number:";
            // 
            // cbxTableNumber
            // 
            this.cbxTableNumber.FormattingEnabled = true;
            this.cbxTableNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbxTableNumber.Location = new System.Drawing.Point(95, 51);
            this.cbxTableNumber.Name = "cbxTableNumber";
            this.cbxTableNumber.Size = new System.Drawing.Size(77, 21);
            this.cbxTableNumber.TabIndex = 1;
            // 
            // lblTextMembership
            // 
            this.lblTextMembership.AutoSize = true;
            this.lblTextMembership.Location = new System.Drawing.Point(12, 87);
            this.lblTextMembership.Name = "lblTextMembership";
            this.lblTextMembership.Size = new System.Drawing.Size(70, 13);
            this.lblTextMembership.TabIndex = 2;
            this.lblTextMembership.Text = "Membership: ";
            // 
            // cbxMembership
            // 
            this.cbxMembership.FormattingEnabled = true;
            this.cbxMembership.Items.AddRange(new object[] {
            "REGULAR",
            "GOLD CLASS",
            "N/A"});
            this.cbxMembership.Location = new System.Drawing.Point(95, 84);
            this.cbxMembership.Name = "cbxMembership";
            this.cbxMembership.Size = new System.Drawing.Size(121, 21);
            this.cbxMembership.TabIndex = 3;
            // 
            // lblTextitem
            // 
            this.lblTextitem.AutoSize = true;
            this.lblTextitem.Location = new System.Drawing.Point(49, 121);
            this.lblTextitem.Name = "lblTextitem";
            this.lblTextitem.Size = new System.Drawing.Size(33, 13);
            this.lblTextitem.TabIndex = 4;
            this.lblTextitem.Text = "Item: ";
            // 
            // cbxItem
            // 
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(95, 113);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(164, 21);
            this.cbxItem.TabIndex = 5;
            // 
            // lblTextQuantity
            // 
            this.lblTextQuantity.AutoSize = true;
            this.lblTextQuantity.Location = new System.Drawing.Point(294, 119);
            this.lblTextQuantity.Name = "lblTextQuantity";
            this.lblTextQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblTextQuantity.TabIndex = 6;
            this.lblTextQuantity.Text = "Quantity:";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cbxQuantity.Location = new System.Drawing.Point(349, 116);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(73, 21);
            this.cbxQuantity.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(428, 114);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(116, 23);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "Add to Items List";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lsbItems
            // 
            this.lsbItems.FormattingEnabled = true;
            this.lsbItems.Location = new System.Drawing.Point(18, 173);
            this.lsbItems.Name = "lsbItems";
            this.lsbItems.Size = new System.Drawing.Size(266, 238);
            this.lsbItems.TabIndex = 9;
            this.lsbItems.SelectedIndexChanged += new System.EventHandler(this.lsbItems_SelectedIndexChanged);
            // 
            // lblTextSubTotal
            // 
            this.lblTextSubTotal.AutoSize = true;
            this.lblTextSubTotal.Location = new System.Drawing.Point(307, 182);
            this.lblTextSubTotal.Name = "lblTextSubTotal";
            this.lblTextSubTotal.Size = new System.Drawing.Size(56, 13);
            this.lblTextSubTotal.TabIndex = 10;
            this.lblTextSubTotal.Text = "Sub-Total:";
            // 
            // lblTextDiscount
            // 
            this.lblTextDiscount.AutoSize = true;
            this.lblTextDiscount.Location = new System.Drawing.Point(307, 206);
            this.lblTextDiscount.Name = "lblTextDiscount";
            this.lblTextDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblTextDiscount.TabIndex = 11;
            this.lblTextDiscount.Text = "Discount:";
            // 
            // lblTextGST
            // 
            this.lblTextGST.AutoSize = true;
            this.lblTextGST.Location = new System.Drawing.Point(327, 232);
            this.lblTextGST.Name = "lblTextGST";
            this.lblTextGST.Size = new System.Drawing.Size(32, 13);
            this.lblTextGST.TabIndex = 12;
            this.lblTextGST.Text = "GST:";
            // 
            // lblTextTotal
            // 
            this.lblTextTotal.AutoSize = true;
            this.lblTextTotal.Location = new System.Drawing.Point(325, 255);
            this.lblTextTotal.Name = "lblTextTotal";
            this.lblTextTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTextTotal.TabIndex = 13;
            this.lblTextTotal.Text = "Total:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(369, 182);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(19, 13);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "$0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(369, 206);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(19, 13);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "$0";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(369, 232);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(19, 13);
            this.lblGST.TabIndex = 16;
            this.lblGST.Text = "$0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(369, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "$0";
            // 
            // lblRecieptSaved
            // 
            this.lblRecieptSaved.AutoSize = true;
            this.lblRecieptSaved.Location = new System.Drawing.Point(290, 382);
            this.lblRecieptSaved.Name = "lblRecieptSaved";
            this.lblRecieptSaved.Size = new System.Drawing.Size(140, 13);
            this.lblRecieptSaved.TabIndex = 18;
            this.lblRecieptSaved.Text = "Reciept Saved Successfully";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(330, 289);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimeDate
            // 
            this.btnTimeDate.Location = new System.Drawing.Point(290, 318);
            this.btnTimeDate.Name = "btnTimeDate";
            this.btnTimeDate.Size = new System.Drawing.Size(152, 23);
            this.btnTimeDate.TabIndex = 20;
            this.btnTimeDate.Text = "Time and Date of Order";
            this.btnTimeDate.UseVisualStyleBackColor = true;
            this.btnTimeDate.Click += new System.EventHandler(this.btnTimeDate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(310, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Reciept";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(555, 467);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTimeDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblRecieptSaved);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTextTotal);
            this.Controls.Add(this.lblTextGST);
            this.Controls.Add(this.lblTextDiscount);
            this.Controls.Add(this.lblTextSubTotal);
            this.Controls.Add(this.lsbItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cbxQuantity);
            this.Controls.Add(this.lblTextQuantity);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.lblTextitem);
            this.Controls.Add(this.cbxMembership);
            this.Controls.Add(this.lblTextMembership);
            this.Controls.Add(this.cbxTableNumber);
            this.Controls.Add(this.lblTextTableNumber);
            this.Name = "Form1";
            this.Text = "Ordering Software (Final)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextTableNumber;
        private System.Windows.Forms.ComboBox cbxTableNumber;
        private System.Windows.Forms.Label lblTextMembership;
        private System.Windows.Forms.ComboBox cbxMembership;
        private System.Windows.Forms.Label lblTextitem;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label lblTextQuantity;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lsbItems;
        private System.Windows.Forms.Label lblTextSubTotal;
        private System.Windows.Forms.Label lblTextDiscount;
        private System.Windows.Forms.Label lblTextGST;
        private System.Windows.Forms.Label lblTextTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRecieptSaved;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTimeDate;
        private System.Windows.Forms.Button btnSave;
    }
}

