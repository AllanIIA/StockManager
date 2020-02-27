namespace StockManager.WF
{
    partial class FormManageCategory
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
            this.listBoxCategoryName = new System.Windows.Forms.ListBox();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.labelManageCategory = new System.Windows.Forms.Label();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxCategoryName
            // 
            this.listBoxCategoryName.FormattingEnabled = true;
            this.listBoxCategoryName.Location = new System.Drawing.Point(34, 63);
            this.listBoxCategoryName.Name = "listBoxCategoryName";
            this.listBoxCategoryName.Size = new System.Drawing.Size(240, 342);
            this.listBoxCategoryName.TabIndex = 0;
            this.listBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.listBoxCategoryName_SelectedIndexChanged);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Location = new System.Drawing.Point(464, 119);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(117, 23);
            this.buttonUpdateCategory.TabIndex = 1;
            this.buttonUpdateCategory.Text = "Ajouter/Mise à jour";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(614, 119);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(83, 23);
            this.buttonDeleteCategory.TabIndex = 2;
            this.buttonDeleteCategory.Text = "Supprimer";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // labelManageCategory
            // 
            this.labelManageCategory.AutoSize = true;
            this.labelManageCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCategory.ForeColor = System.Drawing.Color.Red;
            this.labelManageCategory.Location = new System.Drawing.Point(280, 21);
            this.labelManageCategory.Name = "labelManageCategory";
            this.labelManageCategory.Size = new System.Drawing.Size(238, 25);
            this.labelManageCategory.TabIndex = 3;
            this.labelManageCategory.Text = "Gestion des Categories";
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryName.Location = new System.Drawing.Point(353, 84);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(86, 20);
            this.labelCategoryName.TabIndex = 4;
            this.labelCategoryName.Text = "Categorie :";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(464, 86);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(233, 20);
            this.textBoxCategoryName.TabIndex = 5;
          
            // 
            // FormManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCategoryName);
            this.Controls.Add(this.labelManageCategory);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonUpdateCategory);
            this.Controls.Add(this.listBoxCategoryName);
            this.Name = "FormManageCategory";
            this.Text = "FormManageCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCategoryName;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Label labelManageCategory;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
    }
}