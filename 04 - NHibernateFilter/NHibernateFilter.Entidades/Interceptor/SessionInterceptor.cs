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

        public override bool OnLoad(object entity, object id, object[] state, string[] propertyNames, IType[] types)
        {
            return base.OnLoad(entity, id, state, propertyNames, types);
        }

        public override void AfterTransactionBegin(ITransaction tx)
        {
            base.AfterTransactionBegin(tx);
        }
    }
}
