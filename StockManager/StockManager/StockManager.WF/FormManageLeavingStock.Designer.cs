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
            this.labelLeavingStock = new System.Windows.Forms.Label();
            this.labelStoredQuantity = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductStockedQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductLeavingQuantity = new System.Windows.Forms.TextBox();
            this.labelManageLeavingStock = new System.Windows.Forms.Label();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.textBoxEmployeeCode = new System.Windows.Forms.TextBox();
            this.labelEmployeeCode = new System.Windows.Forms.Label();
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
            this.labelProductName.Location = new System.Drawing.Point(244, 121);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(126, 20);
            this.labelProductName.TabIndex = 17;
            this.labelProductName.Text = "Nom du Produit :";
            // 
            // labelLeavingStock
            // 
            this.labelLeavingStock.AutoSize = true;
            this.labelLeavingStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeavingStock.Location = new System.Drawing.Point(244, 234);
            this.labelLeavingStock.Name = "labelLeavingStock";
            this.labelLeavingStock.Size = new System.Drawing.Size(133, 20);
            this.labelLeavingStock.TabIndex = 18;
            this.labelLeavingStock.Text = "Quantité à Sortir :";
            // 
            // labelStoredQuantity
            // 
            this.labelStoredQuantity.AutoSize = true;
            this.labelStoredQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoredQuantity.Location = new System.Drawing.Point(244, 198);
            this.labelStoredQuantity.Name = "labelStoredQuantity";
            this.labelStoredQuantity.Size = new System.Drawing.Size(141, 20);
            this.labelStoredQuantity.TabIndex = 19;
            this.labelStoredQuantity.Text = "Quantité Stockée :";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(402, 121);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 20;
            // 
            // textBoxProductStockedQuantity
            // 
            this.textBoxProductStockedQuantity.Location = new System.Drawing.Point(402, 200);
            this.textBoxProductStockedQuantity.Name = "textBoxProductStockedQuantity";
            this.textBoxProductStockedQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductStockedQuantity.TabIndex = 21;
            // 
            // textBoxProductLeavingQuantity
            // 
            this.textBoxProductLeavingQuantity.Location = new System.Drawing.Point(402, 234);
            this.textBoxProductLeavingQuantity.Name = "textBoxProductLeavingQuantity";
            this.textBoxProductLeavingQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductLeavingQuantity.TabIndex = 22;
            this.textBoxProductLeavingQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterXEnter);
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
            this.buttonUpdateStock.Location = new System.Drawing.Point(591, 313);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(123, 56);
            this.buttonUpdateStock.TabIndex = 24;
            this.buttonUpdateStock.Text = "Mettre à jour";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // textBoxEmployeeCode
            // 
            this.textBoxEmployeeCode.Location = new System.Drawing.Point(402, 163);
            this.textBoxEmployeeCode.Name = "textBoxEmployeeCode";
            this.textBoxEmployeeCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeeCode.TabIndex = 25;
            // 
            // labelEmployeeCode
            // 
            this.labelEmployeeCode.AutoSize = true;
            this.labelEmployeeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeCode.Location = new System.Drawing.Point(244, 163);
            this.labelEmployeeCode.Name = "labelEmployeeCode";
            this.labelEmployeeCode.Size = new System.Drawing.Size(148, 20);
            this.labelEmployeeCode.TabIndex = 26;
            this.labelEmployeeCode.Text = "Code de l\'Employé :";
            // 
            // FormManageLeavingStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEmployeeCode);
            this.Controls.Add(this.textBoxEmployeeCode);
            this.Controls.Add(this.buttonUpdateStock);
            this.Controls.Add(this.labelManageLeavingStock);
            this.Controls.Add(this.textBoxProductLeavingQuantity);
            this.Controls.Add(this.textBoxProductStockedQuantity);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelStoredQuantity);
            this.Controls.Add(this.labelLeavingStock);
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
        private System.Windows.Forms.Label labelLeavingStock;
        private System.Windows.Forms.Label labelStoredQuantity;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductStockedQuantity;
        private System.Windows.Forms.TextBox textBoxProductLeavingQuantity;
        private System.Windows.Forms.Label labelManageLeavingStock;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.TextBox textBoxEmployeeCode;
        private System.Windows.Forms.Label labelEmployeeCode;
    }
}