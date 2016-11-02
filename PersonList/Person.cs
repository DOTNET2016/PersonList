using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public Person(string FirstName, string LastName)//constructor
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        public override string ToString()
        {
            return _firstName + _lastName;
        }

    }
}
