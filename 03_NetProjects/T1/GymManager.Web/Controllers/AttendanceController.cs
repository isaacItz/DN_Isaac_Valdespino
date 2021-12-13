using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View("MemberIn");
        }
        public IActionResult MemberIn()
        {
            return View("MemberIn");
        }
        public IActionResult MemberOut()
        {
            return View(MemberOut);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
