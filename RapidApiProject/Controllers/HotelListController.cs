using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;

namespace RapidApiProject.Controllers
{
    public class HotelListController : Controller
    {
        public async Task<IActionResult> Index(HotelSearchViewModel model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={model.dest_id}&search_type=CITY&arrival_date={model.checkinDate.ToString("yyyy-MM-dd")}&departure_date={model.checkoutDate.ToString("yyyy-MM-dd")}&adults=1&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=EUR"),
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
                var values = JsonConvert.DeserializeObject<HotelListViewModel>(body);
                TempData["Photo"] = values.data.hotels[0].property.photoUrls[0].Replace("square60", "square480");
                return View(values.data.hotels.ToList());
            }
        }
    }
}
