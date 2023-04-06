using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    using BusinessLayer.Abstracts;

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
        public IActionResult AddRoom()
        {
            //var value = _staffService.TInsert();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok();
        }
    }
}
