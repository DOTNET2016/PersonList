using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person : IComparable
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _title { get; set; }

        public Person(string FirstName, string LastName, string Title)//constructor
        {
            _firstName = FirstName;
            _lastName = LastName;
            _title = Title;
        }

        public override string ToString()
        {
            return _title + " " + _firstName + " " + _lastName;
        }

        public int CompareTo(object obj)
        {
            return _firstName.CompareTo(obj);
        }
    }
}
