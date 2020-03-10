namespace EFDeneme
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
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCategoriedProd = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstProducts
            // 
            this.lstProducts.DisplayMember = "ProductName";
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(35, 79);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(303, 199);
            this.lstProducts.TabIndex = 0;
            // 
            // lstCategories
            // 
            this.lstCategories.DisplayMember = "CategoryName";
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(417, 79);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(294, 199);
            this.lstCategories.TabIndex = 1;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategoriler";
            // 
            // lstCategoriedProd
            // 
            this.lstCategoriedProd.DisplayMember = "ProductName, UnitPrice";
            this.lstCategoriedProd.FormattingEnabled = true;
            this.lstCategoriedProd.Location = new System.Drawing.Point(35, 334);
            this.lstCategoriedProd.Name = "lstCategoriedProd";
            this.lstCategoriedProd.Size = new System.Drawing.Size(303, 199);
            this.lstCategoriedProd.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 558);
            this.Controls.Add(this.lstCategoriedProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lstProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCategoriedProd;
    }
}

