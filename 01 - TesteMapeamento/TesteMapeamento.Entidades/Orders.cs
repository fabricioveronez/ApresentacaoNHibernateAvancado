using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMapeamento.Entidades
{
    public class Orders
    {

        public Orders()
        {
            this.OrderDetails = new List<OrderDetails>();
        }

        public virtual int OrderID { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual DateTime RequiredDate { get; set; }
        public virtual DateTime ShippedDate { get; set; }
        public virtual Shippers Shipper { get; set; }
        public virtual IList<OrderDetails> OrderDetails { get; set; }
        public virtual decimal Freight { get; set; }
        public virtual string ShipName { get; set; }
        public virtual string ShipAddress { get; set; }
        public virtual string ShipCity { get; set; }
        public virtual string ShipRegion { get; set; }
        public virtual string ShipPostalCode { get; set; }
        public virtual string ShipCountry { get; set; }
    }
}
