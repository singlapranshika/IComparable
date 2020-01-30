using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iequatable
{
    class Iequatable
    {
        static void Main(string[] args)
        {
            string s1 = "Pranshika";
            string s2 = String.Copy(s1);
            int num1 = 3;
            int num2 = 5;
            Console.WriteLine(num1.Equals(num2));
            Console.WriteLine(s1.Equals(s2));
        }
    }
}
