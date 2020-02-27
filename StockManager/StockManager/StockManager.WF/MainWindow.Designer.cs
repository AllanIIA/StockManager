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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonManageProduct = new System.Windows.Forms.Button();
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonManageCategory
            // 
            this.buttonManageCategory.Location = new System.Drawing.Point(42, 61);
            this.buttonManageCategory.Name = "buttonManageCategory";
            this.buttonManageCategory.Size = new System.Drawing.Size(224, 113);
            this.buttonManageCategory.TabIndex = 0;
            this.buttonManageCategory.Text = "Gestion Catégories";
            this.buttonManageCategory.UseVisualStyleBackColor = true;
            this.buttonManageCategory.Click += new System.EventHandler(this.buttonManageCategory_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 112);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gestion sorties stocks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 117);
            this.button3.TabIndex = 2;
            this.button3.Text = "Gestion entrées stocks";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonManageProduct
            // 
            this.buttonManageProduct.Location = new System.Drawing.Point(464, 61);
            this.buttonManageProduct.Name = "buttonManageProduct";
            this.buttonManageProduct.Size = new System.Drawing.Size(212, 113);
            this.buttonManageProduct.TabIndex = 3;
            this.buttonManageProduct.Text = "Gestion Produits";
            this.buttonManageProduct.UseVisualStyleBackColor = true;
            this.buttonManageProduct.Click += new System.EventHandler(this.buttonManageProduct_Click);
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.ForeColor = System.Drawing.Color.Red;
            this.labelManageProduct.Location = new System.Drawing.Point(310, 9);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(102, 25);
            this.labelManageProduct.TabIndex = 12;
            this.labelManageProduct.Text = "IIA Game";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelManageProduct);
            this.Controls.Add(this.buttonManageProduct);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonManageCategory);
            this.Name = "MainWindow";
            this.Text = "FormManageIIAGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonManageCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonManageProduct;
        private System.Windows.Forms.Label labelManageProduct;
    }
}

