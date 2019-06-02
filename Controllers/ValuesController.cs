using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppSettingsWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AppSettingsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private FileUploadSettings _settings;

        public ValuesController(IOptions<FileUploadSettings> settings)
        {
            _settings = settings.Value;
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
}
