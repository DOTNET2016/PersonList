using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Female : Person
    {
        public Female(Titles TitleNr, string FirstName, string LastName) //Female constructor
            : base(TitleNr, FirstName, LastName)
        {   
        }
    }
}
