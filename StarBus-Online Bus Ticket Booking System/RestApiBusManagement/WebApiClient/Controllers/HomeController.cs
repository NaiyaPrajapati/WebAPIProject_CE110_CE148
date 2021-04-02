using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApiClient.Models;

namespace WebApiClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly HttpClient client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            Console.WriteLine("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Bus>>(responseStream);
                return View(temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Bus>();
                return View(temp);
            }



        }

        public async Task<dynamic> goToIndex()
        {
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Bus>>(responseStream);
                return temp;
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Bus>();
                return temp;
            }

        }
        public async Task<IActionResult> IndexBus()
        {
            Console.WriteLine("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Bus>>(responseStream);
                return View(temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Bus>();
                return View(temp);
            }



        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(Bus b)
        {

            if (ModelState.IsValid)
            {
                HttpClient client1 = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:44344/api/Bus");
                var myContent = JsonConvert.SerializeObject(b);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client1.PostAsync("https://localhost:44374/api/Bus", byteContent).Result;

                if (result.IsSuccessStatusCode)
                {
                    HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus");
                    var response = await client1.SendAsync(msg);

                    if (response.IsSuccessStatusCode)
                    {
                        using var responseStream = await response.Content.ReadAsStreamAsync();
                        var temp = await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<Bus>>(responseStream);


                        return View("Index", temp);
                    }
                    else
                    {
                        //GetBranchesError = true;
                        var temp = Array.Empty<Bus>();
                        return View("Index", temp);
                    }

                }
                else
                {
                    return View();
                }

            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus/" + id);
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp2 = await response.Content.ReadAsStringAsync();
                var temp1 = JsonConvert.DeserializeObject<Bus>(temp2);
                return View(temp1);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Bus>();
                return View(temp[0]);
            }

            //return View();
        }



        [HttpGet]
        public async Task<ActionResult> Delete(int id)
        {
            Console.WriteLine(id);
            Console.WriteLine("Hello");
            using var httpResponse =
        await client.DeleteAsync("https://localhost:44374/api/Bus/" + id);

            httpResponse.EnsureSuccessStatusCode();
            //RedirectToAction("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Bus>>(responseStream);
                return View("Index", temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Bus>();
                return View("Index", temp);
            }

            //return View("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Bus b)
        {

            var todoItemJson = new StringContent(
        System.Text.Json.JsonSerializer.Serialize(b),
        Encoding.UTF8,
        "application/json");

            using var httpResponse =
                await client.PutAsync("https://localhost:44374/api/Bus/" + b.id, todoItemJson);

            httpResponse.EnsureSuccessStatusCode();
            //RedirectToAction("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Bus");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Bus>>(responseStream);
                return View("Index", temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Bus>();
                return View("Index", temp);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
