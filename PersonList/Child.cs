using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Child : Person
    {
        public Child(string Title, string FirstName, string LastName) 
            : base(Title, FirstName, LastName)
        {  
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
