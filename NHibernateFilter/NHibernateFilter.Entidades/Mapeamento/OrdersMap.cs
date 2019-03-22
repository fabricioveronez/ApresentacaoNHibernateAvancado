using FluentNHibernate.Mapping;
using NHibernateFilter.Entidades.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernateFilter.Entidades.Mapeamento
{
    public class OrdersMap : ClassMap<Orders>
    {
        public OrdersMap()
        {
            Table("[Orders]");
            Id(x => x.OrderID, "[OrderID]").GeneratedBy.Identity();
            References(x => x.Customer)
                .ForeignKey("[Orders.FK_Orders_Customers]")
                .Column("[CustomerID]");
            References(x => x.Employee)
                .ForeignKey("[Orders.FK_Orders_Employees]")
                .Column("[EmployeeID]");
            Map(x => x.OrderDate, "[OrderDate]").Nullable().Length(8);
            Map(x => x.RequiredDate, "[RequiredDate]").Nullable().Length(8);
            Map(x => x.ShippedDate, "[ShippedDate]").Nullable().Length(8);
            References(x => x.Shipper)
                .ForeignKey("[Orders.FK_Orders_Employees]")
                .Columns("[ShipVia]");
            HasMany(x => x.OrderDetails)
                .Table("[OrderDetails]")
                .ForeignKeyConstraintName("[OrderDetails.FK_Order_Details_Orders]")
                .KeyColumn("[OrderID]");
            Map(x => x.Freight, "[Freight]").Nullable().Length(8).Precision(19);
            Map(x => x.ShipName, "[ShipName]").Nullable().Length(80);
            Map(x => x.ShipAddress, "[ShipAddress]").Nullable().Length(120);
            Map(x => x.ShipCity, "[ShipCity]").Nullable().Length(30);
            Map(x => x.ShipRegion, "[ShipRegion]").Nullable().Length(30);
            Map(x => x.ShipPostalCode, "[ShipPostalCode]").Nullable().Length(20);
            Map(x => x.ShipCountry, "[ShipCountry]").Nullable().Length(30);
            ApplyFilter<OrdersFilter>("EmployeeID = :idEmployee");
        }
    }
}
