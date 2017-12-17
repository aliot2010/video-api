using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Video_api.Controllers
{
    [Route("api")]
    public class ClientsController : Controller
    {

        // GET api/Clients
        [HttpGet("clients")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Storage.getInstance().clients);
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