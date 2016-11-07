using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Child : Person
    {

        public string ChildName { get; set; }
        public string ChildFirstName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildTitle { get; set; }

        public Child(string ChildFirstName, string ChildLastName) 
            : base(ChildFirstName, ChildLastName)
        {
            
        }
        public override string ToString()
        {
            return ChildTitle + " " + ChildFirstName + " " + ChildLastName;
        }
    }
}
