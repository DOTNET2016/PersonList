using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Male : Person
    {
        public Male(Titles TitleNr, string FirstName, string LastName)//Male constructor
            : base(TitleNr, FirstName, LastName)
        {
        }     
    }
}
