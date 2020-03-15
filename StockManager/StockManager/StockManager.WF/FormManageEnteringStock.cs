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
    public partial class FormManageEnteringStock : Form
    {

        #region Attributes

        /// <summary>
        /// Quantity stockée
        /// </summary>
        private int _StoredQuantity;

        /// <summary>
        /// Liste des Produits de l'application
        /// </summary>
        private List<Product> _Products;

        /// <summary>
        /// Verifie si le produit est une entrée ou une sortie
        /// </summary>
        private bool _IsEntry;

        /// <summary>
        /// Permet la connexion à la Base de données
        /// </summary>
        private string _ConnetionString;




        #endregion


        #region  Methods
         /// <summary>
        /// Obtient ou défini la quantité stockée de l'application
        /// </summary>
        public int StoredQuantity
        {
            get { return _StoredQuantity; }
            set { _StoredQuantity = value; }
        }


        /// <summary>
        /// Obtient ou défini la liste des Produits de l'application
        /// </summary>
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }

        /// <summary>
        /// Verifie si le produit est une entrée ou une sortie
        /// </summary>
        public bool IsEntry
        {
            get { return _IsEntry; }
            set { _IsEntry = value; }
        }

        /// <summary>
        /// Permet la connexion à la Base de données
        /// </summary>
        public string ConnectionString
        {
            get { return _ConnetionString; }
            set { _ConnetionString = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructeur principale
        /// </summary>
        /// <param name="products"></param>
        /// <param name="isEntry"></param>
        /// <param name="connectionString"></param>
        public FormManageEnteringStock(List<Product> products, bool isEntry, string connectionString)
        {
            _IsEntry = isEntry;
            ConnectionString = connectionString;
            InitializeComponent();
            Products = products;
            listBoxEnteringStock.DataSource = Products;
            listBoxEnteringStock.DisplayMember = "Name";
            listBoxEnteringStock.DisplayMember = nameof(Product.Nom);
        }
        #endregion

        /// <summary>
        /// Affiche la liste des produits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxEnteringStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnteringStock.SelectedItem is Product)
            {
                textBoxProductStockedQuantity.Text = ((Product)listBoxEnteringStock.SelectedItem).StoredQuantity.ToString();
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

        /// <summary>
        /// Permat d'ajouter ou de mettre à jour la quantité de produit stockée (entrée)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateStock_Click(object sender, EventArgs e)
        {
            StockMovementProduct stockMovementProduct = new StockMovementProduct();
            stockMovementProduct.IdentifierProduct = ((Product)listBoxEnteringStock.SelectedItem).Identifier;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                Decimal Quantity = ((Product)listBoxEnteringStock.SelectedItem).StoredQuantity + Decimal.Parse(textBoxQuantityEnteringStock.Text);

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                        command.CommandText = $"UPDATE Product SET " 
                            + $"[StoredQuantity] = @StoredQuantity "
                            + $"WHERE [Identifier] = @Identifier ";
                    
                    command.Parameters.AddWithValue("StoredQuantity", Quantity);
                    command.Parameters.AddWithValue("Identifier", ((Product)listBoxEnteringStock.SelectedItem).Identifier);
                    
                    command.ExecuteNonQuery();

                    command.CommandText = $"INSERT INTO StockMovement([Date], [EmployeeCode], [IsStockEntry]) " +
                        $"output INSERTED.[Identifier]" +
                        $" VALUES (@Date, @EmployeeCode, @IsStockEntry)";

                    command.Parameters.AddWithValue("Date", DateTime.Now);
                    command.Parameters.AddWithValue("EmployeeCode", textBoxEmployeeCode.Text);
                    command.Parameters.AddWithValue("IsStockEntry", _IsEntry);

                    // On récupère l'identifiant du stockMovement
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

        #region Sql
        // <summary>
        /// Met à jour la liste des produits.
        /// </summary>
        public void ForceRefreshList(SqlConnection sqlConnection)
        {
            listBoxEnteringStock.DataSource = null;

            Products = GetProduct(sqlConnection);
            listBoxEnteringStock.DataSource = Products;

            listBoxEnteringStock.DisplayMember = "Nom";
            listBoxEnteringStock.SelectedIndex = 0;

        }

        //Connexion à la base de données
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