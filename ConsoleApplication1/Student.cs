using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SchoolApp
{
    public class Student
    {
        //        Each student can have up to five subjects, with five separate teachers, 
        //        and has "20 hours of class??" and should have 8 items of information to be entered, including a Student ID

        
        private static int _studentId;

        private const int MaxClassHours = 20;
        private const int MaxSubjects = 5;
        private const int MaxTeachers = 5;

        public int StudentID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        private List<Subject> _subjects = new List<Subject>();
        private List<Teacher> _teachers = new List<Teacher>();

        public Student()
        {
        }

        public Student(string firstName, string lastName, string address, long contact, string email, string country, string gender)
        {
            StudentID = Interlocked.Increment(ref _studentId);
            FirstName = firstName;
            LastName = lastName;
            Contact = contact;
            Email = email;
            Gender = gender;
            Address = address;
            Country = country;
        }
        
        public bool AddSubject(Subject subject)
        {
            if(_subjects.Count == MaxSubjects)
            {
                return false;
            }

            _subjects.Add(subject);
            return true;
        }        

        public bool AddTeacher(Teacher teacher)
        {
            if(_teachers.Count == MaxTeachers)
            {
                return false;
            }

            _teachers.Add(teacher);
            return true;
        }
    }
}