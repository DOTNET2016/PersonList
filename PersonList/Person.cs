using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person : IComparable<Person>
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
        
        public int CompareTo(Person other)
        {
            if (this._lastName == other._lastName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            return this._lastName.CompareTo(other._lastName);
        }

        public static Person operator + (Person m1, Person f1)//I THINK THIS IS WRONG BUT SOMETHING TO GO FROM.....
        {
            return new Child(m1._firstName, f1._firstName, m1._lastName, f1._lastName);
        }

    }
}
