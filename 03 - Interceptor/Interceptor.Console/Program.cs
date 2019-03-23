using Interceptor.Entidades;
using Interceptor.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using Interceptor.Base;

namespace Interceptor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                         .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=Northwind0123")
                         .ShowSql().FormatSql())
                         .Mappings(m =>
                             m.FluentMappings
                             .AddFromAssemblyOf<EmployeesMap>())
                         .ExposeConfiguration(config => config.SetInterceptor(new AuditInterceptor()))
                         .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            Orders order = new Orders()
            {
                Customer = new Customers() { CustomerID = "ANTON" },
                Employee = new Employees() { EmployeeID = 1 },
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now.AddDays(7),
            };

            session.SaveOrUpdate(order);
            session.Flush();
            session.Clear();

        }
    }
}
