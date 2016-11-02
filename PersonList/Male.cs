using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Male : Person
    {
        public string Mr { get; set; }

        public Male(string FirstName, string LastName)
            : base(FirstName, LastName)
        {
            
        }

        public override string ToString()
        {
            Mr = "Mr";
            return Mr + "   " + base.ToString();
        }
    }
}
