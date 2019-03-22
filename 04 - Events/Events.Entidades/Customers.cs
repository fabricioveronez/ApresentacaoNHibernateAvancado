using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entidades
{
    public class Customers
    {

        public Customers()
        {
            this.CustomerDemographics = new List<CustomerDemographics>();
            this.Orders = new List<Orders>();
        }

        public virtual string CustomerID { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string ContactTitle { get; set; }
        public virtual IList<CustomerDemographics> CustomerDemographics { get; set; }
        public virtual IList<Orders> Orders { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Region { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
    }
}
