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
}
