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
        //DbSet е колекция.Колекцията е от ентити класове(множество обекти от
        //посочените класове Student и User), затова на свойствата от този тип даваме имена в
        //множествено число(Students и Users)
        //DbSet наследява IEnumerable.
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Grade> Grades { get; set; }

        // the base can take in connection to the DB
        //Ако не подадем параметър EF ще създаде нова база на локалния сървър вграден във 
        //Visual Studio.Посочвайки известна база на самостоятелен SQL Server, ще може да следим какво се случва в нея.
        public StudentInfoContext() : base(Properties.Settings.Default.DbConnect)
        {
            {
                bool TestStudentsIfEmpty()
                {
                    using (var context = new StudentInfoContext())
                    {
                        var queryStudents = context.Students;
                        int countStudents = queryStudents.Count();

                        if (countStudents == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
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
