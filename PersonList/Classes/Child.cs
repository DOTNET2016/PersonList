using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Child : Person
    {
        public Child(Titles TitleNr, string FirstName, string LastName) //Child constructor
            : base(TitleNr, FirstName, LastName)
        {
        }
    }
}
