using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentInfoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public StudentInfoContext() : base(Properties.Settings.Default.DbConnect)
        {
            {
                bool TestStudentsIfEmpty()
                {
                    using (var context = new StudentInfoContext())
                    {
                        var queryStudents = context.Students;
                        int countStudents = queryStudents.Count();

                        if (countStudents == 0) return true;
                        else return false;  
                    }
                }

                void CopyTestStudents()
                {
                    using (var context = new StudentInfoContext())
                    {
                        foreach (Student st in StudentData.TestStudents)
                        {
                            context.Students.Add(st);
                        }

                        context.SaveChanges();
                    }
                }            
            }
        }
    }
}