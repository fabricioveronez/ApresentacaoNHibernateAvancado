using System;
using System.Collections.Generic;
using System.Text;

namespace Interceptor.Entidades
{
    public class Territories
    {
        public Territories()
        {
            this.Employees = new List<Employees>();
        }

        public virtual string TerritoryID { get; set; }
        public virtual string TerritoryDescription { get; set; }
        public virtual IList<Employees> Employees { get; set; }
        public virtual Region Region { get; set; }
    }
}
