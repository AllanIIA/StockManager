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
    public partial class FormManageEnteringStock : Form
    {

        #region Attributes

        /// <summary>
        /// Quantity stockée
        /// </summary>
        private int _StoredQuantity;

        private List<Product> _Products;

        private bool _IsEntry;

        


        #endregion


        #region  Methods
        public int StoredQuantity
        {
            get { return _StoredQuantity; }
            set { _StoredQuantity = value; }
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

        public FormManageEnteringStock(List<Product> products, bool isEntry)
        {
            _IsEntry = isEntry;

            InitializeComponent();
            Products = products;
            listBoxEnteringStock.DataSource = Products;
            listBoxEnteringStock.DisplayMember = "Name";
            listBoxEnteringStock.DisplayMember = nameof(Product.Nom);
        }

        private void listBoxEnteringStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnteringStock.SelectedItem is Product)
            {
                listBoxEnteringStock.Text = ((Product)listBoxEnteringStock.SelectedItem).Nom;
                ManageStock();
            }

        }


        private void ManageStock()
        {
            textBoxProductName.Text = ((Product)listBoxEnteringStock.SelectedItem).Nom;
            int Quantity = ((Product)listBoxEnteringStock.SelectedItem).StoredQuantity;
            string QuantityTotal = Quantity.ToString();
            textBoxProductStockedQuantity.Text = QuantityTotal;

            int SoldedQuantity = 0;
            string GlobalQuantitySolded = SoldedQuantity.ToString();
            textBoxQuantityEnteringStock.Text = GlobalQuantitySolded;

        }

        private void updateStock()
        {

            ((Product)listBoxEnteringStock.SelectedItem).Nom = textBoxProductName.Text;
            StoredQuantity = Int32.Parse(textBoxQuantityEnteringStock.Text);
            ((Product)listBoxEnteringStock.SelectedItem).StoredQuantity += StoredQuantity;

            ForceRefreshList();
        }

        /// <summary>
		/// Permet d'ajouter un produit sans écraser les autres produits
		/// </summary>
		private void ForceRefreshList()
        {
            int selectedIndex = listBoxEnteringStock.SelectedIndex;
           
            listBoxEnteringStock.DataSource = null;
            listBoxEnteringStock.DataSource = Products;
            listBoxEnteringStock.DisplayMember = nameof(Product.Nom);
            listBoxEnteringStock.SelectedIndex = selectedIndex;
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

            stockMovementProduct.IdentifierProduct = ((Product)listBoxEnteringStock.SelectedItem);
            stockMovementProduct.IdentifierStockmovement = stockMovement;
            stockMovementProduct.Quantity = Int32.Parse(textBoxQuantityEnteringStock.Text);

            if (listBoxEnteringStock.SelectedItem is Product)
            {
                if (textBoxQuantityEnteringStock is null)
                {
                    ForceRefreshList();
                }
                else if ((Int32.Parse(textBoxQuantityEnteringStock.Text) 
                    == ((Product)listBoxEnteringStock.SelectedItem).StoredQuantity)
                    && ((textBoxProductName.Text) == (((Product)listBoxEnteringStock.SelectedItem).Nom)));
                {
                    updateStock();
                }
            }
        }

        
    }
}
