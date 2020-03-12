using StockManager.WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private string _ConnetionString;
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

        public string ConnectionString
        {
            get { return _ConnetionString; }
            set { _ConnetionString = value; }
        }
        #endregion

        public FormManageLeavingStock(List<Product> products, bool isEntry, string connectionString)
        {
            _Products = products;
            _IsEntry = isEntry;
            ConnectionString = connectionString;
            InitializeComponent();
            
            listBoxLeavingStock.DataSource = _Products;
            listBoxLeavingStock.DisplayMember = "Nom";
            listBoxLeavingStock.DisplayMember = nameof(Product.Nom);
        }

        private void listBoxLeavingStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLeavingStock.SelectedItem is Product)
            {
                textBoxProductStockedQuantity.Text = ((Product)listBoxLeavingStock.SelectedItem).StoredQuantity.ToString();
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

       



        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            StockMovementProduct stockMovementProduct = new StockMovementProduct();
            stockMovementProduct.IdentifierProduct = ((Product)listBoxLeavingStock.SelectedItem).Identifier;

            if (!(((Product)listBoxLeavingStock.SelectedItem).StoredQuantity - Decimal.Parse(textBoxProductLeavingQuantity.Text) < 0))
            {

            
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    sqlConnection.Open();

                    Decimal Quantity = ((Product)listBoxLeavingStock.SelectedItem).StoredQuantity - Decimal.Parse(textBoxProductLeavingQuantity.Text);

                    using (SqlCommand command = sqlConnection.CreateCommand())
                    {
                        command.CommandText = $"UPDATE Product SET "
                            + $"[StoredQuantity] = @StoredQuantity "
                            + $"WHERE [Identifier] = @Identifier ";

                        command.Parameters.AddWithValue("StoredQuantity", Quantity);
                        command.Parameters.AddWithValue("Identifier", ((Product)listBoxLeavingStock.SelectedItem).Identifier);

                        command.ExecuteNonQuery();

                        command.CommandText = $"INSERT INTO StockMovement([Date], [EmployeeCode], [IsStockEntry]) " +
                            $"output INSERTED.[Identifier]" +
                            $" VALUES (@Date, @EmployeeCode, @IsStockEntry)";

                        command.Parameters.AddWithValue("Date", DateTime.Now);
                        command.Parameters.AddWithValue("EmployeeCode", textBoxEmployeeCode.Text);
                        command.Parameters.AddWithValue("IsStockEntry", _IsEntry);

                        // On récupère l'identifiant du stockMovement nouvellement ajouté,
                        // puisqu'il est nécessaire dans l'insertion d'un nouveau stockMovementProduct.
                        stockMovementProduct.IdentifierStockmovement = (int)command.ExecuteScalar();

                        command.CommandText = $"INSERT INTO StockMovementProduct([IdentifierProduct]," +
                            $" [IdentifierStockMovement], [Quantity]) " +
                            $" VALUES (@IdentifierProduct, @IdentifierStockMovement, @Quantity)";

                        command.Parameters.AddWithValue("IdentifierProduct",
                            stockMovementProduct.IdentifierProduct);
                        command.Parameters.AddWithValue("IdentifierStockMovement",
                            stockMovementProduct.IdentifierStockmovement);
                        command.Parameters.AddWithValue("Quantity",
                            stockMovementProduct.Quantity);

                        command.ExecuteNonQuery();

                    }

                    ForceRefreshList(sqlConnection);

                    sqlConnection.Close();
                }

            }
        }
        #region Sql
        // <summary>
        /// met à jour la liste des produits.
        /// </summary>
        public void ForceRefreshList(SqlConnection sqlConnection)
        {
            listBoxLeavingStock.DataSource = null;

            Products = GetProduct(sqlConnection);
            listBoxLeavingStock.DataSource = Products;

            listBoxLeavingStock.DisplayMember = "Nom";
            listBoxLeavingStock.SelectedIndex = 0;

        }


        private static List<Product> GetProduct(SqlConnection sqlConnection)
        {
            List<Product> products = new List<Product>();

            using (SqlCommand command = sqlConnection.CreateCommand())
            {

                command.CommandText = "SELECT Product.Identifier, Product.Nom, Product.Reference, Product.Price, Product.Description, Product.IdentifierProductCategory, Product.StoredQuantity " +
                    "FROM Product ";


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        {
                            Product product = new Product();
                            products.Add(product);

                            product.Identifier = reader.GetInt32(0);

                            if (reader.IsDBNull(1) == false)
                            {
                                product.Nom = reader.GetString(1);
                            }
                            if (reader.IsDBNull(2) == false)
                            {
                                product.Reference = reader.GetString(2);
                            }
                            if (reader.IsDBNull(3) == false)
                            {
                                product.Price = reader.GetDecimal(3);
                            }
                            if (reader.IsDBNull(4) == false)
                            {
                                product.Description = reader.GetString(4);
                            }

                            product.IdentifierProductCategory = reader.GetInt32(5);

                            if (reader.IsDBNull(6) == false)
                            {
                                product.StoredQuantity = Convert.ToInt32(reader.GetDecimal(6));
                            }

                        }
                    }
                }

            }
            return products;
        }
        #endregion

    }

}
