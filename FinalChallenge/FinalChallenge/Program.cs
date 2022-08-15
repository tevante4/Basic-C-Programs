using System;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;


namespace FinalChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var ctx = new StudentContext())
            {
                var student = new Student() { FirstName = "Tevante", LastName = "Swanston" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}