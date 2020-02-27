using StockManager.WF.Model;
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
		private List<string> _Categories;

		#endregion

		#region Methods
		/// <summary>
		/// Obtient ou défini la liste des catégories de l'application
		/// </summary>
		public List<string> Categories
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
		public FormManageCategory(List<string> categories)
		{
			InitializeComponent();
			Categories = categories;
			Categories.Add("New Category");
			listBoxCategoryName.DataSource = _Categories;
		}





		#endregion

		/// <summary>
		/// Afficher la liste des catégories en ajoutant une nouvelle categorie
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxCategoryName.SelectedItem is string)
			{
				textBoxCategoryName.Text = ((string)listBoxCategoryName.SelectedItem) == "New category" ? "" : ((string)listBoxCategoryName.SelectedItem);
			}
		}

		/// <summary>
		/// Ajouter et mettre à jour les catégories
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonUpdateCategory_Click(object sender, EventArgs e)
		{
			if (listBoxCategoryName.SelectedItem is string)
			{
				Categories.Remove((string)listBoxCategoryName.SelectedItem);
				Categories.Add(textBoxCategoryName.Text);

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
			if (!Categories.Contains("New Category"))
			{
				Categories.Add("New Category");
			}
			listBoxCategoryName.DataSource = Categories;

			listBoxCategoryName.SelectedItem = selectedIndex;
		}

		/// <summary>
		/// Permet de supprimer des catégories
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDeleteCategory_Click(object sender, EventArgs e)
		{
			if(listBoxCategoryName.SelectedItem is string)
			{
				if(((string)listBoxCategoryName.SelectedItem) == "New Category")
				{

				}
				else
				{
					Categories.Remove((string)listBoxCategoryName.SelectedItem);
					ForceRefreshList();
				}
			}
		}

		
	}
}
