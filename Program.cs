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
            //Start Value Type and Reference Type
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

            //Start Data Hiding
            Console.WriteLine("Enter Your ID, Name and Address: \n");
            int ID = Convert.ToInt32(Console.ReadLine());
            string Name = Console.ReadLine();
            string Mark = Console.ReadLine();
            Console.WriteLine("Enter Your City: \n"); // using property set get method
            string city = Console.ReadLine();

            Student student1 = new Student();
            student1.SetId(ID);
            student1.SetName(Name);
            student1.SetMark(Mark);
            student1.City = city;   // called property instead of set city

            int Id1 = student1.GetId();
            string Name1 = student1.GetName();
            string Mark1 = student1.GetMark();
            string City1 = student1.City;  //called property instead of get city


            Console.WriteLine("\n");
            Console.WriteLine(Id1);
            Console.WriteLine(Name1);
            Console.WriteLine(Mark1);
            Console.WriteLine(City1);
            //End Data Hiding
            /
            // Start one to one association relationship
            /*
            Address address1 = new Address();
            address1.RoadNo = "02";
            address1.PostCode = "1219";
            address1.Area = "Rampura";
            address1.District = "Dhaka";

            Person person4 = new Person();
            person4.PresentAddress = address1;
            Address myAddress = person4.PresentAddress;
            Console.WriteLine(myAddress);
            */
            // End one to one association relationship

            // Start one to many association relationship
            /*
            Course course1 = new Course();
            course1.Code = "CSE4107";
            course1.Title = "Artificial Intelligence";
            course1.Credit = 3.0;

            Course course2 = new Course();
            course2.Code = "CSE4107";
            course2.Title = "Artificial Intelligence";
            course2.Credit = 3.0;

            Course course3 = new Course();
            course3.Code = "CSE4107";
            course3.Title = "Artificial Intelligence";
            course3.Credit = 3.0;

            Department department1 = new Department();
            department1.Code = "CSE";
            department1.Name = "Computer Science and Engineering";
            department1.Courses.Add(course1);
            department1.Courses.Add(course2);
            department1.Courses.Add(course3);

            //foreach(Course course in department1.Courses)
            //{
            //    Console.WriteLine(course.GetInfo());
            //}
            Console.WriteLine(department1.GetInfo());
            */
            //End one to many association relationship
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
