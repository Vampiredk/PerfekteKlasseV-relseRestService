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
    public class MeasurementController : ControllerBase
    {

        private MeasManager _manager = new MeasManager();
        // GET: api/<MeasurementController>
        [HttpGet]
        public IEnumerable<Measurement> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<MeasurementController>/5
        [HttpGet("{id}")]
        public Measurement Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<MeasurementController>
        [HttpPost]
        public void Post([FromBody] Measurement value)
        {
            _manager.Add(value);
        }

        // PUT api/<MeasurementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Measurement value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<MeasurementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
