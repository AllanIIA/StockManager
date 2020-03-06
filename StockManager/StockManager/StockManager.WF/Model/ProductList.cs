using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    class ProductList : Product
    {
        public ProductList(string name, string reference, string description, int stockedQuantity, double price)
            : base(name, reference, description, stockedQuantity, price)
        {

        }
    }
}
