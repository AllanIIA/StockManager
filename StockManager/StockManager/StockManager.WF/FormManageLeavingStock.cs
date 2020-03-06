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


        #endregion

        public FormManageLeavingStock(List<Product> products)
        {
            InitializeComponent();
            Products = products;
            listBoxLeavingStock.DataSource = Products;
            listBoxLeavingStock.DisplayMember = "Name";
            listBoxLeavingStock.DisplayMember = nameof(Product.Name);
        }

        private void listBoxLeavingStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLeavingStock.SelectedItem is Product)
            {
                listBoxLeavingStock.Text = ((Product)listBoxLeavingStock.SelectedItem).Name;
                ManageStock();
            }
        }


        private void ManageStock()
        {
            textBoxProductName.Text = ((Product)listBoxLeavingStock.SelectedItem).Name;
            int Quantity = ((Product)listBoxLeavingStock.SelectedItem).StockedQuantity;
            string QuantityTotal = Quantity.ToString();
            textBoxProductStockedQuantity.Text = QuantityTotal;

            int SoldedQuantity = 0;
            string GlobalQuantitySolded = SoldedQuantity.ToString();
            textBoxProductLeavingQuantity.Text = GlobalQuantitySolded;

        }

        private void updateStock()
        {
            ((Product)listBoxLeavingStock.SelectedItem).Name = textBoxProductName.Text;
            StockedQuantity = System.Convert.ToInt32(textBoxProductLeavingQuantity.Text);
            ((Product)listBoxLeavingStock.SelectedItem).StockedQuantity -= StockedQuantity;

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
            listBoxLeavingStock.DisplayMember = nameof(Product.Name);
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
            if (listBoxLeavingStock.SelectedItem is Product)
            {
                if (textBoxProductLeavingQuantity is null)
                {
                    ForceRefreshList();
                }
                else if ((System.Convert.ToInt32(textBoxProductLeavingQuantity.Text)) < ((Product)listBoxLeavingStock.SelectedItem).StockedQuantity)
                {
                    if ((System.Convert.ToInt32(textBoxProductLeavingQuantity.Text)
                    == ((Product)listBoxLeavingStock.SelectedItem).StockedQuantity)
                    && ((textBoxProductName.Text) == (((Product)listBoxLeavingStock.SelectedItem).Name))) ;
                    {
                        updateStock();
                    }
                }
            }
        }
    }
}
