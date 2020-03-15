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
    public partial class FormManageProduct : Form
    {


        #region Attributes
        /// <summary>
        /// Liste des produits de l'application
        /// </summary>
        private List<Product> _Products;


        /// <summary>
        /// Liste des catégories de l'applications
        /// </summary>
        private List<ProductCategory> _Category;

        /// <summary>
        /// Permet la connexion à la base de données
        /// </summary>
        private string _ConnetionString;

        /// <summary>
        /// Permet la connexion à la Base de données
        /// </summary>
        public string ConnectionString
        {
            get { return _ConnetionString; }
            set { _ConnetionString = value; }
        }


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

        /// <summary>
        /// Obtien ou defini la liste des categories de l'aplication
        /// </summary>
        public List<ProductCategory> Category
        {
            get { return _Category; }
            set { _Category = value; }
        }
        #endregion
        #region Constructors

        /// <summary>
        /// Constructeur Principale
        /// </summary>
        /// <param name="products"></param>
        public FormManageProduct(List<Product> products, List<ProductCategory> productCategory, string connectionString)
        {
            ConnectionString = connectionString;
            InitializeComponent();
            Products = products;
            Product product = new Product();
            product.Nom = "New Product";
            Products.Add(product);
            listBoxProductName.DataSource = Products;
            listBoxProductName.DisplayMember = "Nom";
            listBoxProductName.DisplayMember = nameof(Product.Nom);
            comboBoxCategory.DataSource = productCategory;
            comboBoxCategory.DisplayMember = "Label";

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
                listBoxProductName.Text = ((string)listBoxProductName.SelectedItem == "New Product" ? "" : ((string)(listBoxProductName.SelectedItem)));

            }
            if (listBoxProductName.SelectedItem is Product)
            {
                textBoxProductName.Text = ((Product)listBoxProductName.SelectedItem).Nom;
                textBoxProductReference.Text = ((Product)listBoxProductName.SelectedItem).Reference;
                textBoxProductDescription.Text = ((Product)listBoxProductName.SelectedItem).Description;
                Decimal Prix = ((Product)listBoxProductName.SelectedItem).Price;
                string PrixUnitaire = Prix.ToString();
                textBoxProductPrice.Text = PrixUnitaire;
                int Quantity = ((Product)listBoxProductName.SelectedItem).StoredQuantity;
                string QuantityTotal = Quantity.ToString();
                textBoxProductStockedQuantity.Text = QuantityTotal;


            }
        }

        
        /// <summary>
        /// Ajout ou mise à jour d'un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    if (((Product)listBoxProductName.SelectedItem).Nom == "New Product") 
                    {
                        command.CommandText = $"INSERT INTO Product([Nom], [Reference], [Price], [Description], [IdentifierProductCategory], [StoredQuantity]) VALUES (@Nom, @Reference, @Price, @Description, @IdentifierProductCategory, @StoredQuantity)";
                    }
                    else
                    {
                        command.CommandText = $"UPDATE Product SET "
                            + $"[Nom] = @Nom, "
                            + $"[Reference] = @Reference, "
                            + $"[Price] = @Price, "
                            + $"[Description] = @Description, "
                            + $"[IdentifierProductCategory] = @IdentifierProductCategory, "
                            + $"[StoredQuantity] = @StoredQuantity "
                            + $"WHERE [Identifier] = @Identifier ";
                    }

                    


                    command.Parameters.AddWithValue("Nom", textBoxProductName.Text);
                    command.Parameters.AddWithValue("Reference", textBoxProductReference.Text);
                    command.Parameters.AddWithValue("Price", Decimal.Parse(textBoxProductPrice.Text));
                    command.Parameters.AddWithValue("Description", textBoxProductDescription.Text);
                    command.Parameters.AddWithValue("IdentifierProductCategory",
                    ((ProductCategory)comboBoxCategory.SelectedItem).Identifier);
                    command.Parameters.AddWithValue("StoredQuantity", textBoxProductStockedQuantity.Text);
                    command.Parameters.AddWithValue("Identifier",
                            ((Product)listBoxProductName.SelectedItem).Identifier);
                    command.ExecuteNonQuery();
                }

                ForceRefreshList(sqlConnection);

                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Suppression d'un produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                Product productToDelete = _Products.First(selectedProduct =>
                selectedProduct.Nom == ((Product)listBoxProductName.SelectedItem).Nom);

                //On ouvre la connexion.
                sqlConnection.Open(); 

                using (SqlCommand command = sqlConnection.CreateCommand())
                {
                    command.CommandText = $"DELETE FROM Product WHERE Identifier = @Identifier ";

                    command.Parameters.AddWithValue("Identifier",
                        (object)productToDelete.Identifier ?? DBNull.Value);
                    command.ExecuteNonQuery();
                }
                // Actualise l'affichage de la listbox.
                ForceRefreshList(sqlConnection);

                // On ferme la connection.
                sqlConnection.Close();
            }

        }

        #region Sql
        // <summary>
        /// met à jour la liste des produits.
        /// </summary>
        public void ForceRefreshList(SqlConnection sqlConnection)
        {
            listBoxProductName.DataSource = null;

            Products = GetProduct(sqlConnection);
            AddNewProduct();
            listBoxProductName.DataSource = Products;

            listBoxProductName.DisplayMember = "Nom";
            listBoxProductName.SelectedIndex = 0;

        }


        /// <summary>
        /// Connexion à la base de données
        /// </summary>
        /// <param name="sqlConnection"></param>
        /// <returns></returns>
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

        private void AddNewProduct()
        {
            // Vérifie si un nouveau produit est déja présent.
            if (!Products.Any(newProduct => newProduct.Nom == "New Product"))
            {
                // Sinon on l'ajoute.
                Product product = new Product();
                product.Nom = "New Product";
                ProductCategory productCategory = new ProductCategory();
                productCategory.Identifier = -1;
                productCategory.Label = "";
                product.IdentifierProductCategory = 0;

                Products.Add(product);
            }
        }



    }



}

