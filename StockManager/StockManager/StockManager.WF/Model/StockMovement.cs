using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class StockMovement
    {
		#region Properties
		/// <summary>
		/// Identifiant StockMovement
		/// </summary>
		private int _Identifier;

		/// <summary>
		/// Date de mouvement du produit
		/// </summary>
		private DateTime _Date;

		/// <summary>
		/// Code de l'employée qui a déplacé le produit
		/// </summary>
		private string _EmployeeCode;

		/// <summary>
		/// Stock d'entrée
		/// </summary>
		private bool _IsStockEntry;
		#endregion

		#region Attributes
		/// <summary>
		/// Identifiant StockMovement
		/// </summary>
		public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}
	
		/// <summary>
		/// Date de mouvement du produit
		/// </summary>
		public DateTime  Date
		{
			get { return _Date; }
			set { _Date = value; }
		}

		/// <summary>
		/// Code de l'employée qui a déplacé le produit
		/// </summary>
		public string EmployeeCode
		{
			get { return _EmployeeCode; }
			set { _EmployeeCode = value; }
		}

		
		/// <summary>
		/// Stock d'entrée
		/// </summary>
		public bool IsStockEntry
		{
			get { return _IsStockEntry; }
			set { _IsStockEntry = value; }
		}


		#endregion

	}
}
