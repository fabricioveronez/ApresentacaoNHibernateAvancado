using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernateFilter.Entidades.Filters
{
    public class OrdersFilter : FilterDefinition
    {
        public OrdersFilter()
        {
            WithName("OrdersConditionFilter")
                .AddParameter("idEmployee", NHibernate.NHibernateUtil.Int32);
        }
    }
}
