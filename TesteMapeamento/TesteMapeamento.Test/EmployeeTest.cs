using FluentNHibernate.Testing;
using System;
using System.Collections.Generic;
using TesteMapeamento.Entidades;
using TesteMapeamento.Test.Comparadores;
using Xunit;
using NHibernate;

namespace TesteMapeamento.Test
{
    public class EmployeeTest : IClassFixture<SessionHelper>
    {

        ISession session;

        public EmployeeTest(SessionHelper sessionHelper)
        {
            session = sessionHelper.Session;
        }

        [Fact]
        public void MappingTest()
        {

            var birthDate = DateTime.Now;
            var hireDate = DateTime.Now;

            new PersistenceSpecification<Employees>(session)
                .CheckProperty(c => c.Address, "Rua de teste, 45")
                .CheckProperty(c => c.BirthDate, DateTime.Now, new ComparadorData())
                .CheckProperty(c => c.City, "Rio de Janeiro")
                .CheckProperty(c => c.Country, "Brazil")
                .CheckProperty(c => c.Extension, "5176")
                .CheckProperty(c => c.FirstName, "Fulano")
                .CheckProperty(c => c.HireDate, DateTime.Now, new ComparadorData())
                .CheckProperty(c => c.HomePhone, "99999-9999")
                .CheckProperty(c => c.LastName, "De Tal")
                .CheckProperty(c => c.Notes, "Programador .NET")
                .CheckProperty(c => c.Supervisor, new Employees() { EmployeeID = 1 }, new ComparadorEmployees())
                .CheckProperty(c => c.Subordinates, new List<Employees>() {
                        new Employees(){ EmployeeID = 2 },
                        new Employees(){ EmployeeID = 3 }
                }, new ComparadorEmployees())
                .CheckProperty(c => c.PhotoPath, "c")
                .CheckProperty(c => c.PostalCode, "21921380")
                .CheckProperty(c => c.Region, "RIO")
                .CheckProperty(c => c.Title, "Programador")
                .CheckProperty(c => c.TitleOfCourtesy, "Sr.")
                .VerifyTheMappings();
        }
    }
}

