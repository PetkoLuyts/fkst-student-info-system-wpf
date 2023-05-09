using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (user.number == null)
            {
                Console.WriteLine("No Faculty number");

                return null;
            }

            Student student = new Student();
            student = StudentData.TestStudents
                .FirstOrDefault(s => s.FacultyNumber == user.number);

            if(student == null)
            {
                Console.WriteLine("No student with this Faculty number found");

                return null;
            }

            return student;
        }
    }
}