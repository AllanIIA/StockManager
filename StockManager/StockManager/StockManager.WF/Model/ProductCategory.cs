using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class ProductCategory
    {

		#region Properties
		/// <summary>
		/// Identifiant de la categorie du produit
		/// </summary>
		private int _Identifier;

		/// <summary>
		/// Label de la categorie du produit
		/// </summary>
		private string _Label;

		/// <summary>
		/// Liste des produits de la catégorie
		/// </summary>
		private List<Product> _Products;

		#endregion

		#region Attributes
		/// <summary>
		/// Identifiant de la categorie du produit
		/// </summary>
		public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}

		/// <summary>
		/// Label de la categorie du produit
		/// </summary>
		public string Label
		{
			get { return _Label; }
			private set { _Label = value; }
		}

		/// <summary>
		/// Obtient ou défini la liste des produits
		/// </summary>
		public List<Product> Products
		{
			get { return _Products; }
			private set { _Products = value; }
		}
		#endregion


		#region Constructors
		/// <summary>
		/// Instancie une nouvelle catégorie de produits
		/// </summary>
		/// <param label="label">Label de la catégorie</param>
		public ProductCategory(string label)
		{
			// défini le label de la catégorie
			Label = label;
			this.Products = new List<Product>();
		}

		#endregion
	}
}
