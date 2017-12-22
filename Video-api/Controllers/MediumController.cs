
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace Video_api.Controllers
{
    [Route("api/mediums")]
    public class MediumController : Controller
    {

        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(Storage.getInstance().mediums);
        }
        
        
        // GET api/mediums/0
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Storage.getInstance().getMediumById(id));
        }
        

        // POST api/values
        [HttpPost()]
        public string Post([FromBody] Medium medium)
        {
            if (medium == null)
            {
                return BadRequest().StatusCode.ToString();
            }

            medium.id = Storage.getInstance().mediums.Count;
            Storage.getInstance().mediums.Add(medium);

            return JsonConvert.SerializeObject(medium);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Medium medium)
        {
            if (medium == null)
            {
                return BadRequest().StatusCode.ToString();
            }
            
            Storage.getInstance().setMediumById(id, medium);

            return JsonConvert.SerializeObject(Storage.getInstance().getMediumById(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}