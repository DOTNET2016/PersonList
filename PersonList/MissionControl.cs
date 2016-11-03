using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    class MissionControl
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FemaleFirstName { get; set; }
        public string FemaleLastName { get; set; }
        public string MaleFirstName { get; set; }
        public string MaleLastName { get; set; }

        public bool CheckInput()
        {
            if ((FirstName.Length == 0) || (LastName.Length == 0))
                return false;
            return true;
        }
    }
}
