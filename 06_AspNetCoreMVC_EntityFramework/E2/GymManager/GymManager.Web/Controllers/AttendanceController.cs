using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace GymManager.Web.Controllers
{
    [Authorize]
    public class AttendanceController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        private readonly ILogger<AttendanceController> _logger;

        public AttendanceController(IMembersAppService membersAppService, ILogger<AttendanceController> logger)
        {
            _logger = logger;
            _membersAppService = membersAppService;
            
        }
        public async Task<IActionResult> Index()
        {
            List<Member> members = await _membersAppService.GetMembersAsync();
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
        public async Task<IActionResult> Create(Member member)
        {
            await _membersAppService.AddMemberAsync(member);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int memberId)
        {
            await _membersAppService.DeleteMemberAsync(memberId);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int memberID)
        {
            Member member = await _membersAppService.GetMemberAsync(memberID);
            return View(member);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {
            await _membersAppService.EditMemberAsync(member);

            return RedirectToAction("Index");
        }
    }
}
