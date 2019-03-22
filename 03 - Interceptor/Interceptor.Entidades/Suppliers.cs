using System;
using System.Collections.Generic;
using System.Text;

namespace Interceptor.Entidades
{
    public class Suppliers
    {
        public Suppliers()
        {
            this.Products = new List<Products>();
        }

        public virtual int SupplierID { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string ContactTitle { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Region { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual IList<Products> Products { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string HomePage { get; set; }
    }
}
