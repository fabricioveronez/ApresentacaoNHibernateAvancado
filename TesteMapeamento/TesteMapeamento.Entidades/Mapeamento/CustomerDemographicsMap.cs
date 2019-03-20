using FluentNHibernate.Mapping;

namespace TesteMapeamento.Entidades.Mapeamento
{
    public class CustomerDemographicsMap : ClassMap<CustomerDemographics>
    {
        public CustomerDemographicsMap()
        {
            Table("[CustomerDemographics]");
            Id(x => x.CustomerTypeID).Not.Nullable().Length(20);
            HasManyToMany(x => x.Customers)
                .Table("[CustomerCustomerDemo]")
                .ParentKeyColumn("[CustomerID]")
                .ChildKeyColumn("[CustomerTypeID]");
            Map(x => x.CustomerDesc, "[CustomerDesc]").Nullable().Length(16);
        }
    }
}
