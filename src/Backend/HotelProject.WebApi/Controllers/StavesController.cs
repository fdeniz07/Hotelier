using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    using BusinessLayer.Abstracts;
    using EntityLayer.Concretes;

    [Route("api/[controller]")]
    [ApiController]
    public class StavesController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StavesController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetById(id);
            _staffService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffById(int id)
        {
            var values = _staffService.TGetById(id);
            return Ok(values);
        }
    }
}
