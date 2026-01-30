using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace librarymanagementsystem.Student
{
//    Attributes:
//Name
//ID
//List of courses enrolled(as strings)
//Methods:
//EnrollCourse(string courseName) to enroll a student in a course
//DisplayDetails() to show student details(Name, ID, courses)
//Copy Constructor to create a copy of a student object With empty List of courses

    internal class Student
    {

       
        public  string ID { get;   set; }
        public string Name { get; set; }
        List<string> courses=new List<string>();
        public Student()
        {
            
        }
        public Student(string name,string id) {
            Name = name;
            ID =id;  
        }
        public Student(Student student) { 
            Name=student.Name;
            ID =student.ID;
        }
        public void enrollCourse(string courseName)
        {
            if (courses.Contains(courseName))
            {
                Console.WriteLine($"Student is Enrolled Already");
            }
            else
            {
                //Console.WriteLine($"course Enrolled Successfully");
                courses.Add(courseName);
                Console.WriteLine($"Student Name: {Name} is enrolled in course: {courseName}");
            }
        }
        public void displayDetails()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student ID: {ID}");
            Console.Write("Enrolled Courses:");
            foreach(var course in courses)
            {
                Console.Write($" {course} ");
            }
            Console.WriteLine();
        }

    }
}
