 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using NHibernateFeatured.Data.Model;
using FluentNHibernate.Mapping;

namespace NHibernateFeatured.Data.Mappings
{
	public interface IApplicationMapping
	{
		FluentNHibernate.MappingModel.AttributeStore GetAttributes();
	}

	
	public partial class CategoriesMapper : ClassMap<NHibernateFeatured.Data.Model.Categories>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public CategoriesMapper()
		{
			Table("Categories");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.CategoryID, "CategoryID").GeneratedBy.Native("Categories_SEQ").CustomSqlType("int");
			Map(it => it.CategoryName, "CategoryName").Not.Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.Description, "Description").Nullable().CustomSqlType("ntext").Length(1073741823);
			Map(it => it.Picture, "Picture").Nullable().CustomSqlType("image");
			HasMany(x => x.Productss)
				.KeyColumns.Add("CategoryID")
				.ForeignKeyConstraintName("FK_Products_Categories")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			this.CompleteMappings();
		}
		
	}
	
	public partial class CustomersMapper : ClassMap<NHibernateFeatured.Data.Model.Customers>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public CustomersMapper()
		{
			Table("Customers");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.CustomerID, "CustomerID").GeneratedBy.Assigned().CustomSqlType("nchar(5)").Length(5);
			Map(it => it.Address, "Address").Nullable().CustomSqlType("nvarchar(60)").Length(60);
			Map(it => it.City, "City").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.CompanyName, "CompanyName").Not.Nullable().CustomSqlType("nvarchar(40)").Length(40);
			Map(it => it.ContactName, "ContactName").Nullable().CustomSqlType("nvarchar(30)").Length(30);
			Map(it => it.ContactTitle, "ContactTitle").Nullable().CustomSqlType("nvarchar(30)").Length(30);
			Map(it => it.Country, "Country").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.Fax, "Fax").Nullable().CustomSqlType("nvarchar(24)").Length(24);
			HasMany(x => x.Orderss)
				.KeyColumns.Add("CustomerID")
				.ForeignKeyConstraintName("FK_Orders_Customers")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			Map(it => it.Phone, "Phone").Nullable().CustomSqlType("nvarchar(24)").Length(24);
			Map(it => it.PostalCode, "PostalCode").Nullable().CustomSqlType("nvarchar(10)").Length(10);
			Map(it => it.Region, "Region").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			this.CompleteMappings();
		}
		
	}
	
	public partial class EmployeesMapper : ClassMap<NHibernateFeatured.Data.Model.Employees>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public EmployeesMapper()
		{
			Table("Employees");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.EmployeeID, "EmployeeID").GeneratedBy.Native("Employees_SEQ").CustomSqlType("int");
			Map(it => it.Address, "Address").Nullable().CustomSqlType("nvarchar(60)").Length(60);
			Map(it => it.BirthDate, "BirthDate").Nullable().CustomSqlType("datetime");
			HasMany(x => x.Child)
				.KeyColumns.Add("ReportsTo")
				.ForeignKeyConstraintName("FK_Employees_Employees")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			Map(it => it.City, "City").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.Country, "Country").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.Extension, "Extension").Nullable().CustomSqlType("nvarchar(4)").Length(4);
			Map(it => it.FirstName, "FirstName").Not.Nullable().CustomSqlType("nvarchar(10)").Length(10);
			Map(it => it.HireDate, "HireDate").Nullable().CustomSqlType("datetime");
			Map(it => it.HomePhone, "HomePhone").Nullable().CustomSqlType("nvarchar(24)").Length(24);
			Map(it => it.LastName, "LastName").Not.Nullable().CustomSqlType("nvarchar(20)").Length(20);
			Map(it => it.Notes, "Notes").Nullable().CustomSqlType("ntext").Length(1073741823);
			HasMany(x => x.Orderss)
				.KeyColumns.Add("EmployeeID")
				.ForeignKeyConstraintName("FK_Orders_Employees")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			References(x => x.Parent)
				.ForeignKey("FK_Employees_Employees")
				.Columns("ReportsTo")
				.Fetch.Join()				
				.Cascade.None();
			Map(it => it.Photo, "Photo").Nullable().CustomSqlType("image");
			Map(it => it.PhotoPath, "PhotoPath").Nullable().CustomSqlType("nvarchar(255)").Length(255);
			Map(it => it.PostalCode, "PostalCode").Nullable().CustomSqlType("nvarchar(10)").Length(10);
			Map(it => it.Region, "Region").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.Title, "Title").Nullable().CustomSqlType("nvarchar(30)").Length(30);
			Map(it => it.TitleOfCourtesy, "TitleOfCourtesy").Nullable().CustomSqlType("nvarchar(25)").Length(25);
			this.CompleteMappings();
		}
		
	}
	
	public partial class OrderDetailsMapper : ClassMap<NHibernateFeatured.Data.Model.OrderDetails>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public OrderDetailsMapper()
		{
			Table("OrderDetails");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			CompositeId()				
					.KeyReference(it => it.Orders, "OrderID")				
					.KeyReference(it => it.Products, "ProductID");
			Map(it => it.Discount, "Discount").Not.Nullable().CustomSqlType("real");
			Map(it => it.Quantity, "Quantity").Not.Nullable().CustomSqlType("smallint");
			Map(it => it.UnitPrice, "UnitPrice").Not.Nullable().CustomSqlType("money");
			this.CompleteMappings();
		}
		
	}
	
	public partial class OrdersMapper : ClassMap<NHibernateFeatured.Data.Model.Orders>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public OrdersMapper()
		{
			Table("Orders");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.OrderID, "OrderID").GeneratedBy.Native("Orders_SEQ").CustomSqlType("int");
			References(x => x.Customers)
				.ForeignKey("FK_Orders_Customers")
				.Columns("CustomerID")
				.Fetch.Join()				
				.Cascade.None();
			References(x => x.Employees)
				.ForeignKey("FK_Orders_Employees")
				.Columns("EmployeeID")
				.Fetch.Join()				
				.Cascade.None();
			Map(it => it.Freight, "Freight").Nullable().CustomSqlType("money");
			Map(it => it.OrderDate, "OrderDate").Nullable().CustomSqlType("datetime");
			HasMany(x => x.OrderDetailss)
				.KeyColumns.Add("OrderID")
				.ForeignKeyConstraintName("FK_Order_Details_Orders")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			Map(it => it.RequiredDate, "RequiredDate").Nullable().CustomSqlType("datetime");
			Map(it => it.ShipAddress, "ShipAddress").Nullable().CustomSqlType("nvarchar(60)").Length(60);
			Map(it => it.ShipCity, "ShipCity").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.ShipCountry, "ShipCountry").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.ShipName, "ShipName").Nullable().CustomSqlType("nvarchar(40)").Length(40);
			Map(it => it.ShippedDate, "ShippedDate").Nullable().CustomSqlType("datetime");
			References(x => x.Shippers)
				.ForeignKey("FK_Orders_Shippers")
				.Columns("ShipVia")
				.Fetch.Join()				
				.Cascade.None();
			Map(it => it.ShipPostalCode, "ShipPostalCode").Nullable().CustomSqlType("nvarchar(10)").Length(10);
			Map(it => it.ShipRegion, "ShipRegion").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			this.CompleteMappings();
		}
		
	}
	
	public partial class ProductsMapper : ClassMap<NHibernateFeatured.Data.Model.Products>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public ProductsMapper()
		{
			Table("Products");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.ProductID, "ProductID").GeneratedBy.Native("Products_SEQ").CustomSqlType("int");
			References(x => x.Categories)
				.ForeignKey("FK_Products_Categories")
				.Columns("CategoryID")
				.Fetch.Join()				
				.Cascade.None();
			Map(it => it.Discontinued, "Discontinued").Not.Nullable().CustomSqlType("bit");
			HasMany(x => x.OrderDetailss)
				.KeyColumns.Add("ProductID")
				.ForeignKeyConstraintName("FK_Order_Details_Products")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			Map(it => it.ProductName, "ProductName").Not.Nullable().CustomSqlType("nvarchar(40)").Length(40);
			Map(it => it.QuantityPerUnit, "QuantityPerUnit").Nullable().CustomSqlType("nvarchar(20)").Length(20);
			Map(it => it.ReorderLevel, "ReorderLevel").Nullable().CustomSqlType("smallint");
			References(x => x.Suppliers)
				.ForeignKey("FK_Products_Suppliers")
				.Columns("SupplierID")
				.Fetch.Join()				
				.Cascade.None();
			Map(it => it.UnitPrice, "UnitPrice").Nullable().CustomSqlType("money");
			Map(it => it.UnitsInStock, "UnitsInStock").Nullable().CustomSqlType("smallint");
			Map(it => it.UnitsOnOrder, "UnitsOnOrder").Nullable().CustomSqlType("smallint");
			this.CompleteMappings();
		}
		
	}
	
	public partial class ShippersMapper : ClassMap<NHibernateFeatured.Data.Model.Shippers>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public ShippersMapper()
		{
			Table("Shippers");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.ShipperID, "ShipperID").GeneratedBy.Native("Shippers_SEQ").CustomSqlType("int");
			Map(it => it.CompanyName, "CompanyName").Not.Nullable().CustomSqlType("nvarchar(40)").Length(40);
			HasMany(x => x.Orderss)
				.KeyColumns.Add("ShipVia")
				.ForeignKeyConstraintName("FK_Orders_Shippers")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			Map(it => it.Phone, "Phone").Nullable().CustomSqlType("nvarchar(24)").Length(24);
			this.CompleteMappings();
		}
		
	}
	
	public partial class SuppliersMapper : ClassMap<NHibernateFeatured.Data.Model.Suppliers>, IApplicationMapping
	{

		public FluentNHibernate.MappingModel.AttributeStore GetAttributes()
        {
            return this.attributes;
        }

		partial void CompleteMappings();

		public SuppliersMapper()
		{
			Table("Suppliers");
			
			OptimisticLock.None();
			
			DynamicUpdate();
			Id(it => it.SupplierID, "SupplierID").GeneratedBy.Native("Suppliers_SEQ").CustomSqlType("int");
			Map(it => it.Address, "Address").Nullable().CustomSqlType("nvarchar(60)").Length(60);
			Map(it => it.City, "City").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.CompanyName, "CompanyName").Not.Nullable().CustomSqlType("nvarchar(40)").Length(40);
			Map(it => it.ContactName, "ContactName").Nullable().CustomSqlType("nvarchar(30)").Length(30);
			Map(it => it.ContactTitle, "ContactTitle").Nullable().CustomSqlType("nvarchar(30)").Length(30);
			Map(it => it.Country, "Country").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			Map(it => it.Fax, "Fax").Nullable().CustomSqlType("nvarchar(24)").Length(24);
			Map(it => it.HomePage, "HomePage").Nullable().CustomSqlType("ntext").Length(1073741823);
			Map(it => it.Phone, "Phone").Nullable().CustomSqlType("nvarchar(24)").Length(24);
			Map(it => it.PostalCode, "PostalCode").Nullable().CustomSqlType("nvarchar(10)").Length(10);
			HasMany(x => x.Productss)
				.KeyColumns.Add("SupplierID")
				.ForeignKeyConstraintName("FK_Products_Suppliers")
				.Inverse()
				.Cascade.Delete()				
				.LazyLoad()
				.Fetch.Select()
				.AsBag();
			Map(it => it.Region, "Region").Nullable().CustomSqlType("nvarchar(15)").Length(15);
			this.CompleteMappings();
		}
		
	}
	
}
 




