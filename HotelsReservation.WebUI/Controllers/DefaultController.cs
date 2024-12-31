using HotelsReservation.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace HotelsReservation.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly string _apiKey = "29810ee6aamsh28a42ebad6975e1p1ce7ebjsn835bad515f4a";
        private readonly string _apiHost = "booking-com15.p.rapidapi.com";
        private readonly HttpClient _httpClient;

        public DefaultController()
        {
            _httpClient = new HttpClient();
        }

        public IActionResult Index() => View();

        public IActionResult HotelList() => View();

        [HttpPost]
        public async Task<IActionResult> HotelList(string city, string arrival_date, string departure_date, string adults)
        {
            try
            {
                var destinations = await GetHotelDestinations(city.ToLower());
                var selectedDestination = GetRandomDestination(destinations);
                var hotels = await SearchHotels(selectedDestination, arrival_date, departure_date, adults);
                return View(hotels);
            }
            catch (Exception ex)
            {
                // Log error
                return View("Error");
            }
        }

        private DestinationModel.Destination GetRandomDestination(List<DestinationModel.Destination> destinations)
        {
            var random = new Random();
            var randomIndex = random.Next(0, destinations.Count);
            return destinations[randomIndex];
        }

        private async Task<HotelsViewModel.Data> SearchHotels(DestinationModel.Destination destination, string arrivalDate, string departureDate, string adults)
        {
            var request = CreateApiRequest(
                $"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id={destination.dest_id}" +
                $"&search_type={destination.search_type}&arrival_date={arrivalDate}&departure_date={departureDate}" +
                $"&adults={adults}&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c" +
                $"&languagecode=en-us&currency_code=USD"
            );

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<HotelsViewModel>(content);
            return result.data;
        }

        [HttpGet]
        public async Task<List<DestinationModel.Destination>> GetHotelDestinations(string query)
        {
            var request = CreateApiRequest(
                $"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={query}"
            );

            using var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<DestinationModel>(content);
            return result.data;
        }

        private HttpRequestMessage CreateApiRequest(string uri)
        {
            return new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(uri),
                Headers =
                {
                    { "x-rapidapi-key", _apiKey },
                    { "x-rapidapi-host", _apiHost },
                }
            };
        }
    }
}
