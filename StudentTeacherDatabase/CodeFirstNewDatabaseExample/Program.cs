using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace StudentTeacherDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (var db = new SchoolContext())
            {
                var stud = new Student() { FirstName = "William", LastName = "Darcy" };

                db.Students.Add(stud);
                db.SaveChanges();

            }
        }

        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Course Course { get; set; }
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string TeacherName { get; set; }

            public List<Student> Students { get; set; }
        }

        public class SchoolContext : DbContext
        {
            public SchoolContext() : base()
            {

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }
        }
    }
}
