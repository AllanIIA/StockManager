using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class Product
    {
		#region Proprietes
		/// <summary>
		/// Identifiant du produit
		/// </summary>
		private int _Identifier;

		/// <summary>
		/// Nom du produit
		/// </summary>
		private string _Name;

		/// <summary>
		/// Reference du produit
		/// </summary>
		private string _Reference;

		/// <summary>
		/// Prix du produit
		/// </summary>
		private double _Price;

		/// <summary>
		/// Description du produit
		/// </summary>
		private string _Description;

		/// <summary>
		/// Quantité stockée du produit
		/// </summary>
		private int _StockedQuantity;

		/// <summary>
		/// Liaison Produit Catégory
		/// </summary>
		private int _IdentifierProductCategory;


		#endregion

		#region Attributes

		/// <summary>
		/// Identifiant du produit
		/// </summary>
		public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}


		/// <summary>
		/// Nom du produit
		/// </summary>
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}


		/// <summary>
		/// Reference du produit
		/// </summary>
		public string Reference
		{
			get { return _Reference; }
			set { _Reference = value; }
		}


		/// <summary>
		/// Prix du produit
		/// </summary>
		public double Price
		{
			get { return _Price; }
			set { _Price = value; }
		}


		/// <summary>
		/// Description du produit
		/// </summary>
		public string Description
		{
			get { return _Description; }
			set { _Description = value; }
		}


		/// <summary>
		/// Quantité stockée du produit
		/// </summary>
		public int StockedQuantity
		{
			get { return _StockedQuantity; }
			set { _StockedQuantity = value; }
		}

		/// <summary>
		/// Liaison Produit Catégory
		/// </summary>
		public int IdentifierProductCategory 
		{
			get { return _IdentifierProductCategory; }
			set { _IdentifierProductCategory = value; }
		}

		#region Constructors

		/// <summary>
		/// Produit
		/// </summary>
		/// <param name="name">Nom du produit</param>
		/// <param name="reference">Réference du produit</param>
		/// <param name="price">Prix du produit</param>
		/// <param name="stockedQuantity">Quantité stockée du produit</param>
		/// <param name="description">Description du produit</param>
		public Product(string name, string reference, int stockedQuantity, double price, string description)
		{
			Name = name;
			Reference = reference;
			Price = price;
			StockedQuantity = stockedQuantity;
			Description = description;

		}

		#endregion

		#endregion



	}
}
