using Events.Entidades;
using Events.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Event;
using Events.Entidades.Listeners;
using System.Linq;
using System;

namespace Events.Console
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
                         .ExposeConfiguration(c => {
                             c.EventListeners.PostInsertEventListeners = new IPostInsertEventListener[] { new InsertListener() };
                             c.EventListeners.PostUpdateEventListeners = new IPostUpdateEventListener[] { new UpdateListener() };
                         })
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

            Orders orderUpdate = session.Load<Orders>(10251);
            orderUpdate.ShipCountry = "Brazil";
            session.SaveOrUpdate(orderUpdate);
           
            session.Flush();
        }
    }
}
