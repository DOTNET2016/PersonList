using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Female : Person
    {
        private string _Mrs { get; set; }
        private string _Ms { get; set; }

        public Female(string FirstName, string LastName, string Title) 
            : base(FirstName, LastName)
        {
        }

        public override string ToString()
        {
            return "Ms. " + base.ToString();
        }

    }
}
