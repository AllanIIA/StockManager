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
		#endregion

		#region Methods
		/// <summary>
		/// Obtient ou défini la liste des catégories de l'application
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

            // tags
            Categories = new List<string>();
            Categories.Add("Action");
            Categories.Add("Aventure");
            Categories.Add("Fantastic");
            #endregion


        }


        #endregion
        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory(Categories);
            formManageCategory.ShowDialog();
        }
    }
}
