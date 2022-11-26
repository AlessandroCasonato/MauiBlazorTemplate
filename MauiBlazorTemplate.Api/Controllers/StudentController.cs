using MauiBlazorTemplate.Core.Models;
using MauiBlazorTemplate.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MauiBlazorTemplate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static ISqliteService<Student> _dbService;
        public StudentController(ISqliteService<Student> dbService) 
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _dbService.GetAllStudent();
        }

        [HttpGet("{id}")]
        public async Task<Student> GetById(int id)
        {
            return await _dbService.GetStudentById(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<int> Post([FromBody] Student student)
        {
            return await _dbService.AddStudent(student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<int> Put(int id, [FromBody] Student student)
        {
            return await _dbService.UpdateStudent(student);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(Student student)
        {
            return await _dbService.DeleteStudent(student);
        }
    }
}
