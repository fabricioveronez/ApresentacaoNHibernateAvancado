using ExemploNMais1.Entidades;
using ExemploNMais1.Entidades.Mapeamento;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;

namespace ExemploNMais1.Console
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

            IEnumerable<Products> products = session.Query<Products>();
            //IEnumerable<Products> products = session.CreateCriteria<Products>().SetFetchMode("Category", FetchMode.Eager).List<Products>(); 

            foreach (var product in products)
            {
                System.Console.WriteLine ( $"{product.ProductName} - {product.Category.CategoryName}");
            }
        }
    }
}
