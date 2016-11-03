using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Child : Person
    {
        private string _lastName;

        public Child(string FirstName, string LastName, string Title) 
            : base(FirstName, LastName, Title)
        {

        }

        public Child(string FirstName, string LastName, string Title, string _lastName) : this(FirstName, LastName, Title)//CONSTRUCTOR TO THE OVERLOAD METHOD IN PERSON CLASS
        {
            this._lastName = _lastName;
        }
    }
}
