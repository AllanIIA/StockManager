namespace StockManager.WF
{
    partial class FormManageEnteringStock
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
            this.listBoxEnteringStock = new System.Windows.Forms.ListBox();
            this.labelManageEnteringStock = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxQuantityEnteringStock = new System.Windows.Forms.TextBox();
            this.textBoxProductStockedQuantity = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelStoredQuantity = new System.Windows.Forms.Label();
            this.labelEnteringQuantity = new System.Windows.Forms.Label();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
            this.labelEmployeeCode = new System.Windows.Forms.Label();
            this.textBoxEmployeeCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxEnteringStock
            // 
            this.listBoxEnteringStock.FormattingEnabled = true;
            this.listBoxEnteringStock.Location = new System.Drawing.Point(26, 28);
            this.listBoxEnteringStock.Name = "listBoxEnteringStock";
            this.listBoxEnteringStock.Size = new System.Drawing.Size(174, 394);
            this.listBoxEnteringStock.TabIndex = 0;
            this.listBoxEnteringStock.SelectedIndexChanged += new System.EventHandler(this.listBoxEnteringStock_SelectedIndexChanged);
            // 
            // labelManageEnteringStock
            // 
            this.labelManageEnteringStock.AutoSize = true;
            this.labelManageEnteringStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageEnteringStock.ForeColor = System.Drawing.Color.Red;
            this.labelManageEnteringStock.Location = new System.Drawing.Point(316, 28);
            this.labelManageEnteringStock.Name = "labelManageEnteringStock";
            this.labelManageEnteringStock.Size = new System.Drawing.Size(298, 25);
            this.labelManageEnteringStock.TabIndex = 12;
            this.labelManageEnteringStock.Text = "Gestion des Entrées de Stock";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(398, 121);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 13;
            // 
            // textBoxQuantityEnteringStock
            // 
            this.textBoxQuantityEnteringStock.Location = new System.Drawing.Point(398, 225);
            this.textBoxQuantityEnteringStock.Name = "textBoxQuantityEnteringStock";
            this.textBoxQuantityEnteringStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantityEnteringStock.TabIndex = 14;

            // 
            // textBoxProductStockedQuantity
            // 
            this.textBoxProductStockedQuantity.Location = new System.Drawing.Point(398, 184);
            this.textBoxProductStockedQuantity.Name = "textBoxProductStockedQuantity";
            this.textBoxProductStockedQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductStockedQuantity.TabIndex = 15;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(232, 119);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(126, 20);
            this.labelProductName.TabIndex = 16;
            this.labelProductName.Text = "Nom du Produit :";
            // 
            // labelStoredQuantity
            // 
            this.labelStoredQuantity.AutoSize = true;
            this.labelStoredQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoredQuantity.Location = new System.Drawing.Point(232, 182);
            this.labelStoredQuantity.Name = "labelStoredQuantity";
            this.labelStoredQuantity.Size = new System.Drawing.Size(141, 20);
            this.labelStoredQuantity.TabIndex = 17;
            this.labelStoredQuantity.Text = "Quantité Stockée :";
            // 
            // labelEnteringQuantity
            // 
            this.labelEnteringQuantity.AutoSize = true;
            this.labelEnteringQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnteringQuantity.Location = new System.Drawing.Point(232, 225);
            this.labelEnteringQuantity.Name = "labelEnteringQuantity";
            this.labelEnteringQuantity.Size = new System.Drawing.Size(139, 20);
            this.labelEnteringQuantity.TabIndex = 18;
            this.labelEnteringQuantity.Text = "Quantité à Entrer :";
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Location = new System.Drawing.Point(606, 287);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(123, 47);
            this.buttonUpdateStock.TabIndex = 19;
            this.buttonUpdateStock.Text = "Mettre à jour";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // labelEmployeeCode
            // 
            this.labelEmployeeCode.AutoSize = true;
            this.labelEmployeeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeCode.Location = new System.Drawing.Point(232, 150);
            this.labelEmployeeCode.Name = "labelEmployeeCode";
            this.labelEmployeeCode.Size = new System.Drawing.Size(148, 20);
            this.labelEmployeeCode.TabIndex = 20;
            this.labelEmployeeCode.Text = "Code de l\'Employé :";
            // 
            // textBoxEmployeeCode
            // 
            this.textBoxEmployeeCode.Location = new System.Drawing.Point(398, 150);
            this.textBoxEmployeeCode.Name = "textBoxEmployeeCode";
            this.textBoxEmployeeCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmployeeCode.TabIndex = 21;
            // 
            // FormManageEnteringStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEmployeeCode);
            this.Controls.Add(this.labelEmployeeCode);
            this.Controls.Add(this.buttonUpdateStock);
            this.Controls.Add(this.labelEnteringQuantity);
            this.Controls.Add(this.labelStoredQuantity);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductStockedQuantity);
            this.Controls.Add(this.textBoxQuantityEnteringStock);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelManageEnteringStock);
            this.Controls.Add(this.listBoxEnteringStock);
            this.Name = "FormManageEnteringStock";
            this.Text = "FormManageEnteringStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEnteringStock;
        private System.Windows.Forms.Label labelManageEnteringStock;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxQuantityEnteringStock;
        private System.Windows.Forms.TextBox textBoxProductStockedQuantity;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelStoredQuantity;
        private System.Windows.Forms.Label labelEnteringQuantity;
        private System.Windows.Forms.Button buttonUpdateStock;
        private System.Windows.Forms.Label labelEmployeeCode;
        private System.Windows.Forms.TextBox textBoxEmployeeCode;
    }
}