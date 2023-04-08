using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddRoom()
        {
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
        public IActionResult GetRoomById()
        {
            return Ok();
        }
    }
}
