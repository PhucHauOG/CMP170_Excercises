using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01
{
    class Student
    {
        private string studentID;
        private string fullname;
        private float averageScore;
        private string faculty;
        
        public string StudentID { get; set; }
        public string Fullname { get; set; }
        public float AverageScore { get; set; }
        public string Faculty { get; set; }
        public Student() { }
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            Fullname = name;
            AverageScore = score;
            Faculty = faculty;
        }
        public void Input() 
        {
            Console.Write("Input student ID: ");
            StudentID = Console.ReadLine();
            Console.Write("Input student name: ");
            Fullname = Console.ReadLine();
            Console.Write("Input average score: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Input faculty: ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine($"StudentID:{StudentID} Full_Name:{Fullname} Faculty:{Faculty} Average_Score:{AverageScore}\n", this.StudentID, this.fullname, this.Faculty, this.AverageScore);
        }

        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            /*Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Input total student N =");
            int N = Convert.ToInt32(Console.ReadLine());
            Student[] arrStudents = new Student[N];
            Console.WriteLine("\n ====Input student list====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Input student number {0}", i + 1);
                arrStudents[i] = new Student();
                arrStudents[i].Input();
            }
            Console.WriteLine("\n ====Output student list====");*/
            List<Student> students = new List<Student>();
            students.Add(new Student("001", "Nguyen Van A", 6, "NNA"));
            students.Add(new Student("002", "Nguyen Van B", 9, "CNTT"));
            students.Add(new Student("003", "Nguyen Van C", 7, "CNOT"));
            students.Add(new Student("004", "Nguyen Van D", 10, "CNTT"));
            students.Add(new Student("005", "Nguyen Van E", 4, "CNTP"));
            students.Add(new Student("006", "Nguyen Van F", 5, "NHKS"));
            students.Add(new Student("007", "Nguyen Van G", 8, "QTKD"));
            students.Add(new Student("008", "Nguyen Van H", 9, "CNTT"));
            Console.WriteLine("Q1: ");
            var cau1 = students.FindAll(x => x.Faculty == "CNTT");
            foreach (var item in cau1) 
            {
                item.Show();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Q2: ");
            var cau2 = students.FindAll(x => x.AverageScore >= 5);
            foreach (var item in cau2)
            {
                item.Show();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Q3: ");
            var cau3 = students.OrderBy(x => x.AverageScore).ToList();
            foreach (var item in cau3)
            {
                item.Show();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Q4");
            var cau4 = students.FindAll(x => x.AverageScore >= 5 && x.Faculty == "CNTT");
            foreach (var item in cau4)
            {
                item.Show();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Q5: ");
            var max = students.Max(x => x.AverageScore);
            var cau5 = students.FindAll(x => x.Faculty == "CNTT" && x.AverageScore == max);
            foreach (var item in cau5)
            {
                item.Show();
            }
            Console.ReadKey();
            
    }
    }
}
