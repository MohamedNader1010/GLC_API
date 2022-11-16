using GLC.Core.IUnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace GLC_API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentsController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _unitOfWork.Students.GetByIdAsync(id));
        }
    }
}
