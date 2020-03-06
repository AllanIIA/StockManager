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

        public FormManageEnteringStock(List<Product> products)
        {
            InitializeComponent();
            Products = products;
            listBoxEnteringStock.DataSource = Products;
            listBoxEnteringStock.DisplayMember = "Name";
            listBoxEnteringStock.DisplayMember = nameof(Product.Name);
        }

        private void listBoxEnteringStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnteringStock.SelectedItem is Product)
            {
                listBoxEnteringStock.Text = ((Product)listBoxEnteringStock.SelectedItem).Name;
                ManageStock();
            }




        }


        private void ManageStock()
        {
            textBoxProductName.Text = ((Product)listBoxEnteringStock.SelectedItem).Name;
            int Quantity = ((Product)listBoxEnteringStock.SelectedItem).StockedQuantity;
            string QuantityTotal = Quantity.ToString();
            textBoxProductStockedQuantity.Text = QuantityTotal;

            int SoldedQuantity = 0;
            string GlobalQuantitySolded = SoldedQuantity.ToString();
            textBoxQuantityEnteringStock.Text = GlobalQuantitySolded;

        }

        private void updateStock()
        {
            ((Product)listBoxEnteringStock.SelectedItem).Name = textBoxProductName.Text;
            StockedQuantity = System.Convert.ToInt32(textBoxQuantityEnteringStock.Text);
            ((Product)listBoxEnteringStock.SelectedItem).StockedQuantity += StockedQuantity;

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
            listBoxEnteringStock.DisplayMember = nameof(Product.Name);
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
            if (listBoxEnteringStock.SelectedItem is Product)
            {
                if (textBoxQuantityEnteringStock is null)
                {
                    ForceRefreshList();
                }
                else if ((System.Convert.ToInt32(textBoxQuantityEnteringStock.Text) 
                    == ((Product)listBoxEnteringStock.SelectedItem).StockedQuantity)
                    && ((textBoxProductName.Text) == (((Product)listBoxEnteringStock.SelectedItem).Name)));
                {
                    updateStock();
                }
            }
        }

        
    }
}
