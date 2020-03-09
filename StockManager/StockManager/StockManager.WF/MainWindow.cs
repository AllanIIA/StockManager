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
using System.Data.SqlClient; 
namespace StockManager.WF
{
    public partial class MainWindow : Form
    {

        private static List<ProductCategory> _Categories = new List<ProductCategory>();
        private static List<Product> _Products = new List<Product>();
        public static string _ConnectionString = "Server=localhost;Database=StockManager;User Id=sa;Password=Sql2019;";
       

        #region Attibutes

        /// <summary>
        /// Liste des catégories de l'application
        /// </summary>
        private List<ProductCategory> _Categorie;

        #endregion
        #region Methods

        /// <summary>
        /// Obtien ou defini les catégories de l'application
        /// </summary>
        public List<ProductCategory> Categorie
        {
            get { return _Categorie; }
            set { _Categorie = value; }
        }
        #endregion


        #region Constructors

        /// <summary>
        /// Constucteur principale
        /// </summary>
        public MainWindow()
        {

            using (SqlConnection sqlConnection = new SqlConnection(_ConnectionString))
            {
                sqlConnection.Open(); //On ouvre la connexion
                _Categorie = GetProductCategory(sqlConnection);
                _Products = GetProduct(sqlConnection);
            }

            InitializeComponent();
        }


        #endregion
        /// <summary>
        /// Récupère les listes de Catégories
        /// </summary>
        /// <param name="sqlConnection"></param>
        private static List<ProductCategory> GetProductCategory(SqlConnection sqlConnection)
        {
            List<ProductCategory> productCategories = new List<ProductCategory>();

            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                //On préciser le texte de la commande
                command.CommandText = "SELECT Identifier, Label FROM ProductCategory";

                //On exécute la requête et on obtient un SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Tant qu'il y a des résultats, on passe au suivant
                    while (reader.Read())
                    {
                        ProductCategory productCategory = new ProductCategory();
                        _Categories.Add(productCategory);
                        //On passe dans la boucle pour chaque ligne
                        //GetInt32, GetString et IsDBNull attendent en paramètre
                        //Le numéro d'index de la colonne ici :
                        //0 : Identifier
                        //1 : Label

                        productCategory.Identifier = reader.GetInt32(0); //Lecture d'un entier
                        //Pour les champs NULL, il faut tester avant avec IsDBNull()
                        if (reader.IsDBNull(1) == false)
                        {
                            productCategory.Label = reader.GetString(1);  //Lecture d'une chaîne
                        }
                        //Console.WriteLine($"[{contactType.Identifier}] : {contactType.Label}");
                    }
                }
            }

            return productCategories;
        }

        /// <summary>
        /// Récupère les listes de Catégories
        /// </summary>
        /// <param name="sqlConnection"></param>
        private static List<Product> GetProduct(SqlConnection sqlConnection)
        {
            List<Product> products = new List<Product>();

            using (SqlCommand command = sqlConnection.CreateCommand())
            {
                //On préciser le texte de la commande
                command.CommandText = "SELECT Product.Identifier, Product.Nom, Product.Reference, Product.Price, Product.Description, Product.IdentifierProductCategory, Product.StoredQuantity " +
                    "FROM Product";


                //On exécute la requête et on obtient un SqlDataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //Tant qu'il y a des résultats, on passe au suivant
                    while (reader.Read())
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
            return products;
        }
        #region Methods 
        #endregion

        private void buttonManageProduct_Click(object sender, EventArgs e)
        {
            FormManageProduct formManageProduct = new FormManageProduct(_Products, _ConnectionString);
            formManageProduct.ShowDialog();
        }

        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory(_Categories);
            formManageCategory.ShowDialog();
        }

        private void buttonEnteringStock_Click(object sender, EventArgs e)
        {
            FormManageEnteringStock formManageEnteringStock = new FormManageEnteringStock(_Products, true);
            formManageEnteringStock.ShowDialog();
        }

        private void buttonLeavingStock_Click(object sender, EventArgs e)
        {
            FormManageLeavingStock formManageLeavingStock = new FormManageLeavingStock(_Products, false);
            formManageLeavingStock.ShowDialog();
        }
    }
}
