using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person : IComparable<Person>
    {
        //variables
        private string _firstName;
        private string _lastName;
        public Titles _titleNr;

        public Person(Titles TitleNr, string FirstName, string LastName)//Person constructor
        {
            _firstName = FirstName;
            _lastName = LastName;
            _titleNr = TitleNr;
        }
        //override of the string method
        public override string ToString()
        {
            return (_titleNr) + ". " + _firstName + " " + _lastName;
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
        {   //new child object
            Child newChild = new Child(Titles.Child, "", "");
            //decides which order the childs names should be
            switch (parent1._titleNr)
            {
                case Titles.Mr:// Mr
                    newChild._firstName = parent2._firstName;
                    newChild._lastName = parent1._lastName;
                    break;                 
                case Titles.Mrs:// Mrs
                    newChild._firstName = parent2._firstName;
                    newChild._lastName = parent1._lastName;
                    break;
            }
            return newChild;
        }
    }
    //global enums to be used throughout the program
    public enum Titles { Null, Mr, Mrs, Child }
}
