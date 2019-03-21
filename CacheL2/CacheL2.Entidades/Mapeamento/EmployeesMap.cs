using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CacheL2.Entidades.Mapeamento
{
    public class EmployeesMap : ClassMap<Employees>
    {
        public EmployeesMap()
        {
            Table("[Employees]");
            Id(x => x.EmployeeID, "[EmployeeID]").GeneratedBy.Identity();
            Map(x => x.LastName, "[LastName]").Not.Nullable().Length(40);
            Map(x => x.FirstName, "[FirstName]").Not.Nullable().Length(20);
            Map(x => x.Title, "[Title]").Nullable().Length(60);
            Map(x => x.TitleOfCourtesy, "[TitleOfCourtesy]").Nullable().Length(50);
            Map(x => x.BirthDate, "[BirthDate]").Nullable().Length(8);
            HasManyToMany(x => x.Territories)
                .Table("[EmployeeTerritories]")
                .ParentKeyColumn("[EmployeeID]")
                .ChildKeyColumn("[TerritoryID]");
            Map(x => x.HireDate, "[HireDate]").Nullable().Length(8);
            Map(x => x.Address, "[Address]").Nullable().Length(120);
            Map(x => x.City, "[City]").Nullable().Length(30);
            Map(x => x.Region, "[Region]").Nullable().Length(30);
            Map(x => x.PostalCode, "[PostalCode]").Nullable().Length(20);
            Map(x => x.Country, "[Country]").Nullable().Length(30);
            Map(x => x.HomePhone, "[HomePhone]").Nullable().Length(48);
            Map(x => x.Extension, "[Extension]").Nullable().Length(8);
            Map(x => x.Photo, "[Photo]").Nullable().Length(16);
            Map(x => x.Notes, "[Notes]").Nullable().Length(16);
            HasMany(x => x.Orders)
                .Table("[Orders]")
                .KeyColumn("[EmployeeID]")
                .ForeignKeyConstraintName("[Orders.FK_Orders_Employees]");
            References(x => x.Supervisor)
                .ForeignKey("[Employees.FK_Employees_Employees]")
                .Columns("[ReportsTo]");
            HasMany(x => x.Subordinates)
                .KeyColumn("[EmployeeID]")
                .Table("[Employees]")
                .KeyColumn("[ReportsTo]")
                .ForeignKeyConstraintName("[Employees.FK_Employees_Employees]");
            Map(x => x.PhotoPath, "[PhotoPath]").Nullable().Length(510);
        }
    }
}
