using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Department
    {
        public Department() 
        {
            Courses = new List<Course>();
        }
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { get; set; }

        public string GetInfo()
        {
            string Info = "Code: " + Code + "Name: " + Name+ Environment.NewLine;
            foreach(Course course in Courses)
            {
                Info += course.GetInfo()+"\n";
            }
            return Info;
        }
    }
}
