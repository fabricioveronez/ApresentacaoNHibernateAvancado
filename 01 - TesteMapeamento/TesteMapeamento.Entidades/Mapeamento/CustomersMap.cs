using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteMapeamento.Entidades.Mapeamento
{
    public class CustomersMap : ClassMap<Customers>
    {
        public CustomersMap()
        {
            Table("[Customers]");
            Id(x => x.CustomerID, "[CustomerID]").Not.Nullable().Length(1);
            Map(x => x.CompanyName, "[CompanyName]").Not.Nullable().Length(40);
            Map(x => x.ContactName, "[ContactName]").Nullable().Length(30);
            Map(x => x.ContactTitle, "[ContactTitle]").Nullable().Length(30);
            HasManyToMany(x => x.CustomerDemographics)
                .Table("[CustomerCustomerDemo]")
                .ParentKeyColumn("[CustomerID]")
                .ChildKeyColumn("[CustomerTypeID]");
            HasMany(x => x.Orders)
                .Table("[Orders]")
                .KeyColumn("[CustomerID]")
                .ForeignKeyConstraintName("[Orders.FK_Orders_Customers]");
            Map(x => x.Address, "[Address]").Nullable().Length(60);
            Map(x => x.City, "[City]").Nullable().Length(15);
            Map(x => x.Region, "[Region]").Nullable().Length(15);
            Map(x => x.PostalCode, "[PostalCode]").Nullable().Length(10);
            Map(x => x.Country, "[Country]").Nullable().Length(15);
            Map(x => x.Phone, "[Phone]").Nullable().Length(24);
            Map(x => x.Fax, "[Fax]").Nullable().Length(24);
        }
    }
}
