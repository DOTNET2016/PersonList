using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person : IComparable<Person>
    {
        private string _firstName;
        private string _lastName;
        private int _titleNr;


        public Person(int TitleNr, string FirstName, string LastName)//constructor
        {
            _firstName = FirstName;
            _lastName = LastName;
            _titleNr = TitleNr;
        }

        public override string ToString()
        {
            return ((Titles)_titleNr) + " " + _firstName + " " + _lastName;
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

            switch (parent1._titleNr)
            {
                case 1:// Mr
                    newChild._firstName = parent2._firstName;
                    newChild._lastName = parent1._lastName;
                    newChild._titleNr = 3;
                    break;
                case 2:// Mrs
                    newChild._firstName = parent2._firstName;
                    newChild._lastName = parent1._lastName;
                    newChild._titleNr = 4;
                    break;
            }
            return newChild;
        }

        private enum Titles { Null, Mr, Mrs, Miss, Master }
    }
}
