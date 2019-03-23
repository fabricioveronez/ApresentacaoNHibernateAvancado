using FluentNHibernate.Mapping;

namespace ExemploNMais1.Entidades.Mapeamento
{
    public class CategoriesMap : ClassMap<Categories>
    {
        public CategoriesMap()
        {
            Table("[Categories]");
            Id(x => x.CategoryID, "[CategoryID]").GeneratedBy.Identity();
            HasMany(x => x.Products)
                .Table("[Products]")
                .KeyColumn("[CategoryID]")
                .ForeignKeyConstraintName("[Products.FK_Products_Categories]");
            Map(x => x.CategoryName, "[CategoryName]").Not.Nullable().Length(30);
            Map(x => x.Description, "[Description]").Nullable().Length(16);
            Map(x => x.Picture, "[Picture]").Nullable().Length(16);
        }
    }
}
