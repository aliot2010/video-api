using System;
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
        [HttpGet("films")]
        public string Get()
        {
            return JsonConvert.SerializeObject(Storage.getInstance().films);
        }
         
        // GET api/films
        [HttpGet("films/{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Storage.getInstance().getFilmById(id));
        }

        // POST api/values
        [HttpPost("films")]
        public string Post([FromBody] Film film)
        {
            if (film == null)
            {
                return BadRequest().StatusCode.ToString();
            }

            film.id = Storage.getInstance().films.Count;
            Storage.getInstance().films.Add(film);

            return JsonConvert.SerializeObject(film);
        }

        // PUT api/values/5
        [HttpPut("films/{id}")]
        public string Put(int id, [FromBody] Film film)
        {
            if (film == null)
            {
                return BadRequest().StatusCode.ToString();
            }

            Storage.getInstance().setFilmById(id, film);

            return JsonConvert.SerializeObject(Storage.getInstance().getFilmById(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}