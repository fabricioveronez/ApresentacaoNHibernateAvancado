using System;
using System.Collections.Generic;
using System.Text;

namespace Interceptor.Entidades
{
    public class Products
    {

        public Products()
        {
            this.OrdersDetail = new List<OrderDetails>();
        }

        public virtual int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual Categories Category { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual IList<OrderDetails> OrdersDetail { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int UnitsInStock { get; set; }
        public virtual int UnitsOnOrder { get; set; }
        public virtual int ReorderLevel { get; set; }
        public virtual bool Discontinued { get; set; }
    }
}
