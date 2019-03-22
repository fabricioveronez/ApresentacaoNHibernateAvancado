using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploNMais1.Entidades
{
    public class Shippers
    {

        public Shippers()
        {
            this.Orders = new List<Orders>();
        }

        public virtual int ShipperID { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual IList<Orders> Orders { get; set; }
        public virtual string Phone { get; set; }
    }
}
