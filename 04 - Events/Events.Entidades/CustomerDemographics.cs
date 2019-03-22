using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entidades
{
    public class CustomerDemographics
    {

        public CustomerDemographics()
        {
            this.Customers = new List<Customers>();
        }

        public virtual string CustomerTypeID { get; set; }
        public virtual IList<Customers> Customers { get; set; }
        public virtual string CustomerDesc { get; set; }
    }
}
