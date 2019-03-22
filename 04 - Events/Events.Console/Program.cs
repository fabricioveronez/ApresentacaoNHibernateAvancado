using Events.Entidades;
using Events.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Event;
using Events.Entidades.Listeners;
using System.Linq;

namespace Events.Console
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
                         .ExposeConfiguration(c =>
                            c.EventListeners.LoadEventListeners = new ILoadEventListener[] { new LoadListener() })
                         .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            var orders = session.Query<Orders>().ToList();

            //Orders order = new Orders()
            //{
            //    Customer = new Customers() { CustomerID = "ANTON" },
            //    Employee = new Employees() { EmployeeID = 1 },
            //    RequiredDate = DateTime.Now,
            //    ShippedDate = DateTime.Now.AddDays(7),
            //};

            //session.SaveOrUpdate(order);
            //session.Flush();
            //session.Clear();

        }
    }
}
