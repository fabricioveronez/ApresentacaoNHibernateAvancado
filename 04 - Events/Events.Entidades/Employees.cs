using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entidades
{
    public class Employees
    {

        public Employees()
        {
            this.Territories = new List<Territories>();
            this.Subordinates = new List<Employees>();
            this.Orders = new List<Orders>();
        }

        public virtual int EmployeeID { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Title { get; set; }
        public virtual string TitleOfCourtesy { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual IList<Territories> Territories { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Region { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string HomePhone { get; set; }
        public virtual string Extension { get; set; }
        public virtual byte[] Photo { get; set; }
        public virtual string Notes { get; set; }
        public virtual IList<Employees> Subordinates { get; set; }
        public virtual IList<Orders> Orders { get; set; }
        public virtual Employees Supervisor { get; set; }
        public virtual string PhotoPath { get; set; }
    }
}
