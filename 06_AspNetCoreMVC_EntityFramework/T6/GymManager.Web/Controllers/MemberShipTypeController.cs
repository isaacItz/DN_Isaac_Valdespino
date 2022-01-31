using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using GymManager.Core.Entities;
using GymManager.ApplicationServices.MemberShips;

namespace GymManager.Web.Controllers
{
    [Authorize]
    //[Route("[controller]")]
    public class MemberShipTypeController : Controller
    {
        private readonly ILogger<MemberShipTypeController> _logger;
        private readonly IMemberShipsAppService _memberShipsAppService;

        public MemberShipTypeController(IMemberShipsAppService memberShipsAppService, ILogger<MemberShipTypeController> logger)
        {
            _logger = logger;
            _memberShipsAppService = memberShipsAppService;
            
        }

        public async Task<IActionResult> Index()
        {
            List<Membership> list = await _memberShipsAppService.GetMemberShipsAsync();
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}