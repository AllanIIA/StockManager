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
			set { _Label = value; }
		}
		#endregion
	}
}
