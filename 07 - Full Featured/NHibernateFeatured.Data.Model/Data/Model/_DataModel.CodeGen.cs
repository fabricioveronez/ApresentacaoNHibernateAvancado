using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NHibernateFeatured.Data.Model
{

	public abstract class EntityBase
	{
	
	}


	/// <summary>
	/// Classe Categories.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Categories: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) CategoryID da Categories.
		/// </summary>
		/// <remarks>Referencia Coluna Categories.CategoryID int</remarks>
		[DataMember]
		public virtual int CategoryID { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) CategoryName da Categories.
		/// </summary>
		/// <remarks>Referencia Coluna Categories.CategoryName nvarchar(15)</remarks>
		[DataMember]
		public virtual string CategoryName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Description da Categories.
		/// </summary>
		/// <remarks>Referencia Coluna Categories.Description ntext</remarks>
		[DataMember]
		public virtual string Description { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Picture da Categories.
		/// </summary>
		/// <remarks>Referencia Coluna Categories.Picture image</remarks>
		[DataMember]
		public virtual byte[] Picture { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Productss da Categories.
		/// </summary>
		[DataMember]
		public virtual IList<Products> Productss { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Categories))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Categories objTyped = (Categories)obj;
			bool returnValue = ((this.CategoryID.Equals(objTyped.CategoryID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.CategoryID.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe Customers.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Customers: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) Address da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.Address nvarchar(60)</remarks>
		[DataMember]
		public virtual string Address { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) City da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.City nvarchar(15)</remarks>
		[DataMember]
		public virtual string City { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) CompanyName da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.CompanyName nvarchar(40)</remarks>
		[DataMember]
		public virtual string CompanyName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ContactName da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.ContactName nvarchar(30)</remarks>
		[DataMember]
		public virtual string ContactName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ContactTitle da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.ContactTitle nvarchar(30)</remarks>
		[DataMember]
		public virtual string ContactTitle { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Country da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.Country nvarchar(15)</remarks>
		[DataMember]
		public virtual string Country { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) CustomerID da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.CustomerID nchar(5)</remarks>
		[DataMember]
		public virtual string CustomerID { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Fax da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.Fax nvarchar(24)</remarks>
		[DataMember]
		public virtual string Fax { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Orderss da Customers.
		/// </summary>
		[DataMember]
		public virtual IList<Orders> Orderss { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Phone da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.Phone nvarchar(24)</remarks>
		[DataMember]
		public virtual string Phone { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) PostalCode da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.PostalCode nvarchar(10)</remarks>
		[DataMember]
		public virtual string PostalCode { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Region da Customers.
		/// </summary>
		/// <remarks>Referencia Coluna Customers.Region nvarchar(15)</remarks>
		[DataMember]
		public virtual string Region { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Customers))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Customers objTyped = (Customers)obj;
			bool returnValue = ((this.CustomerID.Equals(objTyped.CustomerID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.CustomerID.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe Employees.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Employees: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) Address da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Address nvarchar(60)</remarks>
		[DataMember]
		public virtual string Address { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) BirthDate da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.BirthDate datetime</remarks>
		[DataMember]
		public virtual DateTime? BirthDate { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Child da Employees.
		/// </summary>
		[DataMember]
		public virtual IList<Employees> Child { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) City da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.City nvarchar(15)</remarks>
		[DataMember]
		public virtual string City { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Country da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Country nvarchar(15)</remarks>
		[DataMember]
		public virtual string Country { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) EmployeeID da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.EmployeeID int</remarks>
		[DataMember]
		public virtual int EmployeeID { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Extension da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Extension nvarchar(4)</remarks>
		[DataMember]
		public virtual string Extension { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) FirstName da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.FirstName nvarchar(10)</remarks>
		[DataMember]
		public virtual string FirstName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) HireDate da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.HireDate datetime</remarks>
		[DataMember]
		public virtual DateTime? HireDate { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) HomePhone da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.HomePhone nvarchar(24)</remarks>
		[DataMember]
		public virtual string HomePhone { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) LastName da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.LastName nvarchar(20)</remarks>
		[DataMember]
		public virtual string LastName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Notes da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Notes ntext</remarks>
		[DataMember]
		public virtual string Notes { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Orderss da Employees.
		/// </summary>
		[DataMember]
		public virtual IList<Orders> Orderss { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Photo da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Photo image</remarks>
		[DataMember]
		public virtual byte[] Photo { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) PhotoPath da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.PhotoPath nvarchar(255)</remarks>
		[DataMember]
		public virtual string PhotoPath { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) PostalCode da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.PostalCode nvarchar(10)</remarks>
		[DataMember]
		public virtual string PostalCode { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Region da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Region nvarchar(15)</remarks>
		[DataMember]
		public virtual string Region { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Title da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.Title nvarchar(30)</remarks>
		[DataMember]
		public virtual string Title { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) TitleOfCourtesy da Employees.
		/// </summary>
		/// <remarks>Referencia Coluna Employees.TitleOfCourtesy nvarchar(25)</remarks>
		[DataMember]
		public virtual string TitleOfCourtesy { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Parent da Employees.
		/// </summary>
		[DataMember]
		public virtual Employees Parent { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Employees))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Employees objTyped = (Employees)obj;
			bool returnValue = ((this.EmployeeID.Equals(objTyped.EmployeeID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.EmployeeID.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe OrderDetails.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class OrderDetails: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) Discount da OrderDetails.
		/// </summary>
		/// <remarks>Referencia Coluna OrderDetails.Discount real</remarks>
		[DataMember]
		public virtual float Discount { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Quantity da OrderDetails.
		/// </summary>
		/// <remarks>Referencia Coluna OrderDetails.Quantity smallint</remarks>
		[DataMember]
		public virtual short Quantity { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) UnitPrice da OrderDetails.
		/// </summary>
		/// <remarks>Referencia Coluna OrderDetails.UnitPrice money</remarks>
		[DataMember]
		public virtual decimal UnitPrice { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Orders da OrderDetails.
		/// </summary>
		[DataMember]
		public virtual Orders Orders { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Products da OrderDetails.
		/// </summary>
		[DataMember]
		public virtual Products Products { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is OrderDetails))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			OrderDetails objTyped = (OrderDetails)obj;
			bool returnValue = ((this.Orders.Equals(objTyped.Orders)) && (this.Products.Equals(objTyped.Products)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.Orders.GetHashCode() * this.Products.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe Orders.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Orders: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) Freight da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.Freight money</remarks>
		[DataMember]
		public virtual decimal? Freight { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) OrderDate da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.OrderDate datetime</remarks>
		[DataMember]
		public virtual DateTime? OrderDate { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) OrderDetailss da Orders.
		/// </summary>
		[DataMember]
		public virtual IList<OrderDetails> OrderDetailss { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) OrderID da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.OrderID int</remarks>
		[DataMember]
		public virtual int OrderID { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) RequiredDate da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.RequiredDate datetime</remarks>
		[DataMember]
		public virtual DateTime? RequiredDate { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipAddress da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShipAddress nvarchar(60)</remarks>
		[DataMember]
		public virtual string ShipAddress { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipCity da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShipCity nvarchar(15)</remarks>
		[DataMember]
		public virtual string ShipCity { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipCountry da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShipCountry nvarchar(15)</remarks>
		[DataMember]
		public virtual string ShipCountry { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipName da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShipName nvarchar(40)</remarks>
		[DataMember]
		public virtual string ShipName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShippedDate da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShippedDate datetime</remarks>
		[DataMember]
		public virtual DateTime? ShippedDate { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipPostalCode da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShipPostalCode nvarchar(10)</remarks>
		[DataMember]
		public virtual string ShipPostalCode { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipRegion da Orders.
		/// </summary>
		/// <remarks>Referencia Coluna Orders.ShipRegion nvarchar(15)</remarks>
		[DataMember]
		public virtual string ShipRegion { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Customers da Orders.
		/// </summary>
		[DataMember]
		public virtual Customers Customers { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Employees da Orders.
		/// </summary>
		[DataMember]
		public virtual Employees Employees { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Shippers da Orders.
		/// </summary>
		[DataMember]
		public virtual Shippers Shippers { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Orders))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Orders objTyped = (Orders)obj;
			bool returnValue = ((this.OrderID.Equals(objTyped.OrderID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.OrderID.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe Products.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Products: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) Discontinued da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.Discontinued bit</remarks>
		[DataMember]
		public virtual bool Discontinued { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) OrderDetailss da Products.
		/// </summary>
		[DataMember]
		public virtual IList<OrderDetails> OrderDetailss { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ProductID da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.ProductID int</remarks>
		[DataMember]
		public virtual int ProductID { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ProductName da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.ProductName nvarchar(40)</remarks>
		[DataMember]
		public virtual string ProductName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) QuantityPerUnit da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.QuantityPerUnit nvarchar(20)</remarks>
		[DataMember]
		public virtual string QuantityPerUnit { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ReorderLevel da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.ReorderLevel smallint</remarks>
		[DataMember]
		public virtual short? ReorderLevel { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) UnitPrice da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.UnitPrice money</remarks>
		[DataMember]
		public virtual decimal? UnitPrice { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) UnitsInStock da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.UnitsInStock smallint</remarks>
		[DataMember]
		public virtual short? UnitsInStock { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) UnitsOnOrder da Products.
		/// </summary>
		/// <remarks>Referencia Coluna Products.UnitsOnOrder smallint</remarks>
		[DataMember]
		public virtual short? UnitsOnOrder { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Categories da Products.
		/// </summary>
		[DataMember]
		public virtual Categories Categories { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Suppliers da Products.
		/// </summary>
		[DataMember]
		public virtual Suppliers Suppliers { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Products))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Products objTyped = (Products)obj;
			bool returnValue = ((this.ProductID.Equals(objTyped.ProductID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.ProductID.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe Shippers.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Shippers: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) CompanyName da Shippers.
		/// </summary>
		/// <remarks>Referencia Coluna Shippers.CompanyName nvarchar(40)</remarks>
		[DataMember]
		public virtual string CompanyName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Orderss da Shippers.
		/// </summary>
		[DataMember]
		public virtual IList<Orders> Orderss { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Phone da Shippers.
		/// </summary>
		/// <remarks>Referencia Coluna Shippers.Phone nvarchar(24)</remarks>
		[DataMember]
		public virtual string Phone { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ShipperID da Shippers.
		/// </summary>
		/// <remarks>Referencia Coluna Shippers.ShipperID int</remarks>
		[DataMember]
		public virtual int ShipperID { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Shippers))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Shippers objTyped = (Shippers)obj;
			bool returnValue = ((this.ShipperID.Equals(objTyped.ShipperID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.ShipperID.GetHashCode());
		}

		#endregion		

	}
	/// <summary>
	/// Classe Suppliers.
	/// </summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Suppliers: EntityBase
	{
		#region "Propriedades"

		
		/// <summary>
		/// Define ou obtém um(a) Address da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.Address nvarchar(60)</remarks>
		[DataMember]
		public virtual string Address { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) City da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.City nvarchar(15)</remarks>
		[DataMember]
		public virtual string City { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) CompanyName da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.CompanyName nvarchar(40)</remarks>
		[DataMember]
		public virtual string CompanyName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ContactName da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.ContactName nvarchar(30)</remarks>
		[DataMember]
		public virtual string ContactName { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) ContactTitle da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.ContactTitle nvarchar(30)</remarks>
		[DataMember]
		public virtual string ContactTitle { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Country da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.Country nvarchar(15)</remarks>
		[DataMember]
		public virtual string Country { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Fax da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.Fax nvarchar(24)</remarks>
		[DataMember]
		public virtual string Fax { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) HomePage da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.HomePage ntext</remarks>
		[DataMember]
		public virtual string HomePage { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Phone da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.Phone nvarchar(24)</remarks>
		[DataMember]
		public virtual string Phone { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) PostalCode da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.PostalCode nvarchar(10)</remarks>
		[DataMember]
		public virtual string PostalCode { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Productss da Suppliers.
		/// </summary>
		[DataMember]
		public virtual IList<Products> Productss { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) Region da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.Region nvarchar(15)</remarks>
		[DataMember]
		public virtual string Region { get; set; }
		
		/// <summary>
		/// Define ou obtém um(a) SupplierID da Suppliers.
		/// </summary>
		/// <remarks>Referencia Coluna Suppliers.SupplierID int</remarks>
		[DataMember]
		public virtual int SupplierID { get; set; }

		#endregion
		

		#region Equals/GetHashCode 


		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is Suppliers))
				return false;
			if (Object.ReferenceEquals(this, obj))
				return true;
			Suppliers objTyped = (Suppliers)obj;
			bool returnValue = ((this.SupplierID.Equals(objTyped.SupplierID)));
			return returnValue;
		}

		public override int GetHashCode()
		{
			return (this.SupplierID.GetHashCode());
		}

		#endregion		

	}
	
}
 
