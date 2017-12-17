using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Video_api.Controllers
{
    [Route("api/clients")]
    public class ClientController : Controller
    {

        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(Storage.getInstance().clients);
        }
        
        
        // GET api/clients/0
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Storage.getInstance().getClientById(id));
        }
        

        // POST api/values
        [HttpPost()]
        public string Post([FromBody] Client client)
        {
            if (client == null)
            {
                return BadRequest().StatusCode.ToString();
            }

            client.id = Storage.getInstance().clients.Count;
            Storage.getInstance().clients.Add(client);

            return JsonConvert.SerializeObject(client);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Client client)
        {
            if (client == null)
            {
                return BadRequest().StatusCode.ToString();
            }
            
            Storage.getInstance().setClientById(id, client);

            return JsonConvert.SerializeObject(Storage.getInstance().getClientById(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}