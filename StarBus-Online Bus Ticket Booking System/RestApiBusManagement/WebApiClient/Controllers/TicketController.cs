using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApiClient.Models;

namespace WebApiClient.Controllers
{
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        private static readonly HttpClient client = new HttpClient();

        public TicketController(ILogger<TicketController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            Console.WriteLine("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Ticket>>(responseStream);
                return View(temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Ticket>();
                return View(temp);
            }



        }
        public async Task<IActionResult> IndexTicket()
        {
            Console.WriteLine("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Ticket>>(responseStream);
                return View(temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Ticket>();
                return View(temp);
            }



        }


        public async Task<dynamic> goToIndex()
        {
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Ticket>>(responseStream);
                return temp;
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Ticket>();
                return temp;
            }

        }

        

        public IActionResult AboutUs()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Ticket t)
        {

            if (ModelState.IsValid)
            {
                HttpClient client1 = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:44344/api/Ticket");
                var myContent = JsonConvert.SerializeObject(t);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client1.PostAsync("https://localhost:44374/api/Ticket", byteContent).Result;

                if (result.IsSuccessStatusCode)
                {
                    HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
                    var response = await client1.SendAsync(msg);

                    if (response.IsSuccessStatusCode)
                    {
                        using var responseStream = await response.Content.ReadAsStreamAsync();
                        var temp = await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<Ticket>>(responseStream);


                        return View("Index", temp);
                    }
                    else
                    {
                        //GetBranchesError = true;
                        var temp = Array.Empty<Ticket>();
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
        public IActionResult CreateTicket()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> CreateTicket(Ticket t)
        {

            if (ModelState.IsValid)
            {
                HttpClient client1 = new HttpClient();
                //client.BaseAddress = new Uri("https://localhost:44344/api/Ticket");
                var myContent = JsonConvert.SerializeObject(t);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client1.PostAsync("https://localhost:44374/api/Ticket", byteContent).Result;

                if (result.IsSuccessStatusCode)
                {
                    HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
                    var response = await client1.SendAsync(msg);

                    if (response.IsSuccessStatusCode)
                    {
                        using var responseStream = await response.Content.ReadAsStreamAsync();
                        var temp = await System.Text.Json.JsonSerializer.DeserializeAsync<IEnumerable<Ticket>>(responseStream);


                        return View("IndexTicket",temp);
                    }
                    else
                    {
                        //GetBranchesError = true;
                        var temp = Array.Empty<Ticket>();
                        return View("IndexTicket", temp);
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
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket/" + id);
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp2 = await response.Content.ReadAsStringAsync();
                var temp1 = JsonConvert.DeserializeObject<Ticket>(temp2);
                return View(temp1);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Ticket>();
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
        await client.DeleteAsync("https://localhost:44374/api/Ticket/" + id);

            httpResponse.EnsureSuccessStatusCode();
            //RedirectToAction("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Ticket>>(responseStream);
                return View("Index", temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Ticket>();
                return View("Index", temp);
            }

            //return View("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Ticket t)
        {

            var todoItemJson = new StringContent(
        System.Text.Json.JsonSerializer.Serialize(t),
        Encoding.UTF8,
        "application/json");

            using var httpResponse =
                await client.PutAsync("https://localhost:44374/api/Ticket/" + t.id, todoItemJson);

            httpResponse.EnsureSuccessStatusCode();
            //RedirectToAction("Index");
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44374/api/Ticket");
            var response = await client.SendAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var temp = await System.Text.Json.JsonSerializer.DeserializeAsync
                    <IEnumerable<Ticket>>(responseStream);
                return View("Index", temp);
            }
            else
            {
                //GetBranchesError = true;
                var temp = Array.Empty<Ticket>();
                return View("Index", temp);
            }
        }
    }
}
