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
        //variables
        private int _parsedId1;
        private int _parsedId2;
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Child NewBaby { get; set; }

        //checks the input from the user so that you cant enter strange characters
        public bool CheckInput()
        {
            if ((FirstName.Length == 0) || (LastName.Length == 0))
                return false;
            else if ((Regex.IsMatch(FirstName, @"^[-+\p{L}\p{N}]+$") == false) || (Regex.IsMatch(LastName, @"^[-+\p{L}\p{N}]+$") == false))
            {
                return false;
            }
            else if (int.TryParse(FirstName, out _parsedId1) || (int.TryParse(LastName, out _parsedId2)))
            {
                return false;
            }
            return true;
        }
        //method to control so that an adult and a child cant make a child
        public bool CheckInsest(Person p1, Person p2)
        { 
            if (p1._titleNr == Titles.Child)
            {
                CustomMessageBox.ShowBox("On No neighborinho,\n\nonly consenting ADULTS can do that!");
                return true;
            }
            else if (p2._titleNr == Titles.Child)
            {
                CustomMessageBox.ShowBox("On No neighborinho,\n\nonly consenting ADULTS can do that!");
                return true;
            }
            return false;
        }

        //method to make a new baby taking two people as arguments and combining them to make a new human being! (Child) 
        public Child MakeABaby(Person parent1, Person parent2)
        {
            NewBaby = parent1 + parent2;
            return NewBaby;
        }
    }
}
