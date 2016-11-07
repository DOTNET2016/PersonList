using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person : IComparable<Person>
    {
        private string firstName;
        private string lastName;
        private int title;

        private string _firstName
        { 
            get
                {
                    return firstName;
                }
            set
                {
                    firstName = value;
                }
        }

        private string _lastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private int _title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public Person(int Title, string FirstName, string LastName)//constructor
        {
            firstName = FirstName;
            lastName = LastName;
            title = Title;
        }

        private enum Titles { Null, Mr, Mrs, Ms, Miss, Master }

        public override string ToString()
        {
            return ((Titles)_title) + " " + _firstName + " " + _lastName;
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
            Child newChild = new Child(0,"", "");
            newChild._firstName = parent2._firstName;
            newChild._lastName = parent1._lastName;
            newChild._title = 4;

            return newChild;
        }
    }
}
