using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        public static List<Student> TestStudents { get; private set; } = new List<Student>();

        static StudentData()
        {
            AddStudent(firstNewStudent);
            AddStudent(secondNewStudent);
            AddStudent(thirdNewStudent);
        }


        static Student firstNewStudent = new Student
        {
            Name = "George",
            Surname = "Petrov",
            FamilyName = "Petrov",
            Faculty = "Faculty of Computer Science",
            Specialty = "Computer And Software Engineering",
            QualificationDegree = "Bachelor",
            Status = "Enrolled",
            FacultyNumber = "12122",
            Course = 3,
            Stream = 9,
            Group = 44
        };

        static Student secondNewStudent = new Student
        {
            Name = "Maria",
            Surname = "Ivanova",
            FamilyName = "Ivanova",
            Faculty = "Faculty of Computer Science",
            Specialty = "Computer And Software Engineering",
            QualificationDegree = "Bachelor",
            Status = "Enrolled",
            FacultyNumber = "12121",
            Course = 3,
            Stream = 10,
            Group = 46
        };

        static Student thirdNewStudent = new Student
        {
            Name = "Ivan",
            Surname = "Todorov",
            FamilyName = "Todorov",
            Faculty = "Faculty of Computer Science",
            Specialty = "Computer And Software Engineering",
            QualificationDegree = "Bachelor",
            Status = "Enrolled",
            FacultyNumber = "12122",
            Course = 3,
            Stream = 9,
            Group = 42
        };

        public static void AddStudent(Student student)
        {
            TestStudents.Add(student);
        }

        public static Student IsThereStudent(string facNum)
        {
            StudentInfoContext context = new StudentInfoContext();

            if (StudentData.TestStudents.All(st => st.FacultyNumber != facNum))
            {
                Console.WriteLine("error");
                return null;
            }

            Student result = (from st in context.Students
                              where st.facultyNumber == facNum
                              select st).First();

            return result;
        }
    }
}