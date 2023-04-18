using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    using BusinessLayer.Abstracts;
    using EntityLayer.Concretes;

    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribesController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetById(id);
            _subscribeService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribeById(int id)
        {
            var values = _subscribeService.TGetById(id);
            return Ok(values);
        }
    }
}
