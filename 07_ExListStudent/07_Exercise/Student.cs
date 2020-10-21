using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Exercise
{
    public class Student
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Class { get; set; }
        
        public List<Result> Exam { get; set; }

    }
}
