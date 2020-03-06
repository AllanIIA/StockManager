namespace StockManager.WF
{
    partial class FormManageLeavingStock
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
            this.listBoxLeavingStock = new System.Windows.Forms.ListBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductStockedQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductLeavingQuantity = new System.Windows.Forms.TextBox();
            this.labelManageLeavingStock = new System.Windows.Forms.Label();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLeavingStock
            // 
            this.listBoxLeavingStock.FormattingEnabled = true;
            this.listBoxLeavingStock.Location = new System.Drawing.Point(30, 25);
            this.listBoxLeavingStock.Name = "listBoxLeavingStock";
            this.listBoxLeavingStock.Size = new System.Drawing.Size(174, 394);
            this.listBoxLeavingStock.TabIndex = 1;
            this.listBoxLeavingStock.SelectedIndexChanged += new System.EventHandler(this.listBoxLeavingStock_SelectedIndexChanged);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(251, 112);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(118, 20);
            this.labelProductName.TabIndex = 17;
            this.labelProductName.Text = "Nom du Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantité à Sortir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantité Stockée";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(390, 114);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 20;
            // 
            // textBoxProductStockedQuantity
            // 
            this.textBoxProductStockedQuantity.Location = new System.Drawing.Point(390, 155);
            this.textBoxProductStockedQuantity.Name = "textBoxProductStockedQuantity";
            this.textBoxProductStockedQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductStockedQuantity.TabIndex = 21;
            // 
            // textBoxProductLeavingQuantity
            // 
            this.textBoxProductLeavingQuantity.Location = new System.Drawing.Point(390, 194);
            this.textBoxProductLeavingQuantity.Name = "textBoxProductLeavingQuantity";
            this.textBoxProductLeavingQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductLeavingQuantity.TabIndex = 22;
            // 
            // labelManageLeavingStock
            // 
            this.labelManageLeavingStock.AutoSize = true;
            this.labelManageLeavingStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageLeavingStock.ForeColor = System.Drawing.Color.Red;
            this.labelManageLeavingStock.Location = new System.Drawing.Point(272, 25);
            this.labelManageLeavingStock.Name = "labelManageLeavingStock";
            this.labelManageLeavingStock.Size = new System.Drawing.Size(292, 25);
            this.labelManageLeavingStock.TabIndex = 23;
            this.labelManageLeavingStock.Text = "Gestion des Sorties de Stock";
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Location = new System.Drawing.Point(367, 317);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(123, 23);
            this.buttonUpdateStock.TabIndex = 24;
            this.buttonUpdateStock.Text = "Mettre à jour";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // FormManageLeavingStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateStock);
            this.Controls.Add(this.labelManageLeavingStock);
            this.Controls.Add(this.textBoxProductLeavingQuantity);
            this.Controls.Add(this.textBoxProductStockedQuantity);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.listBoxLeavingStock);
            this.Name = "FormManageLeavingStock";
            this.Text = "FormManageLeavingStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLeavingStock;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductStockedQuantity;
        private System.Windows.Forms.TextBox textBoxProductLeavingQuantity;
        private System.Windows.Forms.Label labelManageLeavingStock;
        private System.Windows.Forms.Button buttonUpdateStock;
    }
}