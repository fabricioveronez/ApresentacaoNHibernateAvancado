using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CacheL2.Entidades.Mapeamento
{
    public class ShippersMap : ClassMap<Shippers>
    {
        public ShippersMap()
        {
            Table("[Shippers]");
            Id(x => x.ShipperID, "[ShipperID]");
            Map(x => x.CompanyName, "[CompanyName]").Not.Nullable().Length(80);
            HasMany(x => x.Orders)
                .Table("[Orders]")
                .KeyColumn("[ShipperID]")
                .ForeignKeyConstraintName("[Orders.FK_Orders_Shippers]");
            Map(x => x.Phone, "[Phone]").Not.Nullable().Length(48); ;
        }
    }
}
