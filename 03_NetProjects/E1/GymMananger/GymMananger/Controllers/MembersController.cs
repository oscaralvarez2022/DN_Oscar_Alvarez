using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymMananger.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMananger.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMembersAppService _memberAppServices;
        public MembersController (IMembersAppService memberAppServices)
        {
            _memberAppServices = memberAppServices;
        }

        public IActionResult Index()
        {
            List<Member> members = _memberAppServices.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            return View(viewModel);
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
