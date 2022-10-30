namespace CST_150_Milestone4._0
{
    partial class reorderFrm
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
            this.supplierTxt = new System.Windows.Forms.TextBox();
            this.supplierLbl = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.skuTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.skuLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplierTxt
            // 
            this.supplierTxt.Location = new System.Drawing.Point(76, 122);
            this.supplierTxt.Name = "supplierTxt";
            this.supplierTxt.Size = new System.Drawing.Size(100, 20);
            this.supplierTxt.TabIndex = 17;
            // 
            // supplierLbl
            // 
            this.supplierLbl.AutoSize = true;
            this.supplierLbl.Location = new System.Drawing.Point(15, 129);
            this.supplierLbl.Name = "supplierLbl";
            this.supplierLbl.Size = new System.Drawing.Size(48, 13);
            this.supplierLbl.TabIndex = 16;
            this.supplierLbl.Text = "Supplier:";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(70, 200);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 15;
            this.orderBtn.Text = "Place Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(76, 90);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(100, 20);
            this.quantityTxt.TabIndex = 14;
            // 
            // skuTxt
            // 
            this.skuTxt.Location = new System.Drawing.Point(76, 58);
            this.skuTxt.Name = "skuTxt";
            this.skuTxt.Size = new System.Drawing.Size(100, 20);
            this.skuTxt.TabIndex = 13;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(76, 27);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 12;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(15, 97);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(49, 13);
            this.quantityLbl.TabIndex = 11;
            this.quantityLbl.Text = "Quantity:";
            // 
            // skuLbl
            // 
            this.skuLbl.AutoSize = true;
            this.skuLbl.Location = new System.Drawing.Point(15, 65);
            this.skuLbl.Name = "skuLbl";
            this.skuLbl.Size = new System.Drawing.Size(55, 13);
            this.skuLbl.TabIndex = 10;
            this.skuLbl.Text = "Item SKU:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(15, 34);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Name:";
            // 
            // reorderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 247);
            this.Controls.Add(this.supplierTxt);
            this.Controls.Add(this.supplierLbl);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.skuTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.skuLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "reorderFrm";
            this.Text = "Reorder Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supplierTxt;
        private System.Windows.Forms.Label supplierLbl;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox skuTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label skuLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}