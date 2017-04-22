using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApp
{
    public class Section
    {
        // A section is defined as a specific instance of a subject with a teacher, classroom, and a maximum of 40 students.

        private const int MaxStudents = 40;

        public Subject _subject { get; set; }
        private Teacher _teacher { get; set; }
        private Classroom _classroom { get; set; }

        private List<Student> _students = new List<Student>();


        public Section()
        {
        }

        public Section(Subject subject, Teacher teacher, Classroom classroom)
        {
            _subject = subject;
            _teacher = teacher;
            _classroom = classroom;
        }

        public bool AddStudent(Student student)
        {
            if (_students.Count == MaxStudents)
            {
                return false;
            }

            _students.Add(student);
            return true;
        }

        public bool AddStudents(List<Student> students)
        {
            if(_students.Count == MaxStudents || (_students.Count + students.Count) > MaxStudents)
            {
                return false;
            }

            _students.AddRange(students);
            return true;
        }
    }
}