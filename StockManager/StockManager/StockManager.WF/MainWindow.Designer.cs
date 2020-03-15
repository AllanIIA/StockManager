namespace StockManager.WF
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonManageCategory = new System.Windows.Forms.Button();
            this.buttonLeavingStock = new System.Windows.Forms.Button();
            this.buttonEnteringStock = new System.Windows.Forms.Button();
            this.buttonManageProduct = new System.Windows.Forms.Button();
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonManageCategory
            // 
            this.buttonManageCategory.BackColor = System.Drawing.Color.Silver;
            this.buttonManageCategory.ForeColor = System.Drawing.Color.Blue;
            this.buttonManageCategory.Location = new System.Drawing.Point(129, 65);
            this.buttonManageCategory.Name = "buttonManageCategory";
            this.buttonManageCategory.Size = new System.Drawing.Size(200, 166);
            this.buttonManageCategory.TabIndex = 0;
            this.buttonManageCategory.Text = "Gestion Catégories";
            this.buttonManageCategory.UseVisualStyleBackColor = false;
            this.buttonManageCategory.Click += new System.EventHandler(this.buttonManageCategory_Click);
            // 
            // buttonLeavingStock
            // 
            this.buttonLeavingStock.BackColor = System.Drawing.Color.Silver;
            this.buttonLeavingStock.ForeColor = System.Drawing.Color.Blue;
            this.buttonLeavingStock.Location = new System.Drawing.Point(453, 251);
            this.buttonLeavingStock.Name = "buttonLeavingStock";
            this.buttonLeavingStock.Size = new System.Drawing.Size(200, 166);
            this.buttonLeavingStock.TabIndex = 1;
            this.buttonLeavingStock.Text = "Gestion sorties stocks";
            this.buttonLeavingStock.UseVisualStyleBackColor = false;
            this.buttonLeavingStock.Click += new System.EventHandler(this.buttonLeavingStock_Click);
            // 
            // buttonEnteringStock
            // 
            this.buttonEnteringStock.BackColor = System.Drawing.Color.Silver;
            this.buttonEnteringStock.ForeColor = System.Drawing.Color.Blue;
            this.buttonEnteringStock.Location = new System.Drawing.Point(129, 251);
            this.buttonEnteringStock.Name = "buttonEnteringStock";
            this.buttonEnteringStock.Size = new System.Drawing.Size(200, 166);
            this.buttonEnteringStock.TabIndex = 2;
            this.buttonEnteringStock.Text = "Gestion entrées stocks";
            this.buttonEnteringStock.UseVisualStyleBackColor = false;
            this.buttonEnteringStock.Click += new System.EventHandler(this.buttonEnteringStock_Click);
            // 
            // buttonManageProduct
            // 
            this.buttonManageProduct.BackColor = System.Drawing.Color.Silver;
            this.buttonManageProduct.ForeColor = System.Drawing.Color.Blue;
            this.buttonManageProduct.Location = new System.Drawing.Point(453, 65);
            this.buttonManageProduct.Name = "buttonManageProduct";
            this.buttonManageProduct.Size = new System.Drawing.Size(200, 166);
            this.buttonManageProduct.TabIndex = 3;
            this.buttonManageProduct.TabStop = false;
            this.buttonManageProduct.Text = "Gestion Produits";
            this.buttonManageProduct.UseVisualStyleBackColor = false;
            this.buttonManageProduct.Click += new System.EventHandler(this.buttonManageProduct_Click);
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.ForeColor = System.Drawing.Color.Red;
            this.labelManageProduct.Location = new System.Drawing.Point(306, 9);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(180, 25);
            this.labelManageProduct.TabIndex = 12;
            this.labelManageProduct.Text = "TM\'s Game Shop";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelManageProduct);
            this.Controls.Add(this.buttonManageProduct);
            this.Controls.Add(this.buttonEnteringStock);
            this.Controls.Add(this.buttonLeavingStock);
            this.Controls.Add(this.buttonManageCategory);
            this.Name = "MainWindow";
            this.Text = "FormManageIIAGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCategory;
        private System.Windows.Forms.Button buttonLeavingStock;
        private System.Windows.Forms.Button buttonEnteringStock;
        private System.Windows.Forms.Button buttonManageProduct;
        private System.Windows.Forms.Label labelManageProduct;
    }
}

