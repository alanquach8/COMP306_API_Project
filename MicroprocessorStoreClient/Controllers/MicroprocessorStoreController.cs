using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MicroprocessorStoreClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MicroprocessorStoreClient.Controllers
{
    public class MicroprocessorStoreController : Controller
    {
        //public static string baseUrl = "https://localhost:44369/";
        public static string baseUrl = "http://microprocessorstoreapiproject-test.us-east-2.elasticbeanstalk.com/";

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

        public async Task<IActionResult> AvailabilitiesForStore(int id, bool success = false)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Store store = new Store();
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetStoreAvailabilities/" + id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    store = JsonConvert.DeserializeObject<Store>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(success)
            {
                ViewBag.Message = "Successfully updated availability";
            }

            return View(store);
        }

        public async Task<IActionResult> AvailabilitiesForMicroprocessor(int id, bool success = false)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Microprocessor microprocessor = new Microprocessor();
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetMicroprocessorAvailabilities/" + id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    microprocessor = JsonConvert.DeserializeObject<Microprocessor>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (success)
            {
                ViewBag.Message = "Successfully updated availability";
            }

            return View(microprocessor);
        }

        public async Task<IActionResult> UpdateStoreAsync(int id, bool success = false)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Store store = new Store();
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetStore/" + id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    store = JsonConvert.DeserializeObject<Store>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if(success)
            {
                ViewBag.Message = "Successfully updated store";
            }
            return View(store);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStoreInfoAsync()
        {
            Store store = new Store()
            {
                Id = Convert.ToInt32(Request.Form["Id"]),
                Name = Request.Form["Name"],
                Address = Request.Form["Address"]
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(store);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync("/api/UpdateStore/" + Request.Form["Id"].ToString(), content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateStore", new { id = store.Id, success = true });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("UpdateStore", new { id = store.Id });
        }

        public async Task<IActionResult> UpdateMicroprocessorAsync(int id, bool success = false)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Microprocessor microprocessor = new Microprocessor();
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetMicroprocessor/" + id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    microprocessor = JsonConvert.DeserializeObject<Microprocessor>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (success)
            {
                ViewBag.Message = "Successfully updated microprocessor";
            }
            return View(microprocessor);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateMicroprocessorInfoAsync()
        {
            Microprocessor microprocessor = new Microprocessor()
            {
                Id = Convert.ToInt32(Request.Form["Id"]),
                Name = Request.Form["Name"],
                Description = Request.Form["Description"]
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(microprocessor);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync("/api/UpdateMicroprocessor/" + Request.Form["Id"].ToString(), content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("UpdateMicroprocessor", new { id = microprocessor.Id, success = true });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("UpdateMicroprocessor", new { id = microprocessor.Id });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAvailabilityForStoreAsync()
        {
            int availabilityid = Convert.ToInt32(Request.Form["availabilityid"]);
            int storeid = Convert.ToInt32(Request.Form["storeid"]);
            int microprocessorid = Convert.ToInt32(Request.Form["microprocessorid"]);
            Availability availability = new Availability()
            {
                Id = availabilityid,
                StoreId = storeid,
                MicroprocessorId = microprocessorid,
                Price = Convert.ToDouble(Request.Form["price"]),
                Quantity = Convert.ToInt32(Request.Form["quantity"])
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(availability);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync("/api/UpdateAvailability/" + availabilityid.ToString(), content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AvailabilitiesForStore", new { id = storeid, success = true });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("AvailabilitiesForStore", new { id = storeid });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAvailabilityForMicroprocessorAsync()
        {
            int availabilityid = Convert.ToInt32(Request.Form["availabilityid"]);
            int storeid = Convert.ToInt32(Request.Form["storeid"]);
            int microprocessorid = Convert.ToInt32(Request.Form["microprocessorid"]);
            Availability availability = new Availability()
            {
                Id = availabilityid,
                StoreId = storeid,
                MicroprocessorId = microprocessorid,
                Price = Convert.ToDouble(Request.Form["price"]),
                Quantity = Convert.ToInt32(Request.Form["quantity"])
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(availability);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PutAsync("/api/UpdateAvailability/" + availabilityid.ToString(), content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AvailabilitiesForMicroprocessor", new { id = microprocessorid, success = true });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("AvailabilitiesForMicroprocessor", new { id = microprocessorid });
        }

        public async Task<IActionResult> DeleteStoreAsync(int id)
        {
            // DELETE ALL AVAILABILITIES FIRST WITH STOREID = ID
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response;
                response = await client.DeleteAsync("/api/DeleteStore/" + id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Stores");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("Stores");
        }

        public async Task<IActionResult> DeleteMicroprocessorAsync(int id)
        {
            // DELETE ALL AVAILABILITIES FIRST WITH MICROPROCESSORID = ID
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response;
                response = await client.DeleteAsync("/api/DeleteMicroprocessor/" + id.ToString());
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Microprocessors");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("Microprocessors");
        }

        public async Task<IActionResult> DeleteStoreAvailabilityAsync(int avilabilityid, int storeid)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response;
                response = await client.DeleteAsync("/api/DeleteAvailability/" + avilabilityid.ToString());
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AvailabilitiesForStore", new { id = storeid });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("AvailabilitiesForStore", new { id = storeid });
        }
        public async Task<IActionResult> DeleteMicroprocessorAvailabilityAsync(int avilabilityid, int microprocessorid)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response;
                response = await client.DeleteAsync("/api/DeleteAvailability/" + avilabilityid.ToString());
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AvailabilitiesForMicroprocessor", new { id = microprocessorid });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return RedirectToAction("AvailabilitiesForMicroprocessor", new { id = microprocessorid });
        }

        public IActionResult AddStore()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewStoreAsync()
        {
            Store store = new Store()
            {
                Name = Request.Form["Name"],
                Address = Request.Form["Address"]
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(store);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync("/api/AddStore", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Stores");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("Stores");
        }

        public IActionResult AddMicroprocessor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewMicroprocessorAsync()
        {
            Microprocessor microprocessor = new Microprocessor()
            {
                Name = Request.Form["Name"],
                Description = Request.Form["Description"]
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(microprocessor);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync("/api/AddMicroprocessor", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Microprocessors");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("Microprocessors");
        }




        public async Task<IActionResult> AddAvailabilityForStoreAsync(int storeId)
        {
            AddAvailabilityForStoreVM vm = new AddAvailabilityForStoreVM();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetStore/" + storeId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    vm.Store = JsonConvert.DeserializeObject<Store>(json);
                }

                response = await client.GetAsync("/api/GetMicroprocessors");
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    vm.AllMicroprocessors = JsonConvert.DeserializeObject<IEnumerable<Microprocessor>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAvailabilityForStore()
        {
            Availability availability = new Availability()
            {
                StoreId = Convert.ToInt32(Request.Form["storeId"]),
                MicroprocessorId = Convert.ToInt32(Request.Form["microprocessorId"]),
                Quantity = Convert.ToInt32(Request.Form["quantity"]),
                Price = Convert.ToDouble(Request.Form["price"])
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(availability);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync("/api/AddAvailability", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AvailabilitiesForStore", new { id = availability.StoreId });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("AvailabilitiesForStore", new { id = availability.StoreId });
        }

        public async Task<IActionResult> AddAvailabilityForMicroprocessorAsync(int microprocessorId)
        {
            AddAvailabilityForMicroprocessorVM vm = new AddAvailabilityForMicroprocessorVM();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                string json;
                HttpResponseMessage response;
                response = await client.GetAsync("/api/GetMicroprocessor/" + microprocessorId.ToString());
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    vm.Microprocessor = JsonConvert.DeserializeObject<Microprocessor>(json);
                }

                response = await client.GetAsync("/api/GetStores");
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    vm.AllStores = JsonConvert.DeserializeObject<IEnumerable<Store>>(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewAvailabilityForMicroprocessor()
        {
            Availability availability = new Availability()
            {
                StoreId = Convert.ToInt32(Request.Form["storeId"]),
                MicroprocessorId = Convert.ToInt32(Request.Form["microprocessorId"]),
                Quantity = Convert.ToInt32(Request.Form["quantity"]),
                Price = Convert.ToDouble(Request.Form["price"])
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                HttpResponseMessage response;
                json = JsonConvert.SerializeObject(availability);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                response = await client.PostAsync("/api/AddAvailability", content);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("AvailabilitiesForMicroprocessor", new { id = availability.MicroprocessorId });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return RedirectToAction("AvailabilitiesForMicroprocessor", new { id = availability.MicroprocessorId });
        }
    }
}
