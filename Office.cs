using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference1
{ 
    class Office : IComparable
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }

        public int CompareTo(object obj)
        {
            Office oj = obj as Office;
            if (oj != null)
            {
                return this.Name.CompareTo(oj.Name);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
       
        
    }
    

