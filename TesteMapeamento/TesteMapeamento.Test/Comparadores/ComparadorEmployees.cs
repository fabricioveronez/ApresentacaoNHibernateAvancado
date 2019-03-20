using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TesteMapeamento.Entidades;

namespace TesteMapeamento.Test.Comparadores
{
    public class ComparadorEmployees : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if (x is Employees && y is Employees)
            {
                return this.Compare((Employees)x, (Employees)y);
            }
            else if (x is IEnumerable<Employees> && y is IEnumerable<Employees>)
            {
                var xList = ((IEnumerable<Employees>)x).OrderBy(e => e.EmployeeID).ToArray();
                var yList = ((IEnumerable<Employees>)y).OrderBy(e => e.EmployeeID).ToArray();

                if (xList.Count() != yList.Count()) return false;

                for (int i = 0; i < xList.Count(); i++)
                {
                    if (xList[i].EmployeeID != yList[i].EmployeeID)
                    {
                        return false;
                    }
                }

                return true;
            }

            return x.Equals(y);
        }

        private bool Compare(Employees x, Employees y)
        {
            return x.EmployeeID == y.EmployeeID;
        }

        public int GetHashCode(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
