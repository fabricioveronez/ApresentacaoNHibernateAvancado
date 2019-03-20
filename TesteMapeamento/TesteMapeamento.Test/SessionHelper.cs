using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using TesteMapeamento.Entidades.Mapeamento;

namespace TesteMapeamento.Test
{
    public class SessionHelper : IDisposable
    {

        public ISession Session { get; set; }
        private ITransaction transaction;

        public SessionHelper()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                          .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=Northwing0123"))
                          .Mappings(m =>
                              m.FluentMappings
                              .AddFromAssemblyOf<EmployeesMap>())
                          .BuildSessionFactory();

            Session = sessionFactory.OpenSession();
            transaction = Session.BeginTransaction();
        }

        public void Dispose()
        {
            transaction.Rollback();
        }
    }
}
