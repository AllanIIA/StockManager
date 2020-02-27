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
    public partial class FormManageProduct : Form
    {
        

		#region Attibutes

		/// <summary>
		/// Liste des Produits de l'application
		/// </summary>
		private List<string> _Products;
		#endregion

		#region Methods
		/// <summary>
		/// Obtient ou défini la liste des produits de l'application
		/// </summary>
		public List<string> Products
		{
			get { return _Products; }
			set { _Products = value; }
		}
		#endregion

		#region Constructors

		/// <summary>
		/// Constructeur Principale
		/// </summary>
		/// <param name="products"></param>
		public FormManageProduct(List<string> products)
		{
			InitializeComponent();
			Products = products;
			Products.Add("New Product");
			listBoxProductName.DataSource = _Products;
		}

		#endregion

		/// <summary>
		/// Afficher la liste des produits en ajoutant un nouveau produit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxProductName.SelectedItem is string)
			{
				textBoxProductName.Text = ((string)listBoxProductName.SelectedItem) == "New product" ? "" : ((string)listBoxProductName.SelectedItem);
				textBoxProductReference.Text = ((string)listBoxProductName.SelectedItem) == "New product" ? "" : ((string)listBoxProductName.SelectedItem);
			}
		}


		/// <summary>
		/// Permet d'ajouter un produit sans écraser les autres produits
		/// </summary>
		private void ForceRefreshList()
		{
			int selectedIndex = listBoxProductName.SelectedIndex;

			listBoxProductName.DataSource = null;
			if (!Products.Contains("New Product"))
			{
				Products.Add("New Product");
			}
			listBoxProductName.DataSource = Products;

			listBoxProductName.SelectedItem = selectedIndex;
		}


		/// <summary>
		/// Permet d'ajouter et ou de mettre à jour des produits
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonUpdateProduct_Click(object sender, EventArgs e)
		{
			if (listBoxProductName.SelectedItem is string)
			{
				Products.Remove((string)listBoxProductName.SelectedItem);
				Products.Add(textBoxProductName.Text);

				ForceRefreshList();
			}
		}

		/// <summary>
		/// Permet de supprimer des produits
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDeleteProduct_Click(object sender, EventArgs e)
		{
			if (listBoxProductName.SelectedItem is string)
			{
				if (((string)listBoxProductName.SelectedItem) == "New Category")
				{

				}
				else
				{
					Products.Remove((string)listBoxProductName.SelectedItem);
					ForceRefreshList();
				}
			}
		}
	}
}
