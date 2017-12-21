using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Video_api.Controllers
{
    [Route("api/categories")]
    public class CategoryController : Controller
    {

        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(Storage.getInstance().categorys);
        }
        
        
        // GET api/clients/0
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(Storage.getInstance().getCategoryById(id));
        }
        

        // POST api/values
        [HttpPost()]
        public string Post([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest().StatusCode.ToString();
            }

            category.id = Storage.getInstance().categorys.Count;
            Storage.getInstance().categorys.Add(category);

            return JsonConvert.SerializeObject(category);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest().StatusCode.ToString();
            }
            
            Storage.getInstance().setCategoryById(id, category);

            return JsonConvert.SerializeObject(Storage.getInstance().getCategoryById(id));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}