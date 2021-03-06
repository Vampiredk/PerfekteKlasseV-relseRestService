using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PerfekteKlasseVærelseRestService.Manager;
using PerfekteKlasseVærelseRestService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PerfekteKlasseVærelseRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        private TempManager _manager = new TempManager();
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<Temp> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public Temp Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] Temp value)
        {
            _manager.Add(value);
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Temp value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
