using NHibernateFilter.Entidades;
using NHibernateFilter.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernateFilter.Entidades.Interceptor;

namespace NHibernateFilter.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                         .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=Northwing0123")
                         .ShowSql().FormatSql())
                         .Mappings(m =>
                             m.FluentMappings
                             .AddFromAssemblyOf<EmployeesMap>())
                         .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();
            session.EnableFilter("OrdersConditionFilter").SetParameter("idEmployee", 1);

            IEnumerable<Orders> employees = session.Query<Orders>().Where(e => e.Customer.CustomerID.Equals("TORTU")).ToList();

            System.Console.WriteLine(string.Join('\n', employees.Select(o => o.OrderID)));
        }
    }
}
