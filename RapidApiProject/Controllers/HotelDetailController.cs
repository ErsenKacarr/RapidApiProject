using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiProject.Models;

namespace RapidApiProject.Controllers
{
    public class HotelDetailController : Controller
    {
        public async Task<IActionResult> Index(string hotelID, string arrivalDate, string departureDate)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelDetails?hotel_id={hotelID}&arrival_date={arrivalDate}&departure_date={departureDate}&languagecode=en-us&currency_code=EUR"),
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
                var value = JsonConvert.DeserializeObject<HotelDetailViewModel>(body);
                return View(value);
            }
        }
    }
}
