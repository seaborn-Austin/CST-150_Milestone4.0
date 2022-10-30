namespace CST_150_Milestone4._0
{
    partial class inventoryFrm
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
            this.restockBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.itemSkuTxt = new System.Windows.Forms.TextBox();
            this.itemSkuLbl = new System.Windows.Forms.Label();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSKU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventoryAddLbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restockBtn
            // 
            this.restockBtn.Location = new System.Drawing.Point(180, 130);
            this.restockBtn.Name = "restockBtn";
            this.restockBtn.Size = new System.Drawing.Size(75, 23);
            this.restockBtn.TabIndex = 42;
            this.restockBtn.Text = "Restock";
            this.restockBtn.UseVisualStyleBackColor = true;
            this.restockBtn.Click += new System.EventHandler(this.restockBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(453, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 41;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(320, 9);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(127, 20);
            this.searchTxt.TabIndex = 40;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(225, 16);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(89, 13);
            this.searchLbl.TabIndex = 39;
            this.searchLbl.Text = "Search by Name:";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(99, 130);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 38;
            this.removeBtn.Text = "Remove row";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(64, 84);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(100, 20);
            this.quantityTxt.TabIndex = 37;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(9, 91);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 36;
            this.quantityLbl.Text = "Quantity:";
            // 
            // itemSkuTxt
            // 
            this.itemSkuTxt.Location = new System.Drawing.Point(70, 45);
            this.itemSkuTxt.Name = "itemSkuTxt";
            this.itemSkuTxt.Size = new System.Drawing.Size(100, 20);
            this.itemSkuTxt.TabIndex = 35;
            // 
            // itemSkuLbl
            // 
            this.itemSkuLbl.AutoSize = true;
            this.itemSkuLbl.Location = new System.Drawing.Point(9, 52);
            this.itemSkuLbl.Name = "itemSkuLbl";
            this.itemSkuLbl.Size = new System.Drawing.Size(55, 13);
            this.itemSkuLbl.TabIndex = 34;
            this.itemSkuLbl.Text = "Item SKU:";
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(74, 9);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(100, 20);
            this.itemNameTxt.TabIndex = 33;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.BackColor = System.Drawing.SystemColors.Control;
            this.itemNameLbl.Location = new System.Drawing.Point(9, 16);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(59, 13);
            this.itemNameLbl.TabIndex = 32;
            this.itemNameLbl.Text = "Item name:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.itemSKU,
            this.quantity});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 245);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Name";
            this.itemName.Width = 150;
            // 
            // itemSKU
            // 
            this.itemSKU.Text = "SKU";
            this.itemSKU.Width = 150;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 150;
            // 
            // inventoryAddLbl
            // 
            this.inventoryAddLbl.AutoSize = true;
            this.inventoryAddLbl.Location = new System.Drawing.Point(30, 130);
            this.inventoryAddLbl.Name = "inventoryAddLbl";
            this.inventoryAddLbl.Size = new System.Drawing.Size(0, 13);
            this.inventoryAddLbl.TabIndex = 30;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(18, 130);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 29;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // inventoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CST_150_Milestone4._0.Properties.Resources.produce;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.restockBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.itemSkuTxt);
            this.Controls.Add(this.itemSkuLbl);
            this.Controls.Add(this.itemNameTxt);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.inventoryAddLbl);
            this.Controls.Add(this.addItemBtn);
            this.Name = "inventoryFrm";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.inventoryFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restockBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox itemSkuTxt;
        private System.Windows.Forms.Label itemSkuLbl;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemSKU;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.Label inventoryAddLbl;
        private System.Windows.Forms.Button addItemBtn;
    }
}

