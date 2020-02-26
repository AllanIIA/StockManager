using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class StockMovementProduct
    {
        #region Properties

        /// <summary>
		/// Identifiant StockMovementProduct
		/// </summary>
		private int _Identifier;

        /// <summary>
        /// Identifiant du produit
        /// </summary>
        private int _IdentifierProduct;

        /// <summary>
        /// Identifiant du StockMovement
        /// </summary>
        private int _IdentifierStockmovement;

        /// <summary>
        /// Quantité du StcokMovementProduct
        /// </summary>
        private int _Quantity;

      

        #endregion

        #region Attributes

        /// <summary>
        /// Identifiant StockMovementProduct
        /// </summary>
        public int Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; }
        }

        /// <summary>
        /// Identifiant du produit
        /// </summary>
        public int IdentifierProduct
        {
            get { return _IdentifierProduct; }
            set { _IdentifierProduct = value; }
        }

        /// <summary>
        /// Identifiant du StockMovement
        /// </summary>
        public int IdentifierStockmovement
        {
            get { return _IdentifierStockmovement; }
            set { _IdentifierStockmovement = value; }
        }

        /// <summary>
        /// Quantité du StcokMovementProduct
        /// </summary>
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        #endregion


    }
}
