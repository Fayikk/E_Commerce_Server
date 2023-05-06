using E_Commerce_Client.Service.IService;
using E_Commerce_Models;
using System.Net.Http.Json;

namespace E_Commerce_Client.Service
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient _client;
        public DiscountService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ServiceResponse<DiscountDTO>> GetImplementCode(string code)
        {
            var result = await _client.GetFromJsonAsync<ServiceResponse<DiscountDTO>>($"api/discount/{code}");
            return result;
        }
    }
}
