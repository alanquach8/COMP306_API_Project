using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MicroprocessorStoreClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MicroprocessorStoreClient.Controllers
{
    public class MicroprocessorStoreController : Controller
    {
        public static string baseUrl = "https://localhost:44369/"; // CHANGE

        public async Task<IActionResult> StoresAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            IEnumerable<Store> stores = new List<Store>();
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetStores");
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    stores = JsonConvert.DeserializeObject<IEnumerable<Store>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return View(stores);
        }

        public async Task<IActionResult> MicroprocessorsAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            IEnumerable<Microprocessor> microprocessors = new List<Microprocessor>();
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetMicroprocessors");
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    microprocessors = JsonConvert.DeserializeObject<IEnumerable<Microprocessor>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return View(microprocessors);
        }
    }
}
