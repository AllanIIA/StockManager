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
		private List<string> _Categories;

       

        /// liste des produits de film
        /// </summary>
        private List<Product> _Products;
        #endregion


       
       

       

        #region Methods
        

      

        /// <summary>
        /// Obtien ou defini les produits de l'application
        /// </summary>
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }


        /// <summary>
        /// Obtien ou defini les catégories de l'application
        /// </summary>
        public List<string> Categories
        {
            get { return _Categories; }
            set { _Categories = value; }
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
            Products.Add(new ProductList("New Product", "", "", 0, 0));
            Products.Add(new ProductList("Call of Duty", "COD_1", "FPS", 10, 70 )) ;
            Products.Add(new ProductList("Black Desert Online", "BDO_1", "MMO-RPG", 20, 30));
            Products.Add(new ProductList("Stardew Valley", "STVL_1", " Farm ", 50, 15));
            #endregion


        }


        #endregion
        

        private void buttonManageProduct_Click(object sender, EventArgs e)
        {
            FormManageProduct formManageProduct = new FormManageProduct(_Products);
            formManageProduct.ShowDialog();
        }

        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory(_Categories);
            formManageCategory.ShowDialog();
        }

        private void buttonEnteringStock_Click(object sender, EventArgs e)
        {
            FormManageEnteringStock formManageEnteringStock = new FormManageEnteringStock(_Products);
            formManageEnteringStock.ShowDialog();
        }

        private void buttonLeavingStock_Click(object sender, EventArgs e)
        {

        }
    }
}
