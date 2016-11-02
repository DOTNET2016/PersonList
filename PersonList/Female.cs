using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class Female : Person
    {
        public string Mrs { get; set; }
        public string Ms { get; set; }

        public Female(string _FirstName, string _LastName, string _Title) : base(_FirstName, _LastName, _Title)
        {


        }
    }
}
