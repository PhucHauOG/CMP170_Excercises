using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Ex6T7
{
    class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
            public string Class { get; set; }
            public List<Result> Exam { get; set; }
        }

        public class Result
        {
            public string Subject { get; set; }
            public decimal Point { get; set; }
        }

        static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("Student_data_Handon.json");
            var students = JsonSerializer.Deserialize<List<Student>>(jsonString);
            
            var studentlist = from Student in students
                             orderby Student.FirstName ascending
                             select Student;
            Console.WriteLine("Student Info");
            foreach (var Student in studentlist) Console.WriteLine($"{Student.FirstName }  {Student.LastName} - {Student.Id}");
            Console.WriteLine("Information of student's gender/class/city");

            var gender = from Student in students
                           group Student by Student.Gender;

            foreach (var group in gender)
            {
                Console.WriteLine($"{group.Key}-{group.Count()} students");

            }
            var sclass = from Student in students
                           group Student by Student.Class;
            foreach (var group in sclass)
            {
                Console.WriteLine($"{group.Key} - {group.Count()} students");

            }

            var scity = from Student in students
                            group Student by Student.City;

            Console.WriteLine("GPA calculating");
            foreach (var ko in students)
            {
                Console.WriteLine($"{ko.FirstName} - GPA:{ko.Exam.Average(a => a.Point)}");

            }

            Console.WriteLine("List of students must repeat subject: has a subject less than 5");
            var repeat = students.Where(s => s.Exam.Any(x => x.Point < 5)).ToList();
            foreach (var fail in repeat)
            {
                Console.WriteLine($"Name: {fail.FirstName}");
                var failsubject = fail.Exam.Where(rot => rot.Point < 5).ToList();
                foreach (var subject in failsubject)
                {
                    Console.WriteLine($"- {subject.Subject}:{subject.Point} Point(s)");
                }
            }
            
            var fuse = from Student in students
                       where Student.Exam.Average(a => a.Point) > 7 && Student.Exam.Any(x => x.Point >= 5)
                       select Student;
            Console.WriteLine("good students which GPA > 7 and no subject less than 5");
            foreach (var Student in fuse)
            {
                Console.WriteLine($"{Student.FirstName }  {Student.LastName} ");
                Console.WriteLine($"GPA:{Student.Exam.Average(a => a.Point)} ");
                var subject = Student.Exam.Where(fail => fail.Point >= 5);
                foreach (var tenp in subject)
                {
                    Console.WriteLine($"- {tenp.Subject}:{tenp.Point} Point(s)");
                }
            }
        }
    }
}
