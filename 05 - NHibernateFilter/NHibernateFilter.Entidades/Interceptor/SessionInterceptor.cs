using NHibernate;
using NHibernate.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernateFilter.Entidades.Interceptor
{
    public class SessionInterceptor : EmptyInterceptor
    {
        public override void SetSession(ISession session)
        {
            session.EnableFilter("OrdersConditionFilter").SetParameter("idEmployee", 1);
        }
    }
}
