using Microsoft.AspNetCore.Mvc;
using Tutorial6.Services;

namespace Tutorial6.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private IStudentsSerivceDb _dbService;

        public StudentsController(IStudentsSerivceDb db)
        {
            _dbService = db;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("entries/{id}")]
        public IActionResult GetSemester(string id)
        {
            var resp = _dbService.GetSemester(id);
            if (resp != null)
            {
                return Ok(resp);
            }
            else return NotFound("Record has not been found");
        }
    }
}
