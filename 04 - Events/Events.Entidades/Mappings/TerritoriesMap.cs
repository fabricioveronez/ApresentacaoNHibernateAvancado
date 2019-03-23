using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entidades.Mapeamento
{
    public class TerritoriesMap : ClassMap<Territories>
    {
        public TerritoriesMap()
        {
            Table("[Territories]");
            Id(x => x.TerritoryID, "[TerritoryID]").Not.Nullable().Length(20);
            Map(x => x.TerritoryDescription, "[TerritoryDescription]").Not.Nullable().Length(50);
            HasManyToMany(x => x.Employees)
                .Table("[EmployeeTerritories]")
                .ParentKeyColumn("[TerritoryID]")
                .ChildKeyColumn("[EmployeeID]");
            References(x => x.Region, "[RegionID]")
                .ForeignKey("[Territories.FK_Territories_Region]");
        }
    }
}
