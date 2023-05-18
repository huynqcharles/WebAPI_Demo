using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Demo.Data;
using WebAPI_Demo.IServices;
using WebAPI_Demo.Models;

namespace WebAPI_Demo.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentServices _studentServices;
        public StudentsController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public async Task<ActionResult<Student>> GetStudents()
        {
            var students = await _studentServices.GetStudents();
            return Ok(students);
        }
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            await _studentServices.PostStudent(student);
            return Ok();
        }
    }
}
