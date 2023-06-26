﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public Address PresentAddress { get; set; }
        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
