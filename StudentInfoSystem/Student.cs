using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FamilyName { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public string QualificationDegree { get; set; }
        public string Status { get; set; }
        public string FacultyNumber { get; set; }
        public int Course { get; set; }
        public int Stream { get; set; }
        public int Group { get; set; }
        public int StudentId { get; set; }

        public Student() { }

        public Student(string name, string surname, string familyname, string faculty, string specialty, string qualificationDegree, string statusOfStudying, string facultyNumber, int course, int potok, int group, int studentId)
        {
            this.Name = name;
            this.Surname = surname;
            this.FamilyName = familyname;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.QualificationDegree = qualificationDegree;
            this.Status = statusOfStudying;
            this.FacultyNumber = facultyNumber;
            this.Course = course;
            this.Stream = potok;
            this.Group = group;
            StudentId = studentId;
        }  
    }
}
