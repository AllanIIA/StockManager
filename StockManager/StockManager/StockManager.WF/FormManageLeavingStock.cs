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
    public partial class FormManageLeavingStock : Form
    {

        #region Attributes

        /// <summary>
        /// Quantity stockée
        /// </summary>
        private int _StockedQuantity;

        private List<Product> _Products;

        private bool _IsEntry;
        #endregion


        #region  Methods
        public int StockedQuantity
        {
            get { return _StockedQuantity; }
            set { _StockedQuantity = value; }
        }


        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }


        public bool IsEntry
        {
            get { return _IsEntry; }
            set { _IsEntry = value; }
        }
        #endregion

        public FormManageLeavingStock(List<Product> products, bool isEntry)
        {
            _Products = products;
            _IsEntry = isEntry;
            InitializeComponent();
            
            listBoxLeavingStock.DataSource = _Products;
            listBoxLeavingStock.DisplayMember = "Nom";
            listBoxLeavingStock.DisplayMember = nameof(Product.Nom);
        }

        private void listBoxLeavingStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLeavingStock.SelectedItem is Product)
            {
                listBoxLeavingStock.Text = ((Product)listBoxLeavingStock.SelectedItem).Nom;
                ManageStock();
            }
        }


        private void ManageStock()
        {
            textBoxProductName.Text = ((Product)listBoxLeavingStock.SelectedItem).Nom;
            int Quantity = ((Product)listBoxLeavingStock.SelectedItem).StoredQuantity;
            string QuantityTotal = Quantity.ToString();
            textBoxProductStockedQuantity.Text = QuantityTotal;

            int SoldedQuantity = 0;
            string GlobalQuantitySolded = SoldedQuantity.ToString();
            textBoxProductLeavingQuantity.Text = GlobalQuantitySolded;

        }

        private void updateStock()
        {
            ((Product)listBoxLeavingStock.SelectedItem).Nom = textBoxProductName.Text;
            StockedQuantity = Int32.Parse(textBoxProductLeavingQuantity.Text);
            ((Product)listBoxLeavingStock.SelectedItem).StoredQuantity -= StockedQuantity;

            ForceRefreshList();
        }

        /// <summary>
		/// Permet d'ajouter un produit sans écraser les autres produits
		/// </summary>
		private void ForceRefreshList()
        {
            int selectedIndex = listBoxLeavingStock.SelectedIndex;

            listBoxLeavingStock.DataSource = null;
            listBoxLeavingStock.DataSource = Products;
            listBoxLeavingStock.DisplayMember = nameof(Product.Nom);
            listBoxLeavingStock.SelectedIndex = selectedIndex;
        }

        private void EnterXEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                updateStock();
            }
        }

        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {

            StockMovement stockMovement = new StockMovement();

            stockMovement.IsStockEntry = IsEntry;
            stockMovement.EmployeeCode = textBoxEmployeeCode.Text;
            stockMovement.Date = DateTime.Now;

            StockMovementProduct stockMovementProduct = new StockMovementProduct();

            stockMovementProduct.IdentifierProduct = ((Product)listBoxLeavingStock.SelectedItem);
            stockMovementProduct.IdentifierStockmovement = stockMovement;
            stockMovementProduct.Quantity = Int32.Parse(textBoxProductLeavingQuantity.Text);

            if (listBoxLeavingStock.SelectedItem is Product)
            {
                if (textBoxProductLeavingQuantity is null)
                {
                    ForceRefreshList();
                }
                else if ((Int32.Parse(textBoxProductLeavingQuantity.Text)) < ((Product)listBoxLeavingStock.SelectedItem).StoredQuantity)
                {
                    if ((Int32.Parse(textBoxProductLeavingQuantity.Text)
                    == ((Product)listBoxLeavingStock.SelectedItem).StoredQuantity)
                    && ((textBoxProductName.Text) == (((Product)listBoxLeavingStock.SelectedItem).Nom))) ;
                    {
                        updateStock();
                    }
                }
            }
        }
    }
}
