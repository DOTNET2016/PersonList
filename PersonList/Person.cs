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

        public Person(string Title, string FirstName, string LastName)//constructor
        {
            _firstName = FirstName;
            _lastName = LastName;
            _title = Title;

        }

        private enum Titles { Null, Mr, Mrs, Ms, Miss, Master }

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

        public static Child operator +(Person parent1, Person parent2)
        {
            Child newChild = new Child("0","", "");
            newChild._firstName = parent2._firstName;
            newChild._lastName = parent1._lastName;
            newChild._title = "4";

            return newChild;
        }
    }
}
