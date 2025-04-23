using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using TraversalCoreProject.Areas.Admin.Models;
using System.Linq;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-1456928&search_type=CITY&arrival_date=2025-04-25&departure_date=2025-04-27&adults=1&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c"),
                Headers =
    {
        { "x-rapidapi-key", "5433022e01msh44182a4d5dadb20p197a93jsnd7d9420a6d44" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //var bodyReplace = body.Replace(".", "");
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
                var properties = values.data.hotels.Select(h => h.property).ToList(); // Property1'lerin listesi
                return View(properties);
            }
        }

        [HttpGet]
        public IActionResult GetCityDestID()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCityDestID(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={p}"),
                Headers =
    {
        { "X-RapidAPI-Key", "cb5ee15da1mshb46d59d679af3abp1fe84cjsn167590fdc0cc" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }
    }
}

