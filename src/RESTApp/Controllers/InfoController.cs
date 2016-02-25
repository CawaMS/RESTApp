using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTApp.Controllers
{
    [Route("api/[controller]")]
    public class InfoController : Controller
    {

        // GET: api/values
        [HttpGet]
        public string Get()
        {
            return "Welcome to the web api server. For machine info go to /MachineName. For time go to /CurrentTime";
        }

        [HttpGet("MachineName")]
        public string GetMN()
        {
            return Environment.MachineName;
        }

        [HttpGet("CurrentTime")]
        public string GetCT()
        {
            return DateTime.Now.ToString("HH:mm:ss tt");
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
