using MauiUppgift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiUppgift.Services
{
    public class DogService
    {
        HttpClient httpClient;

        public DogService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("x-api-key", "7rAB/MwHvlzSSB1XvJDB8w==C50XeSWGSHkoa9ys");
        }

        public async Task<Dog> GetDogAsync(string input)
        {
            string? url = $"https://api.api-ninjas.com/v1/dogs?name={input.ToLower()}";
            var urlResponse = await httpClient.GetAsync(url);
            if (urlResponse.IsSuccessStatusCode)
            {
                var jsonString = await urlResponse.Content.ReadAsStringAsync();
                var dogs = await urlResponse.Content.ReadFromJsonAsync<List<Dog>>();
                if (dogs != null && dogs.Count > 0)
                {
                    return dogs[0];
                }
            }
            return null;
        }
    }
}
