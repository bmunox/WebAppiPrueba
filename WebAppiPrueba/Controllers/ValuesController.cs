using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET API/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> get(int id)
         {
            id++;
            var b = id * 2;
            return "value: "+b.ToString();
        }
        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value) 
        {
        }
        //PUT api/values/5
        [HttpPut("{id}")]
        public void put(int id, [FromBody] string value)
        { 
        }
        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void delete(int id)
        { 
        }
    }
}
