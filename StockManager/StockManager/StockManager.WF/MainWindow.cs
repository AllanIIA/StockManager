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
    public partial class MainWindow : Form
    {
       

		#region Attibutes

		/// <summary>
		/// Liste des catégories de l'application
		/// </summary>
		private List<string> _ManageCategories;

        /// <summary>
		/// Liste des produits de l'application
		/// </summary>
		private List<string> _ManageProducts;

        /// liste des produits de film
        /// </summary>
        private List<Product> _Products;
        #endregion


       
       

       

        #region Methods
        /// <summary>
        /// Obtient ou défini la liste des catégories de l'application
        /// </summary>
        public List<string> ManageCategories
        {
			get { return _ManageCategories; }
			set { _ManageCategories = value; }
		}

        /// <summary>
        /// Obtient ou défini la liste des produits de l'application
        /// </summary>
        public List<string> ManageProducts
        {
            get { return _ManageProducts; }
            set { _ManageProducts = value; }
        }

        /// <summary>
        /// Obtien ou defini les produits de l'application
        /// </summary>
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }
        #endregion


        #region Constructors

        /// <summary>
        /// Constucteur principale
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            #region Initialisation des données

            // Categories
            ProductCategory Action = new ProductCategory("Action");



            // Produits
            Products = new List<Product>();
            Products.Add(new ProductList("Naruto", "R205", "Manga Ninja XD"));
            Products.Add(new ProductList("Naro", "REF105", "Manga  XD"));
            Products.Add(new ProductList("Naru", "REF5", " Ninja "));
            #endregion


        }


        #endregion
        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory(ManageCategories);
            formManageCategory.ShowDialog();
        }

        private void buttonManageProduct_Click(object sender, EventArgs e)
        {
            FormManageProduct formManageProduct = new FormManageProduct(_Products);
            formManageProduct.ShowDialog();
        }
    }
}
