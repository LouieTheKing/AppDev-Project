namespace OctoBoiz
{
    partial class frmProductEditor
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
            this.lblProductEditor = new System.Windows.Forms.Label();
            this.pictboxProductPhoto = new System.Windows.Forms.PictureBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductConfirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxProductPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductEditor
            // 
            this.lblProductEditor.AutoSize = true;
            this.lblProductEditor.Location = new System.Drawing.Point(13, 13);
            this.lblProductEditor.Name = "lblProductEditor";
            this.lblProductEditor.Size = new System.Drawing.Size(104, 13);
            this.lblProductEditor.TabIndex = 0;
            this.lblProductEditor.Text = "PRODUCT EDITOR";
            // 
            // pictboxProductPhoto
            // 
            this.pictboxProductPhoto.Location = new System.Drawing.Point(16, 30);
            this.pictboxProductPhoto.Name = "pictboxProductPhoto";
            this.pictboxProductPhoto.Size = new System.Drawing.Size(140, 126);
            this.pictboxProductPhoto.TabIndex = 1;
            this.pictboxProductPhoto.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(181, 45);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(176, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(178, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(181, 92);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(294, 211);
            this.txtProductDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name:";
            // 
            // btnProductConfirm
            // 
            this.btnProductConfirm.Location = new System.Drawing.Point(389, 320);
            this.btnProductConfirm.Name = "btnProductConfirm";
            this.btnProductConfirm.Size = new System.Drawing.Size(86, 26);
            this.btnProductConfirm.TabIndex = 6;
            this.btnProductConfirm.Text = "CONFIRM";
            this.btnProductConfirm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(13, 171);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(34, 13);
            this.lblProductPrice.TabIndex = 8;
            this.lblProductPrice.Text = "Price:";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(13, 223);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(92, 13);
            this.lblProductCategory.TabIndex = 10;
            this.lblProductCategory.Text = "Product Category:";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(16, 243);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(140, 20);
            this.txtProductCategory.TabIndex = 9;
            // 
            // frmProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 360);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.txtProductCategory);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnProductConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.pictboxProductPhoto);
            this.Controls.Add(this.lblProductEditor);
            this.Name = "frmProductEditor";
            this.Text = "ProductEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictboxProductPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductEditor;
        private System.Windows.Forms.PictureBox pictboxProductPhoto;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox txtProductCategory;
    }
}