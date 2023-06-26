using System;
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
            //For Value Type and Reference Type
            Person person1 = new Person();
            person1.firstName = "Saymon";
            person1.middleName = "Islam";
            person1.lastName = "Iftikar";

            string fullName = person1.GetFullName();
            Console.WriteLine(fullName);

            Person person2 = new Person();
            person2.firstName = "MD";
            person2.middleName = "Kamal";
            person2.lastName = "Hossain";

            fullName = person2.GetFullName();

            Console.WriteLine(fullName);

            //End Value Type and Reference Type

            Console.WriteLine("\n");

            //For Data Hiding
            Console.WriteLine("Enter Your ID, Name and Address: \n");
            int ID = Convert.ToInt32(Console.ReadLine());
            string Name = Console.ReadLine();
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Your City: \n"); // using property set get method
            string city = Console.ReadLine();

            Student student1 = new Student();
            student1.SetId(ID);
            student1.SetName(Name);
            student1.SetAddress(Address);
            student1.City = city;   // called property instead of set city

            int Id1 = student1.GetId();
            string Name1 = student1.GetName();
            string Address1 = student1.GetAddress();
            string City1 = student1.City;  //called property instead of get city


            Console.WriteLine("\n");
            Console.WriteLine(Id1);
            Console.WriteLine(Name1);
            Console.WriteLine(Address1);
            Console.WriteLine(City1);
            //End Data Hiding
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
