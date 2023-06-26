using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Student
    {
        private int ID;
        private string Name;
        private string Mark;
        private string city;

        public string City
        {
            set
            {
                city = value;
            }
            get { return city; }
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetId(int ID)
        {
            this.ID = ID;
        }
        public int GetId()
        {
            return ID;
        }

        public void SetMark(string Mark)
        {
            this.Mark = Mark;
        }
        public string GetMark()
        {
            return Mark;
        }
    }
}
