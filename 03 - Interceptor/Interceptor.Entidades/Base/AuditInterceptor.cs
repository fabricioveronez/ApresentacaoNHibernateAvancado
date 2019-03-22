using System;
using Interceptor.Base;
using NHibernate;
using NHibernate.Type;

namespace Interceptor.Base
{
    public class AuditInterceptor : EmptyInterceptor
    {

        public override void OnDelete(object entity,
                                      object id,
                                      object[] state,
                                      string[] propertyNames,
                                      IType[] types)
        {

        }

        public override bool OnFlushDirty(object entity,
                                          object id,
                                          object[] currentState,
                                          object[] previousState,
                                          string[] propertyNames,
                                          IType[] types)
        {
            return false;
        }

        public override bool OnLoad(object entity,
                                    object id,
                                    object[] state,
                                    string[] propertyNames,
                                    IType[] types)
        {
            return false;
        }

        public override bool OnSave(object entity,
                                    object id,
                                    object[] state,
                                    string[] propertyNames,
                                    IType[] types)
        {
            if (entity is AuditableEntity)
            {
                for (int i = 0; i < propertyNames.Length; i++)
                {
                    if ("OrderDate".Equals(propertyNames[i]))
                    {
                        state[i] = DateTime.Now;

                        return true;
                    }
                }
            }
            return false;
        }

        public override void AfterTransactionCompletion(ITransaction tx)
        {

        }
    }
}