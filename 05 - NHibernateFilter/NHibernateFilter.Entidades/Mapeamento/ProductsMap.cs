using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernateFilter.Entidades.Mapeamento
{
    public class ProductsMap : ClassMap<Products>
    {
        public ProductsMap()
        {
            Table("[Products]");
            Id(x => x.ProductID, "[ProductID]").GeneratedBy.Identity();
            Map(x => x.ProductName, "[ProductName]").Not.Nullable().Length(80);
            References(x => x.Supplier)
                .ForeignKey("[Products.FK_Products_Suppliers]")
                .Columns("[SupplierID]");
            References(x => x.Category)
                .ForeignKey("[Products.FK_Products_Categories]")
                .Columns("[CategoryID]");
            Map(x => x.QuantityPerUnit, "[QuantityPerUnit]").Nullable().Length(40);
            HasMany(x => x.OrdersDetail).Table("OrderDetails").KeyColumn("ProductID");
            Map(x => x.UnitPrice, "[UnitPrice]").Nullable().Length(8).Precision(19);
            Map(x => x.UnitsInStock, "[UnitsInStock]").Nullable().Length(2).Precision(5);
            Map(x => x.UnitsOnOrder, "[UnitsOnOrder]").Nullable().Length(2).Precision(5);
            Map(x => x.ReorderLevel, "[ReorderLevel]").Nullable().Length(2).Precision(5);
            Map(x => x.Discontinued, "[Discontinued]").Not.Nullable().Length(1);
        }
    }
}
