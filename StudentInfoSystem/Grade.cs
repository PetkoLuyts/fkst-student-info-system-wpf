using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace StudentInfoSystem
{
    public class Grade
    {
        public int GradeId { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int Value { get; set; }

        public string Subject { get; set; }

        // opening a connection to the DB to add an object of type Grade
        public static void AddGradeToDatabase(int studentId, int value, string subject)
        {
            using (var context = new StudentInfoContext())
            {

                Student student = context.Students.FirstOrDefault(s => s.StudentId == studentId);
                if (student == null)
                {
                    MessageBox.Show("Студентът не е намерен.");
                    return;
                }


                var grade = new Grade
                {
                    StudentId = studentId,
                    Subject = subject,
                    Value = value
                };
                context.Grades.Add(grade);
                context.SaveChanges();
            }
        }


    }
}
