using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace librarymanagementsystem.Student
{
//    Course
//Attributes:
//Name
//Instructor
//Methods:
//DisplayDetails() to show course details(Course name, Instructor)


    internal class Course
    {
        public Course(string nameCourse, string instructor)
        {
            NameCourse = nameCourse;
            Instructor = instructor;
        }

        public string NameCourse { get; set; }
        public string Instructor { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"Enroll Courses name :{NameCourse}");
            Console.WriteLine($"Instructor Name is :{Instructor}");
        }
    }
}
