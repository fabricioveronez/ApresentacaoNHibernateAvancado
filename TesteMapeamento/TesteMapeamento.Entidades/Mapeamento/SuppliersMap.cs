using FluentNHibernate.Mapping;

namespace TesteMapeamento.Entidades.Mapeamento
{
    public class SuppliersMap : ClassMap<Suppliers>
    {
        public SuppliersMap()
        {
            Table("[Suppliers]");
            Id(x => x.SupplierID, "[SupplierID]").GeneratedBy.Identity();
            Map(x => x.CompanyName, "[CompanyName]").Not.Nullable().Length(80);
            Map(x => x.ContactName, "[ContactName]").Nullable().Length(60);
            Map(x => x.ContactTitle, "[ContactTitle]").Nullable().Length(60);
            Map(x => x.Address, "[Address]").Nullable().Length(120);
            Map(x => x.City, "[City]").Nullable().Length(30);
            Map(x => x.Region, "[Region]").Nullable().Length(30);
            Map(x => x.PostalCode, "[PostalCode]").Nullable().Length(20);
            HasMany(x => x.Products)
                .Table("[Products]")
                .KeyColumn("[SupplierID]")
                .ForeignKeyConstraintName("[Products.FK_Products_Suppliers]");
            Map(x => x.Country, "[Country]").Nullable().Length(30);
            Map(x => x.Phone, "[Phone]").Nullable().Length(48);
            Map(x => x.Fax, "[Fax]").Nullable().Length(48);
            Map(x => x.HomePage, "[HomePage]").Nullable().Length(16);
        }
    }
}
