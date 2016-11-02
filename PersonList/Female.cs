using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Female : Person
    {
        public Female(string FirstName, string LastName) 
            : base(FirstName, LastName)
        {
        }

        public override string ToString()
        {
            return "Ms. " + base.ToString();
        }
    }
}
