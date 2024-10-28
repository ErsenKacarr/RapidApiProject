using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;

namespace RapidApiProject.Controllers
{
    public class HotelSearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(HotelSearchViewModel model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={model.city_name}"),
                Headers =
    {
        { "x-rapidapi-key", "e39e0ce586msh0fb7b2f29f24fe1p1134dfjsn5094ae8fdc5c" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<CityLocationIdViewModel>(body);
                var cityId = values.data[0].dest_id;
                var getSearch = new HotelSearchViewModel
                {
                    dest_id = cityId,
                    city_name = model.city_name,
                    checkinDate = model.checkinDate,
                    checkoutDate = model.checkoutDate,
                    //adultCount = model.adultCount,
                    //roomCount = model.roomCount
                };
                return RedirectToAction("HotelList","Index", getSearch);
            }
        }
    }
}
