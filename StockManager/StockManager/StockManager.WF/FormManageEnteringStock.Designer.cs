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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateStock = new System.Windows.Forms.Button();
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
            this.textBoxProductName.Location = new System.Drawing.Point(389, 119);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 13;
            // 
            // textBoxQuantityEnteringStock
            // 
            this.textBoxQuantityEnteringStock.Location = new System.Drawing.Point(389, 198);
            this.textBoxQuantityEnteringStock.Name = "textBoxQuantityEnteringStock";
            this.textBoxQuantityEnteringStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantityEnteringStock.TabIndex = 14;
            // 
            // textBoxProductStockedQuantity
            // 
            this.textBoxProductStockedQuantity.Location = new System.Drawing.Point(389, 162);
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
            this.labelProductName.Size = new System.Drawing.Size(118, 20);
            this.labelProductName.TabIndex = 16;
            this.labelProductName.Text = "Nom du Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantité Stockée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantité à entrer";
            // 
            // buttonUpdateStock
            // 
            this.buttonUpdateStock.Location = new System.Drawing.Point(389, 286);
            this.buttonUpdateStock.Name = "buttonUpdateStock";
            this.buttonUpdateStock.Size = new System.Drawing.Size(123, 23);
            this.buttonUpdateStock.TabIndex = 19;
            this.buttonUpdateStock.Text = "Mettre à jour";
            this.buttonUpdateStock.UseVisualStyleBackColor = true;
            this.buttonUpdateStock.Click += new System.EventHandler(this.buttonUpdateStock_Click);
            // 
            // FormManageEnteringStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateStock;
    }
}