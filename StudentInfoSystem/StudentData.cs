using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    static class StudentData
    {
        public static List<Student> TestStudents
        {
            get
            {
                Student student = new Student();
                student.FirstName = "Petko";
                student.MiddleName = "Delyanov";
                student.LastName = "Lyutskanov";
                student.Faculty = "FCST";
                student.Speciality = "CSE";
                student.Degree = "bachelor";
                student.Status = "paid";
                student.FacultyNumber = "121220186";
                student.Course = 3;
                student.Stream = 10;
                student.GroupNumber = 44;

                return new List<Student>() { student };
            }
            private set { }
        }
    }
}
