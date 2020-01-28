using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference1
{
    class EmpNumber : IComparer<Office>
    {
        public int Compare(Office x, Office y)
        {
            return x.EmployeeNumber.CompareTo(y.EmployeeNumber);
            // throw new NotImplementedException();
        }
    }
}
