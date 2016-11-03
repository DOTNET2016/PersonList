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

        //public string FemaleFirstName { get; set; }
        //public string FemaleLastName { get; set; }

        public Female(string FirstName, string LastName) 
            : base(FirstName, LastName)
        {
            
        }

        public override string ToString()
        {
            _Ms = "Ms";
            return "Ms. " + base.ToString();
        }

    }
}
