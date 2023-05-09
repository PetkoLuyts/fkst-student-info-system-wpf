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
            // Ако в подадения обект от тип User не е посочен факултетен номер или не е 
            // открит студент по попълненият факултетен номер, да уведомява по някакъв
            // начин извиквашият функцията.
            if(user.number == null)
            {
                Console.WriteLine("No faculty number");
                return null;
            }

            Student student = new Student();
            student = StudentData.TestStudents.FirstOrDefault(s => s.facultyNumber == user.number);

            if(student == null)
            {
                // think of another way to notify the one calling this method
                Console.WriteLine("No student with this faculty number found");
                return null;
            }

            return student;

        }


    }
}
