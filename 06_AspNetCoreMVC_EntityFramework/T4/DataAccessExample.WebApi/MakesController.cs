using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataAccessExampleCore;
using DataAccessExampleEntityFramework;

namespace DataAccessExample.WebApi
{
    [Route("[controller]")]
    public class MakesController : Controller
    {

        private readonly IQueriesExample _queries;
        public MakesController(ILogger<MakesController> logger, IQueriesExample queries)
        {
            _logger = logger;
            _queries = queries;
        }

        [HttpGet]
        public IEnumerable<Make> Get() {
            var result = _queries.GetMakes();
            return result;
        }

        [HttpGet(nameof(GetByPrice))]
        public IEnumerable<Vehicle> GetByPrice() {
            var result = _queries.GetVehiclesByPrice(80000, 150000);
            return result;
        }
        private readonly ILogger<MakesController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}