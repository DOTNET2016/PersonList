﻿using System;
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

        private static string _childFirstName;
        private static string _childLastName;
        private static string _childTitleGirl;

        //public string FemaleFirstName { get; set; }
        //public string FemaleLastName { get; set; }
        //public string MaleFirstName { get; set; }
        //public string MaleLastName { get; set; }

        public Person(string FirstName, string LastName)//constructor
        {
            _firstName = FirstName;
            _lastName = LastName;

            _childTitleGirl = "Miss ";

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

        public static Child operator +(Person parent1, Person parent2)
        {
            Child newChild = new Child(_childFirstName, _childLastName);
            newChild.ChildFirstName = parent2._firstName;
            newChild.ChildLastName = parent1._lastName;
            newChild.ChildTitle = _childTitleGirl;
            newChild.ChildName = _childTitleGirl + " " + parent2._firstName + " " + parent1._lastName;

            return newChild;
        }
    }
}
