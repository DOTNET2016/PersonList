using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Child : Person
    {
        public Child(string FirstName, string LastName) 
            : base(FirstName, LastName)
        {
        }
    }
}
