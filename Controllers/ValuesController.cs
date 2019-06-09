using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AppSettingsWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace AppSettingsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static HttpClient client = new HttpClient();

        private FileUploadSettings _settings;

        public ValuesController(IOptions<FileUploadSettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet]
        [Route("MyJsonGenerator")]
        public async Task<ActionResult<List<MyJsonGenerator>>> GetMyJsonGenerator()
        {
            const string path = "http://www.json-generator.com/api/json/get/ceFKNXARvm";
            var resp = await client.GetAsync(path);
            if (resp.IsSuccessStatusCode)
            {
                var result = await resp.Content.ReadAsAsync<List<MyJsonGenerator>>();
                return result;
            }

            return BadRequest("yo");
        }

        [HttpGet]
        [Route("MyName")]
        public async Task<ActionResult<MyName>> GetMyName()
        {
            const string path = "https://james-yin.github.io/data.json";
            var resp = await client.GetAsync(path);
            if (resp.IsSuccessStatusCode)
            {
                var result = await resp.Content.ReadAsAsync<MyName>();
                return result;
            }

            return BadRequest("yo");
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_settings);
        }

        // public ActionResult<FileUploadSettings> Get()
        // {
        //     return Ok(_settings);
        // }

        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public partial class MyName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public partial class MyJsonGenerator
    {
        [JsonProperty("guid")]
        public Guid Guid { get; set; }

        [JsonProperty("index")]
        public long Index { get; set; }

        [JsonProperty("favoriteFruit")]
        public string FavoriteFruit { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("picture")]
        public Uri Picture { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("friends")]
        public Friend[] Friends { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("age")]
        public long Age { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public partial class Friend
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

}
