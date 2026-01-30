using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace librarymanagementsystem.Student
{
//    Attributes:
//List of students(Collection of Student objects)
//List of courses(Collection of Course objects)
//Methods:
//AddStudent(Student student) to add a new student to the school
//AddCourse(Course course) to add a new course to the school
//EnrollStudentInCourse(int studentID, string courseName) to enroll a student in a course
//DisplayAllStudents() to display details of all students in the school
//DisplayAllCourses() to display details of all courses in the school

    internal class School
    {
        List<Student> students=new List<Student>();
        List<Course> Couses_=new List<Course>();
        public void AddStudent(Student student)
        {
            //var studentExists = students.Exists(s => s.ID == student.ID);
            var studentExists = students.Exists(s => s.Name == student.Name);
            if (studentExists)
            {
                Console.WriteLine($"this Student is Already in School..");
            }
            else
            {
                students.Add(student);
                Console.WriteLine("Student is accept in School..");
            }
            //studentExists=false;
        }
        public void AddCourse(Course course)
        {
            var courseExists = Couses_.Exists(c => c.NameCourse == course.NameCourse);
            if (courseExists)
            {
                Console.WriteLine($"is Added already");

            }
            else
            {
                Couses_.Add(course);
                Console.WriteLine("New Course is added in School..");
            }
            //courseExists= false;
        }
        public void EnrollStudentInCourse(string studentID, string courseName)
        {
            //Student studentEn = new Student();
            bool find = false;
            foreach (var student in students)
            {
                if (student.ID == studentID)
                {
                    find=true;
                    if (Couses_.Exists(c => c.NameCourse == courseName))
                    {
                        student.enrollCourse(courseName);
                       // Console.WriteLine($"Student Name: {student.Name} is enrolled in course: {courseName}");
                        break;
                    }
                    else {
                        Console.WriteLine("this Course is not Exist in School..");
                    }
                }
                
            }
            if (!find)
            {
                Console.WriteLine($"Student ID {studentID} not found.");
            }

            //var student=students.Find(s=>s.ID==studentID);
            //Student student = students.Find(s => s.ID == studentID);
            //if (student!=null)
            //{
            //    student.enrollCourse(courseName);
            //    Console.WriteLine($"Student ID {studentID} is enrolled in course {courseName}");
            //}
            //else
            //{
            //    Console.WriteLine($"Student ID {studentID} not found.");
            //}

        }
        public void DisplayAllStudents()
        {
            Console.WriteLine("All Students in School:");
            foreach(var student in students)
            {
                student.displayDetails();
                Console.WriteLine("-------------------");
            }
        }
        public void DisplayAllCourses()
        {
            Console.WriteLine("All Courses in School:");
            foreach(var course in Couses_)
            {
                course.DisplayDetails();
                Console.WriteLine("-------------------");
            }
        }
    }
}
