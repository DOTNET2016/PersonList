using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Female : Person
    {
        public Female(int Title, string FirstName, string LastName) 
            : base(Title, FirstName, LastName)
        {   
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
