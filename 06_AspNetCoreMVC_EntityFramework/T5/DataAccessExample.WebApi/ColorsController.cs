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
    public class ColorsController : ControllerBase
    {
        private readonly IColorsDataManager _manager;
        public ColorsController(IColorsDataManager manager)
        {
            _manager = manager;
        }
        // GET: api/<ColorsController>
        [HttpGet]
        public IEnumerable<Color> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ColorsController>/5
        [HttpGet("{id}")]
        public Color Get(int id)
        {
            return _manager.Get(id);
        }

        // POST api/<ColorsController>
        [HttpPost]
        public void Post([FromBody] Color value)
        {
            _manager.Insert(value);
        }

        // PUT api/<ColorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Color value)
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