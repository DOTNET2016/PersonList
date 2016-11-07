using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public class Male : Person
    {
        public string Mr { get; set; }

        public Male(string MaleFirstName, string MaleLastName)
            : base(MaleFirstName, MaleLastName)
        {
            
        }

        public override string ToString()
        {
            Mr = "Mr.";
            return Mr + "  " + base.ToString();
        }

        
    }
}
