using Exercise1;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using StudentManagementWithWS.Controllers.Model;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace StudentManagementWithWS 
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServive m_studentServive;
        public StudentController(IStudentServive studentServive)
        {
            m_studentServive = studentServive;
        }

        [HttpGet]
        public IActionResult SearchStudent(string keyword, string hutechClass)
        {
            return Ok(m_studentServive.SearchStudent(keyword, hutechClass));
        }

        [HttpGet("{id}")]
        public IActionResult LoadStudentById(int id)
        {
            return Ok(m_studentServive.LoadStudentById(id));
        }

        [HttpPost]
        public IActionResult UpdateOrCreateStudent(Student student)
        {
            m_studentServive.UpdateOrCreateStudent(student);
            return Ok();
        }
    }
}
