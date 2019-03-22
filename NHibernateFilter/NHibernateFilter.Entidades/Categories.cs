using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernateFilter.Entidades
{
    public class Categories
    {

        public Categories()
        {
            this.Products = new List<Products>();
        }

        public virtual int CategoryID { get; set; }
        public virtual IList<Products> Products { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string Description { get; set; }
        public virtual byte[] Picture { get; set; }
    }
}
