namespace StockManager.WF
{
    partial class FormManageProduct
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
            this.listBoxProductName = new System.Windows.Forms.ListBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductReference = new System.Windows.Forms.TextBox();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductStockedQuantity = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductReference = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.labelProductStokedQuantity = new System.Windows.Forms.Label();
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProductName
            // 
            this.listBoxProductName.BackColor = System.Drawing.Color.Azure;
            this.listBoxProductName.ForeColor = System.Drawing.Color.SeaGreen;
            this.listBoxProductName.FormattingEnabled = true;
            this.listBoxProductName.Location = new System.Drawing.Point(35, 34);
            this.listBoxProductName.Name = "listBoxProductName";
            this.listBoxProductName.Size = new System.Drawing.Size(192, 381);
            this.listBoxProductName.TabIndex = 0;
            this.listBoxProductName.SelectedIndexChanged += new System.EventHandler(this.listBoxProductName_SelectedIndexChanged);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.Azure;
            this.textBoxProductName.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxProductName.Location = new System.Drawing.Point(433, 68);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(185, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.Color.Azure;
            this.textBoxProductPrice.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxProductPrice.Location = new System.Drawing.Point(433, 124);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(185, 20);
            this.textBoxProductPrice.TabIndex = 2;
            // 
            // textBoxProductReference
            // 
            this.textBoxProductReference.BackColor = System.Drawing.Color.Azure;
            this.textBoxProductReference.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxProductReference.Location = new System.Drawing.Point(433, 94);
            this.textBoxProductReference.Name = "textBoxProductReference";
            this.textBoxProductReference.Size = new System.Drawing.Size(185, 20);
            this.textBoxProductReference.TabIndex = 3;
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.BackColor = System.Drawing.Color.Azure;
            this.textBoxProductDescription.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxProductDescription.Location = new System.Drawing.Point(433, 158);
            this.textBoxProductDescription.Multiline = true;
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(185, 58);
            this.textBoxProductDescription.TabIndex = 4;
            // 
            // textBoxProductStockedQuantity
            // 
            this.textBoxProductStockedQuantity.BackColor = System.Drawing.Color.Azure;
            this.textBoxProductStockedQuantity.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxProductStockedQuantity.Location = new System.Drawing.Point(433, 284);
            this.textBoxProductStockedQuantity.Name = "textBoxProductStockedQuantity";
            this.textBoxProductStockedQuantity.ReadOnly = true;
            this.textBoxProductStockedQuantity.Size = new System.Drawing.Size(185, 20);
            this.textBoxProductStockedQuantity.TabIndex = 5;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(271, 68);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(126, 20);
            this.labelProductName.TabIndex = 6;
            this.labelProductName.Text = "Nom du Produit :";
            // 
            // labelProductReference
            // 
            this.labelProductReference.AutoSize = true;
            this.labelProductReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductReference.Location = new System.Drawing.Point(279, 94);
            this.labelProductReference.Name = "labelProductReference";
            this.labelProductReference.Size = new System.Drawing.Size(92, 20);
            this.labelProductReference.TabIndex = 7;
            this.labelProductReference.Text = "Réference :";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductPrice.Location = new System.Drawing.Point(279, 124);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(118, 20);
            this.labelProductPrice.TabIndex = 8;
            this.labelProductPrice.Text = "Prix du Produit :";
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductDescription.Location = new System.Drawing.Point(279, 156);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(97, 20);
            this.labelProductDescription.TabIndex = 9;
            this.labelProductDescription.Text = "Description :";
            // 
            // labelProductStokedQuantity
            // 
            this.labelProductStokedQuantity.AutoSize = true;
            this.labelProductStokedQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductStokedQuantity.Location = new System.Drawing.Point(284, 282);
            this.labelProductStokedQuantity.Name = "labelProductStokedQuantity";
            this.labelProductStokedQuantity.Size = new System.Drawing.Size(132, 20);
            this.labelProductStokedQuantity.TabIndex = 10;
            this.labelProductStokedQuantity.Text = "Quantité Stocké :";
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.ForeColor = System.Drawing.Color.Red;
            this.labelManageProduct.Location = new System.Drawing.Point(278, 9);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(212, 25);
            this.labelManageProduct.TabIndex = 11;
            this.labelManageProduct.Text = "Gestion des Produits";
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpdateProduct.Location = new System.Drawing.Point(283, 365);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(149, 31);
            this.buttonUpdateProduct.TabIndex = 12;
            this.buttonUpdateProduct.Text = "Ajouter / Mise à jour";
            this.buttonUpdateProduct.UseVisualStyleBackColor = false;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(467, 365);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(108, 31);
            this.buttonDeleteProduct.TabIndex = 13;
            this.buttonDeleteProduct.Text = "Supprimer";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.Azure;
            this.comboBoxCategory.ForeColor = System.Drawing.Color.SeaGreen;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(451, 236);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(167, 21);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryName.Location = new System.Drawing.Point(279, 237);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(166, 20);
            this.labelCategoryName.TabIndex = 16;
            this.labelCategoryName.Text = "Categorie du Produit  :";
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCategoryName);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.labelManageProduct);
            this.Controls.Add(this.labelProductStokedQuantity);
            this.Controls.Add(this.labelProductDescription);
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.labelProductReference);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxProductStockedQuantity);
            this.Controls.Add(this.textBoxProductDescription);
            this.Controls.Add(this.textBoxProductReference);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.listBoxProductName);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "FormManageProduct";
            this.Text = "FormManageProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductReference;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.TextBox textBoxProductStockedQuantity;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductReference;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Label labelProductStokedQuantity;
        private System.Windows.Forms.Label labelManageProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategoryName;
    }
}