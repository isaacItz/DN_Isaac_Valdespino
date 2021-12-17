using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GymManager.Web.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        public AttendanceController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }
        public IActionResult Index()
        {
            List<Member> members = _membersAppService.GetMembers();
            //Debug.WriteLine("MEMBERS: " + members);
            MemberListViewModel viewModel = new MemberListViewModel();
            viewModel.Members = members;
            viewModel.NewMembersCount = members.Capacity;
            //viewModel.NewMembersCount = 2;

            return View(viewModel);
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppService.AddMember(member);
            return RedirectToAction("Index");
        }
    }
}
