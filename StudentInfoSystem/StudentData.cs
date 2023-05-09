using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        public static List<Student> TestStudents { get; private set; } = new List<Student>();

        // a static constructor runs at the beggining of the program
        static StudentData()
        {
            //TestStudents = new List<Student>();
            AddStudent(newStudent);
            AddStudent(newStudent1);
            AddStudent(newStudent2);
            /*
                StudentData data = new StudentData();
                Student student = new Student();
                student.name = "John";
                student.surname = "John";
                // set other properties
                data.AddStudent(student);
            */
        }


        // Create a new student object for the example
        static Student newStudent = new Student
        {
            name = "John",
            surname = "John",
            familyname = "John",
            faculty = "Faculty of Computer Science",
            specialty = "Computer Science",
            qualificationDegree = "Bachelor",
            statusOfStudying = "Enrolled",
            facultyNumber = "12345",
            course = 2,
            potok = 10,
            group = 43
        };

        static Student newStudent1 = new Student
        {
            name = "John",
            surname = "John",
            familyname = "John",
            faculty = "Faculty of Computer Science",
            specialty = "Computer Science",
            qualificationDegree = "Bachelor",
            statusOfStudying = "Enrolled",
            facultyNumber = "1234",
            course = 2,
            potok = 10,
            group = 43
        };

        static Student newStudent2 = new Student
        {
            name = "John",
            surname = "John",
            familyname = "John",
            faculty = "Faculty of Computer Science",
            specialty = "Computer Science",
            qualificationDegree = "Bachelor",
            statusOfStudying = "Enrolled",
            facultyNumber = "123",
            course = 2,
            potok = 10,
            group = 43
        };

        public static void AddStudent(Student student)
        {
            TestStudents.Add(student);
        }

        public static Student IsThereStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();
            Student result = (from st in context.Students
                              where st.facultyNumber == facNum
                              select st).First();
            if (result == null)
            {
                Console.WriteLine("error");
            }
            return result;
        }

    }
}
