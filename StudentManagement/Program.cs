using librarymanagementsystem.Student;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentManagement
{
    internal class Program
    {
        //        Create a main program to simulate the student management system:
        //Add students to the school.
        //Add courses to the school.
        //Enroll students in various courses.
        //Display all students and their details.
        //Display all courses and their details.
        //Utilize copy constructors to create a copy of student objects.

        //Considerations:
        //Define all the Necessary Constructors/Properties if you need it
        //Validate user inputs where necessary (e.g., ensuring unique student IDs).
        //Maintain a clean and user-friendly console interface for interacting with the student management system.

        //Bouns: 
        //add indexing to the project!

        static void Main(string[] args)
        {
            bool quit = false;
            //Id Must be unique ,assign autmatically incrementally and private
            //create copy constructor for student class
            
            

            Student student = new Student("mostafa ahmed khalaf","Bn34343");
            Student studentCopy_ = new Student(student);
            student.displayDetails();
            studentCopy_.displayDetails();
            
            School Banhassn = new School();
            while (true)
            {
            Console.WriteLine("------------Welcome,in School of BanHassan------------");
                Console.WriteLine("1- Add students to the school.");
                Console.WriteLine("2- Add courses to the school.");
                Console.WriteLine("3- Enroll students in various courses.");
                Console.WriteLine("4- Display all students and their details.");
                Console.WriteLine("5- Display all courses and their details.");
                Console.WriteLine($"6- Quit");
                int choic = Convert.ToInt32(Console.ReadLine());
                switch (choic)
                {
                    case 1:
                        Console.Write("Enter the Student Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter the Student Id: ");
                        string id = Console.ReadLine();
                        Banhassn.AddStudent(new Student(name,id));
                        break;
                    case 2:
                        Console.Write($"Enter the Couses Name: ");
                        string courseName = Console.ReadLine();
                        Console.Write("Enter the Instractor Name: ");
                        string instractorName = Console.ReadLine();
                        Banhassn.AddCourse(new Course(courseName, instractorName));
                        break;
                    case 3:
                        Console.Write("Enter the Student ID: ");
                        string studentID = Console.ReadLine();
                        Console.Write("Enter the Course Name: ");
                        string courseNameEnroll = Console.ReadLine();
                        Banhassn.EnrollStudentInCourse(studentID, courseNameEnroll);
                        break;
                    case 4:
                        Banhassn.DisplayAllStudents();
                        break;
                    case 5:
                        Banhassn.DisplayAllCourses();
                        break;
                    case 6:
                        quit = true;
                        break;
                }
                if (quit)
                {
                    break;
                }

            }
        }
    }
}
