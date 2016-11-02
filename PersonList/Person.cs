using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public Person(string FirstName, string LastName)//constructor
        {
            _firstName = FirstName;
            _lastName = LastName;
        }
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

    }
}
