using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMapeamento.Entidades
{
    public class OrderDetails
    {
        public virtual int OrderDetailsID { get; set; }
        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual double Discount { get; set; }
    }
}
