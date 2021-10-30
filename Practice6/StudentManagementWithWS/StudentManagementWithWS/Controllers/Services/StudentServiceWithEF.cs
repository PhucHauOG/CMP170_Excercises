using StudentManagementWithWS.Controllers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class StudentServiceWithEF : IStudentServive
    {
        public StudentServiceWithEF()
        {
            using (var ctx = new UniversityContext())
            {
                ctx.Database.EnsureCreated();
            }
        }

        public void DeleteStudentById(int id)
        {
            using (var ctx = new UniversityContext())
            {
                var deletedStudent = ctx.Students.Find(id);
                ctx.Students.Remove(deletedStudent);
                ctx.SaveChanges();
            }
        }

        public Student LoadStudentById(int id)
        {
            using (var ctx = new UniversityContext())
            {
                return ctx.Students.Find(id);
            }
        }

        public IList<Student> SearchStudent(string keyword, string hutechClass)
        {
            using (var ctx = new UniversityContext())
            {
                var result = ctx.Students.Where(s => (s.Class == hutechClass || string.IsNullOrEmpty(hutechClass)) && (s.FirstName == keyword || string.IsNullOrEmpty(keyword)))
                                    .OrderBy(s => s.StudentId).ToList();
                return result;
            }
        }

        public void UpdateOrCreateStudent(Student student)
        {
            using (var ctx = new UniversityContext())
            {
                if (student.StudentId > 0)
                {
                    var dbStudent = ctx.Students.Find(student.StudentId);
                    dbStudent.FirstName = student.FirstName;
                    dbStudent.LastName = student.LastName;
                    dbStudent.Class = student.Class;
                    dbStudent.Email = student.Email;
                    dbStudent.Gender = student.Gender;
                    dbStudent.Gpa = student.Gpa;
                }
                else
                {
                    ctx.Students.Add(student);
                }
                ctx.SaveChanges();
            }
        }
    }
}