using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Female : Person
    {
        private string _Mrs { get; set; }
        private string _Ms { get; set; }

        public Female(string FemaleFirstName, string FemaleLastName) 
            : base(FemaleFirstName, FemaleLastName)
        {
            
        }

        public override string ToString()
        {
            _Ms = "Ms";
            return "Ms. " + base.ToString();
        }

    }
}
