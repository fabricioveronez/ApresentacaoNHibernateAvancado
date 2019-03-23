using FluentNHibernate.Mapping;

namespace Interceptor.Entidades.Mapeamento
{
    public class OrderDetailsMap : ClassMap<OrderDetails>
    {
        public OrderDetailsMap()
        {
            Table("[OrderDetails]");
            Id(x => x.OrderDetailsID, "[OrderDetailsID]").GeneratedBy.Identity();
            References(x => x.Order)
                .ForeignKey("[OrderDetails.FK_Order_Details_Orders]")
                .Columns("[OrderID]");
            References(x => x.Product)
                .ForeignKey("[OrderDetails.FK_Order_Details_Products]")
                .Columns("[ProductID]"); 
            Map(x => x.UnitPrice, "[UnitPrice]").Not.Nullable().Length(8).Precision(19);
            Map(x => x.Quantity, "[Quantity]").Not.Nullable().Length(2).Precision(5);
            Map(x => x.Discount, "[Discount]").Not.Nullable().Length(4).Precision(24);
        }
    }
}
