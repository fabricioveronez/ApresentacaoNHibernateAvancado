using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploNMais1.Entidades
{
    public class OrderDetails
    {
        public virtual int OrderID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual double Discount { get; set; }
    }
}
