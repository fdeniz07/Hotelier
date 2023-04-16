using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    using System.Text;
    using Models.Staff;
    using Newtonsoft.Json;

    public class StavesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StavesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

     
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7047/api/Staves"); //API kisminda arka planda yapilan(swagger) sorgu buraya yazilir.
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values =
                    JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData); //List'in icerisinde bir model dönülmesi gerekiyor. Bunun icin bir model olusturuyoruz.
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(AddStaffViewModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7047/api/Staves", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
