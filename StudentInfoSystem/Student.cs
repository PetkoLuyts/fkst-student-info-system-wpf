using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string familyname { get; set; }
        public string faculty { get; set; }
        public string specialty { get; set; }
        public string qualificationDegree { get; set; }
        public string statusOfStudying { get; set; }
        public string facultyNumber { get; set; }
        public int course { get; set; }
        public int potok { get; set; }
        public int group { get; set; }
        public int StudentId { get; set; }


        public Student() { }
        public Student(string name, string surname, string familyname, string faculty, string specialty, string qualificationDegree, string statusOfStudying, string facultyNumber, int course, int potok, int group, int studentId)
        {
            this.name = name;
            this.surname = surname;
            this.familyname = familyname;
            this.faculty = faculty;
            this.specialty = specialty;
            this.qualificationDegree = qualificationDegree;
            this.statusOfStudying = statusOfStudying;
            this.facultyNumber = facultyNumber;
            this.course = course;
            this.potok = potok;
            this.group = group;
            StudentId = studentId;
        }
        
    }
}
