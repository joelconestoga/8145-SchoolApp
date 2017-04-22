using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SchoolApp
{
    public class Teacher
    {
        // A teacher can have up to five classes, and 5 sections, 
        //  with a total of 20 hours as well over the whole week, and should have 8 items of information to be entered, including an Employee ID   


        private static int _employeeID;

        private const int MaxClassHours = 20;
        private const int MaxClasses = 5;
        private const int MaxSections = 5;

        public int EmployeeID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        private List<Classroom> _classes = new List<Classroom>();
        private List<Section> _sections = new List<Section>();

        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, long contact, string email, string gender, string address, string country)
        {
            EmployeeID = Interlocked.Increment(ref _employeeID);
            FirstName = firstName;
            LastName = lastName;
            Contact = contact;
            Email = email;
            Gender = gender;
            Address = address;
            Country = country;
        }

        public bool AddClass(Classroom classroom)
        {
            if (_classes.Count == MaxClasses)
            {
                return false;
            }

            _classes.Add(classroom);
            return true;
        }

        public bool AddSection(Section section)
        {
            if (_sections.Count == MaxSections)
            {
                return false;
            }

            _sections.Add(section);
            return true;
        }
    }
}