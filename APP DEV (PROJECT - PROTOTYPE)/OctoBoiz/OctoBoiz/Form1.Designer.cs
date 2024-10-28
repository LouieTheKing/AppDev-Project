namespace OctoBoiz
{
    partial class frmInventoryEditor
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
            this.btnInventoryConfirm = new System.Windows.Forms.Button();
            this.lblInventoryEditor = new System.Windows.Forms.Label();
            this.txtEngridientsName = new System.Windows.Forms.TextBox();
            this.lblEngridientsName = new System.Windows.Forms.Label();
            this.txtInventoryQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEngridientsCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnInventoryConfirm
            // 
            this.btnInventoryConfirm.Location = new System.Drawing.Point(251, 219);
            this.btnInventoryConfirm.Name = "btnInventoryConfirm";
            this.btnInventoryConfirm.Size = new System.Drawing.Size(79, 29);
            this.btnInventoryConfirm.TabIndex = 0;
            this.btnInventoryConfirm.Text = "CONFIRM";
            this.btnInventoryConfirm.UseVisualStyleBackColor = true;
            // 
            // lblInventoryEditor
            // 
            this.lblInventoryEditor.AutoSize = true;
            this.lblInventoryEditor.Location = new System.Drawing.Point(13, 20);
            this.lblInventoryEditor.Name = "lblInventoryEditor";
            this.lblInventoryEditor.Size = new System.Drawing.Size(114, 13);
            this.lblInventoryEditor.TabIndex = 1;
            this.lblInventoryEditor.Text = "INVENTORY EDITOR";
            // 
            // txtEngridientsName
            // 
            this.txtEngridientsName.Location = new System.Drawing.Point(16, 63);
            this.txtEngridientsName.Name = "txtEngridientsName";
            this.txtEngridientsName.Size = new System.Drawing.Size(196, 20);
            this.txtEngridientsName.TabIndex = 2;
            // 
            // lblEngridientsName
            // 
            this.lblEngridientsName.AutoSize = true;
            this.lblEngridientsName.Location = new System.Drawing.Point(16, 44);
            this.lblEngridientsName.Name = "lblEngridientsName";
            this.lblEngridientsName.Size = new System.Drawing.Size(93, 13);
            this.lblEngridientsName.TabIndex = 3;
            this.lblEngridientsName.Text = "Engridients Name:";
            // 
            // txtInventoryQuantity
            // 
            this.txtInventoryQuantity.Location = new System.Drawing.Point(233, 63);
            this.txtInventoryQuantity.Name = "txtInventoryQuantity";
            this.txtInventoryQuantity.Size = new System.Drawing.Size(97, 20);
            this.txtInventoryQuantity.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(230, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Engridients Category:";
            // 
            // cmbEngridientsCategory
            // 
            this.cmbEngridientsCategory.FormattingEnabled = true;
            this.cmbEngridientsCategory.Items.AddRange(new object[] {
            "Bonito Flakes ",
            "Aonori",
            "Chili Powder",
            "Red Sauce",
            "Japanese Mayo",
            "Octopus ",
            "Ham and Cheese",
            "Japanese flour",
            "Egg",
            "Dried Shrimp",
            "Spring Onion"});
            this.cmbEngridientsCategory.Location = new System.Drawing.Point(16, 116);
            this.cmbEngridientsCategory.Name = "cmbEngridientsCategory";
            this.cmbEngridientsCategory.Size = new System.Drawing.Size(196, 21);
            this.cmbEngridientsCategory.TabIndex = 7;
            // 
            // frmInventoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 277);
            this.Controls.Add(this.cmbEngridientsCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtInventoryQuantity);
            this.Controls.Add(this.lblEngridientsName);
            this.Controls.Add(this.txtEngridientsName);
            this.Controls.Add(this.lblInventoryEditor);
            this.Controls.Add(this.btnInventoryConfirm);
            this.Name = "frmInventoryEditor";
            this.Text = "Inventory Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryConfirm;
        private System.Windows.Forms.Label lblInventoryEditor;
        private System.Windows.Forms.TextBox txtEngridientsName;
        private System.Windows.Forms.Label lblEngridientsName;
        private System.Windows.Forms.TextBox txtInventoryQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEngridientsCategory;
    }
}

