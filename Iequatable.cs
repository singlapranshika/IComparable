using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iequatable
{
    public class Employee : IEquatable<Employee>
    {
        public string Account;
        public string Name;

        public Employee(string account, string name)
        {
            this.Account = account;
            this.Name = name;
        }

        public bool Equals(Employee other)
        {
            if (other == null) 
                return false;
            return (this.Account.Equals(other.Account));
        }
    }
    class Iequatable
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("HDFC", "Pranshika");
            Employee emp2 = new Employee("HDFC", "Ankur");
            Console.WriteLine(emp1.Equals(emp2));
        }
    }
}
