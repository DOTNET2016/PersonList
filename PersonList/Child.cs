using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Child : Person
    {
        public string Miss { get; set; }
        public string Master { get; set; }

        public Child(string _FirstName, string _LastName, string _Title) : base(_FirstName, _LastName, _Title)
        {


        }
    }
}
