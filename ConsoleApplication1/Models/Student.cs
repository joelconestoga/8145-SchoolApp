using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApp
{
    public class Student
    {
        private int _id;
        public int ID { get; private set; }
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Address { get; set; }
        public long Contact  { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
    }
}