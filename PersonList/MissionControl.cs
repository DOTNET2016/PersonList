using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonList
{
    class MissionControl
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int parsedId1;
        private int parsedId2;

        public Child newBaby { get; set; }

        public bool CheckInput()
        {
            if ((FirstName.Length == 0) || (LastName.Length == 0))
                return false;
            else if ((Regex.IsMatch(FirstName, @"^[-+\p{L}\p{N}]+$") == false) || (Regex.IsMatch(LastName, @"^[-+\p{L}\p{N}]+$") == false))
            {
                return false;
            }
            else if (int.TryParse(FirstName, out parsedId1) || (int.TryParse(FirstName, out parsedId2)))
            {
                return false;
            }
            return true;
        }

        public Child MakeABaby(Person parent1, Person parent2)
        {
            newBaby = parent1 + parent2;
            return newBaby;
        }
    }
}
