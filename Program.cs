﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Saymon";
            person1.middleName = "Islam";
            person1.lastName = "Iftikar";

            string fullName = person1.GetFullName();

            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}