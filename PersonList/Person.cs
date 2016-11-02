using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public Person(string _FirstName, string _LastName, string _Title)//constructor
        {
            _FirstName = FirstName;
            _LastName = LastName;
        }

    }
}
