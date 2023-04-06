using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            Student student = StudentData.TestStudents.FirstOrDefault(s => s.FacultyNumber == user.facultyNumber);

            if (student == null)
            {
                Console.WriteLine("No student found based on the faculty number of the user");
            }

            return student;
        }
    }
}
