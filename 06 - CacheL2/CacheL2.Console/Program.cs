using CacheL2.Entidades;
using CacheL2.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace CacheL2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                         .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=Northwind;User ID=sa;Password=Northwind0123")
                         .ShowSql().FormatSql())
                         .Cache(c => 
                            c.UseSecondLevelCache().ProviderClass<NHibernate.Caches.StackExchangeRedis.RedisCacheProvider>()
                         )
                         .Mappings(m =>
                             m.FluentMappings.AddFromAssemblyOf<EmployeesMap>()
                         )
                         .ExposeConfiguration(cfg => cfg.SetProperty("cache.configuration", "localhost:6379"))
                         .BuildSessionFactory();

            using ISession session1 = sessionFactory.OpenSession();
            Products product1 = session1.Get<Products>(1);

            System.Console.WriteLine(product1.ProductName);

            using ISession session2 = sessionFactory.OpenSession();
            Products product2 = session2.Get<Products>(1);

            System.Console.WriteLine(product2.ProductName);
        }
    }
}
