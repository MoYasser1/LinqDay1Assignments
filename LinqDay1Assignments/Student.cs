using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1Assignments
{
    internal class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
