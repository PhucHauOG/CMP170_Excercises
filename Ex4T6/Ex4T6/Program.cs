using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using static Ex4T6.Program.IComparable;
using static Ex4T6.Program.IComparer;

namespace Ex4T6
{
    class Program
    {
        public class IComparable
        {
            public class Student : IComparable<Student>
            {
                public string StudentID { get; set; }
                public string FullName { get; set; }
                public Student() { }
                public Student(string id, string name)
                {
                    StudentID = id;
                    FullName = name;
                }
                public int CompareTo(Student other)
                {
                    return this.StudentID.CompareTo(other.StudentID);
                }
            }
        }
        public class IComparer
        {
            public class SortPersonByName : IComparer<Student>
            {
                public int Compare([AllowNull] Student x, [AllowNull] Student y)
                {
                    return x.FullName.CompareTo(y.FullName);
                }
            }
        }
        public class main
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;
                List<Student> ListStudents = new List<Student>();
                ListStudents.Add(new Student("001", "Alex"));
                ListStudents.Add(new Student("002", "Schwarz"));
                ListStudents.Add(new Student("003", "Red"));
                ListStudents.Add(new Student("004", "Amiya"));
                ListStudents.Add(new Student("005", "Texas"));
                ListStudents.Add(new Student("006", "Surtr"));
                ListStudents.Add(new Student("007", "Saga"));
                ListStudents.Add(new Student("008", "Hellagur"));

                ListStudents.Sort();
                Console.WriteLine("Using IComparable");
                foreach (Student student in ListStudents)
                {
                    Console.WriteLine("Name: {0}, ID: {1}", student.FullName, student.StudentID);
                }
                Console.WriteLine("");
                Console.WriteLine("Using IComparer");
                ListStudents.Sort(new SortPersonByName());
                foreach (Student student in ListStudents)
                {
                    Console.WriteLine("Name: {0}, ID: {1}", student.FullName, student.StudentID);
                }
            }
        }
    }
}