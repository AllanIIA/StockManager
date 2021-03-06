﻿using StockManager.WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockManager.WF
{
    public partial class FormManageCategory : Form
    {
		#region Attibutes
		
		/// <summary>
		/// Liste des catégories de l'application
		/// </summary>
		private List<ProductCategory> _Categories;

		#endregion

		#region Methods
		/// <summary>
		/// Obtient ou défini la liste des catégories de l'application
		/// </summary>
		public List<ProductCategory> Categories
		{
			get { return _Categories; }
			set { _Categories = value; }
		}

		
		#endregion

		#region Constructors

		/// <summary>
		/// Constructeur Principale
		/// </summary>
		/// <param name="categories"></param>
		public FormManageCategory(List<ProductCategory> categories)
		{

			
			Categories = categories;
			ProductCategory categorie = new ProductCategory();
			categorie.Label = "New Category";
			Categories.Add(categorie);
			InitializeComponent();
			Categories = categories;
			
			listBoxCategoryName.DataSource = _Categories;
			listBoxCategoryName.DisplayMember = "Label";
		}





		#endregion

		/// <summary>
		/// Afficher la liste des catégories en ajoutant une nouvelle categorie
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxCategoryName.SelectedItem is ProductCategory)
			{
				textBoxCategoryName.Text = ((ProductCategory)listBoxCategoryName.SelectedItem).Label == "New category" ? "" : ((ProductCategory)listBoxCategoryName.SelectedItem).Label;
			}
		}

		/// <summary>
		/// Ajouter et mettre à jour les catégories
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonUpdateCategory_Click(object sender, EventArgs e)
		{
			if (listBoxCategoryName.SelectedItem is ProductCategory)
			{
				Categories.Remove((ProductCategory)listBoxCategoryName.SelectedItem);
				ProductCategory productCategory = new ProductCategory();
				productCategory.Label = textBoxCategoryName.Text;
				Categories.Add(productCategory);
				ProductCategory categorie = new ProductCategory();
				categorie.Label = "New Category";
				Categories.Add(categorie);
				ForceRefreshList();
			}
		}


		/// <summary>
		/// Permet d'ajouter une catégorie sans écraser les autres catégories
		/// </summary>
		private void ForceRefreshList()
		{
			int selectedIndex = listBoxCategoryName.SelectedIndex;

			listBoxCategoryName.DataSource = null;
			
			listBoxCategoryName.DataSource = Categories;

			listBoxCategoryName.DisplayMember = "Label";
			listBoxCategoryName.SelectedItem = 0;
		}

		/// <summary>
		/// Permet de supprimer des catégories
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDeleteCategory_Click(object sender, EventArgs e)
		{
			if(listBoxCategoryName.SelectedItem is ProductCategory)
			{
				if(((ProductCategory)listBoxCategoryName.SelectedItem).Label == "New Category")
				{

				}
				else
				{
					Categories.Remove((ProductCategory)listBoxCategoryName.SelectedItem);
					ForceRefreshList();
				}
			}
		}

		
	}
}
