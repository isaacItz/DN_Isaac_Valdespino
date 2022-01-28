using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessExampleEntityFramework;
using DataAccessExampleCore; 


namespace DataAccessExample.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehiclesDataManager _manager;
        public VehiclesController(IVehiclesDataManager manager)
        {
            _manager = manager;
        }
        // GET: api/<ColorsController>
        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ColorsController>/5
        [HttpGet("{id}")]
        public Vehicle Get(int id)
        {
            return _manager.Get(id);
        }

        // POST api/<ColorsController>
        [HttpPost]
        public void Post([FromBody] Vehicle value)
        {
            _manager.Insert(value);
        }

        // PUT api/<ColorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Vehicle value)
        {
            value.Id = id;
            _manager.Update(value);
        }

        // DELETE api/<ColorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }
    }
}