using AutoMapper;
using GLC.Core.IUnitOfWork;
using GLC.Core.Resources;
using GLC.EF;
using Microsoft.AspNetCore.Mvc;

namespace GLC_API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentsController(IUnitOfWork unitOfWork, GLCDbContext context, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _unitOfWork.Students.GetAllAsync());
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("No Students are found!", ex);
            }
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                return Ok(await _unitOfWork.Students.GetByIdAsync(id));
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("No Student is found!", ex);
            }

        }

        [HttpGet("/name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var student = await _unitOfWork.Students.FindAsync(s => s.Name == name);

                return Ok(student);
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("No students found by this name", ex);
            }


        }



        [HttpGet("/email/{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            try
            {
                var student = await _unitOfWork.Students.FindAsync(s => s.Email == email);

                return Ok(student);
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("No students found by this email", ex);
            }


        }


        [HttpPost("{student}")]

        public async Task<IActionResult> AddStudent([FromBody] StudentResource student)
        {
            return Ok(await _unitOfWork.Students.AddAsync(student));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            try
            {
                var student = await _unitOfWork.Students.DeleteAsync(id);
                int x = await _unitOfWork.CompleteAsync();
                return Ok(student);
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("this student is not found", ex);
            }
        }


    }
}
