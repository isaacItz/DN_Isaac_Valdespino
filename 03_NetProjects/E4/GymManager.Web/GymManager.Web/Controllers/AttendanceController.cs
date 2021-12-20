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
        private readonly ILogger<AttendanceController> _logger;

        public AttendanceController(IMembersAppService membersAppService, ILogger<AttendanceController> logger)
        {
            _logger = logger;
            _membersAppService = membersAppService;
            
        }
        public IActionResult Index()
        {
            List<Member> members = _membersAppService.GetMembers();
            //Debug.WriteLine("MEMBERS: " + members);
            MemberListViewModel viewModel = new MemberListViewModel();
            viewModel.Members = members;
            viewModel.NewMembersCount = members.Count;
            _logger.LogWarning("Se ha entrado al index");
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
        public IActionResult Delete(int memberId)
        {
            _membersAppService.DeleteMember(memberId);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int memberID)
        {
            Member member = _membersAppService.GetMember(memberID);
            return View(member);
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppService.EditMember(member);

            return RedirectToAction("Index");
        }
    }
}
