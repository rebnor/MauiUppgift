using MauiUppgift.Models.SunModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiUppgift.Services
{
    public class SunService
    {
        HttpClient httpClient;
        Sun sun;
        public SunService()
        {
            httpClient = new HttpClient();
        }

        public async Task<Sun> GetSunAsync()
        {
            var url = "https://api.sunrise-sunset.org/json?lat=59.329380&lng=18.068710&date=today";
            var urlResponse = await httpClient.GetAsync(url);
            if (urlResponse.IsSuccessStatusCode)
            {
                sun = await urlResponse.Content.ReadFromJsonAsync<Sun>();
            }
            return sun;
        }
    }
}
