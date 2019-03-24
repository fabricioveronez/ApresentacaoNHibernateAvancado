using System;
using System.Linq;
using System.Runtime.CompilerServices;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Criterion;
using NHibernateFeatured.Data.Mappings;
using NHibernateFeatured.Data.Model;

namespace NHibernateFeatured
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitDB();

            ISessionFactory sessionFactory = BuildSessionFactory();

            using ISession session = sessionFactory.OpenSession();

            Products product1 = session.Get<Products>(1);

            Products product2 = session.Query<Products>().FirstOrDefault(it => it.ProductID == 1);

            Products product3 = session.QueryOver<Products>().Where(it => it.ProductID == 1).SingleOrDefault();

            TestCaching(session, product3);

            Console.WriteLine("Hello World!");
        }

        private static ISessionFactory BuildSessionFactory()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                    .Database(
                            MsSqlConfiguration.MsSql2012
                            .ConnectionString("Data Source=mssql;Initial Catalog=Northwind;User ID=sa;Password=8k3W2C2BVzAW9p")
                            .ShowSql()
                            .FormatSql()
                        )
                    .Cache(c =>
                        c.UseSecondLevelCache().ProviderClass<NHibernate.Cache.HashtableCacheProvider>()
                    // Hashtable (not intended for production use)
                    //https://nhibernate.info/doc/nhibernate-reference/performance.html#performance-querycache
                    )
                    .Mappings(m =>
                        m.FluentMappings.AddFromAssemblyOf<EmployeesMapper>()
                    )
                    .ExposeConfiguration(cfg =>
                        cfg
                            .SetProperty("cache.use_query_cache", "true")
                            .SetProperty("cache.default_expiration", "5")
                            .SetProperty("cache.use_sliding_expiration", "true")

                    )
                    .BuildSessionFactory();

            return sessionFactory;
        }

        private static void WaitDB()
        {
            while (true)
            {
                try
                {
                    using var sessionFactory = Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=mssql;Initial Catalog=Northwind;User ID=sa;Password=8k3W2C2BVzAW9p"))
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EmployeesMapper>())
                        .BuildSessionFactory();

                    using var session = sessionFactory.OpenSession();
                    if (session.Get<Products>(1) == null)
                        throw new ApplicationException("Products has no data yet");

                    break;
                }
                catch (Exception ex)
                {
                    while (ex.InnerException != null)
                        ex = ex.InnerException;

                    Console.WriteLine("################################################");
                    Console.WriteLine("Waiting Database... " + ex.Message);
                    Console.WriteLine("################################################");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(15));
                }

            }

        }

        public static void TestCaching(ISession session, Products productFromOtherQueryStyle)
        {

            Products product = Customized(session);
            //product = productFromOtherQueryStyle;

            Customized(session);

            Customized(session);

            Customized(session);

            product.ProductName = product.ProductName;
            session.Update(product);
            session.Flush();

            Customized(session);

            Customized(session);

            Customized(session);

            Customized(session);

            product.ProductName += " 2";
            session.Update(product);
            session.Flush();

            Customized(session);

            Customized(session);

            Customized(session);

            Customized(session);
        }


        private static Products Customized(ISession session)
        {
            var product = session
                .CreateCriteria<Products>()
                .Add(Restrictions.Where<Products>(it => it.ProductID == 1))
                .Fetch(SelectMode.Skip, nameof(Products.Categories))
                .Fetch(SelectMode.Skip, nameof(Products.Suppliers))
                .SetCacheable(true)
                .SetCacheMode(CacheMode.Normal)
                .SetCacheRegion("Products")
                .List<Products>()[0];

            Console.WriteLine(product.ProductName);

            return product;
        }
    }
}
