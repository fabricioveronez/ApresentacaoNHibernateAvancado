using System;
using System.Collections.Generic;
using System.Text;

namespace CacheL2.Entidades
{
    public class Region
    {

        public Region()
        {
            this.Territories = new List<Territories>();
        }

        public virtual int RegionID { get; set; }
        public virtual IList<Territories> Territories { get; set; }
        public virtual string RegionDescription { get; set; }
    }
}
