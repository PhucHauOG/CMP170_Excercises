using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IStudentServive
    {
        IList<Student> SearchStudent(string keyword, string hutechClass);

        Student LoadStudentById(long id);

        void UpdateOrCreateStudent(Student student);

        void DeleteStudentById(int id);
    }

    public class StudentServiceWithFile : IStudentServive
    {
        private IList<Student> m_students;

        public StudentServiceWithFile()
        {
            var data = File.ReadAllText("Student_Data.json");
            m_students = JsonConvert.DeserializeObject<List<Student>>(data);
        }
        public void DeleteStudentById(int id)
        {
            var deleteStudent = LoadStudentById(id);
            if(deleteStudent != null)
            {
                m_students.Remove(deleteStudent);
            }
        }

        public Student LoadStudentById(long id)
        {
            return m_students.FirstOrDefault(x => x.StudentId == id);
        }

        public IList<Student> SearchStudent(string keyword, string hutechClass)
        {
            return m_students;
        }

        public void UpdateOrCreateStudent(Student student)
        {
            if(student.StudentId > 0)
            {
                var updateStudent = LoadStudentById(student.StudentId);
                updateStudent.LastName = student.LastName;
            }
            else
            {
                var newStudentId = m_students.Select(s => s.StudentId).OrderByDescending(s => s).FirstOrDefault();
                student.StudentId = newStudentId + 1;
                m_students.Add(student);
            }
        }
    }
    
}
