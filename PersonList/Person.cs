﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonList
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person(string Name, string LastName)
        { }
    }
}
