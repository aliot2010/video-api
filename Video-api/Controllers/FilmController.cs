﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Video_api.Controllers
{
    [Route("api")]
    public class FilmController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }
         
        // GET api/films
        [HttpGet("films/{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Storage.getInstance().films[id]);
        }

        // POST api/values
        [HttpPost("films")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("films/{id}")]
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