using System;
using FinalAssignment2.Data;
using FinalAssignment2.Models;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new ApplicationDbContext())
        {
            // Ensure database is created
            context.Database.EnsureCreated();

            // Create a new student
            var student = new Student { Name = "John Doe" };
            context.Students.Add(student);
            context.SaveChanges();

            // Retrieve and display the student
            var savedStudent = context.Students.Find(student.Id);
            Console.WriteLine($"Student ID: {savedStudent.Id}, Name: {savedStudent.Name}");
        }
    }
}
