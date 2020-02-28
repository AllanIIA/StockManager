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
	public partial class FormManageProduct : Form
	{


		#region Attributes
		/// <summary>
		/// Liste des produits de l'application
		/// </summary>
		private List<Product> _Products;

		#endregion

		#region Methods
		/// <summary>
		/// Obtien ou defini la liste des produits de l'aplication
		/// </summary>
		public List<Product> Products
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
        public FormManageProduct(List<Product> products)
		{
			InitializeComponent();
			Products = products;
			listBoxProductName.DataSource = Products;
			listBoxProductName.DisplayMember = "Name";
			listBoxProductName.DisplayMember = nameof(Product.Name);
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
			if (listBoxProductName.SelectedItem is Product)
			{
				textBoxProductName.Text = ((Product)listBoxProductName.SelectedItem).Name;
				textBoxProductReference.Text = ((Product)listBoxProductName.SelectedItem).Reference;
			}
		}


		/// <summary>
		/// Permet d'ajouter un produit sans écraser les autres produits
		/// </summary>
		private void ForceRefreshList()
		{
			int selectedIndex = listBoxProductName.SelectedIndex;

			listBoxProductName.DataSource = null;
			listBoxProductName.DataSource = Products;
			listBoxProductName.DisplayMember = nameof(Product.Name);
			listBoxProductName.SelectedIndex = selectedIndex;
		}


		private void updateProduct()
		{
			if (listBoxProductName.SelectedItem is Product)
			{
				((Product)listBoxProductName.SelectedItem).Name = textBoxProductName.Text;
				((Product)listBoxProductName.SelectedItem).Reference = textBoxProductReference.Text;
				((Product)listBoxProductName.SelectedItem).Description = textBoxProductDescription.Text;
				double Prix = ((Product)listBoxProductName.SelectedItem).Price;
				string PrixUnitaire = Prix.ToString();
				textBoxProductPrice.Text = PrixUnitaire;
				int Quantity = ((Product)listBoxProductName.SelectedItem).StockedQuantity;
				string QuantityTotal = Quantity.ToString();
				textBoxProductStockedQuantity.Text = QuantityTotal;
				ForceRefreshList();
			}


			/// <summary>
			/// Permet d'ajouter et ou de mettre à jour des produits
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			

			/// <summary>
			/// Permet de supprimer des produits
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			
		}
	} 
}

