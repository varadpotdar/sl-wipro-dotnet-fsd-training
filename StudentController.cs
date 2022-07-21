using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Data.Services;
using SchoolManagement.Data.ViewModels;

namespace SchoolManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentsService _studentsService;

        public StudentController(StudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet("get-all-students")]
        public IActionResult GetAllStudents()
        {
            var allStudents = _studentsService.GetStudents();
            return Ok(allStudents);
        }

        [HttpGet("get-students-by-id/{id}")]
        public IActionResult GetStudentsById(int id)
        {
            var Students = _studentsService.GetStudentsById(id);
            return Ok(Students);
        }

        [HttpPost("add-student")]

       public IActionResult AddStudent([FromBody] StudentsVM student)
        {
            _studentsService.AddStudent(student);
            return Ok();
        }

        [HttpPut("update-student-by-id/{id}")]
        public IActionResult UpdateStudentById(int id, [FromBody] StudentsVM students)
        {
            var UpdateStudent = _studentsService.UpdateStudentById(id, students);
            return Ok(UpdateStudent);
        }

        [HttpDelete("delete-by-id/{id}")]
        public IActionResult DeleteStudentById(int id)
        {
            _studentsService.DeleteStudentById(id);
            return Ok();
        }


    }
}
