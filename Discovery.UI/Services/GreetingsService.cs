using System.Net.Http;
using System.Threading.Tasks;

namespace Discovery.UI.Services 
{
    public class GreetingsService : IGreetingsService
    {
        private readonly HttpClient _httpClient;

        public GreetingsService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<string> GetGreetingsMessage()
        {
            return await _httpClient.GetStringAsync("api/greetings");
        }
    }
}
