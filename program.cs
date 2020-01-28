using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference1
{
    class program
    {
        public static void Main(string[] args)
        {
            Office[] o = new Office[]{
                new Office(){Name="Epam",EmployeeNumber=1000 },new Office(){Name="Microsoft",EmployeeNumber=200 } };
            Array.Sort(o,new EmpNumber());
            Array.ForEach(o, x => Console.WriteLine(x.EmployeeNumber));
        }
    }
}
