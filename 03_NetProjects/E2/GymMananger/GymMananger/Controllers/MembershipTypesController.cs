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
    public class MembershipTypesController : Controller
    {
        private readonly IMembersAppService _membersAppService;
        public MembershipTypesController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }

        public IActionResult Index()
        {
            List<MembershipType> membershipTypes = _membersAppService.GetMembershipTypes();

            MembershipTypesListViewModel viewModel = new MembershipTypesListViewModel();

            viewModel.MembershipTypeCount = 2;
            viewModel.MembershipTypes = membershipTypes;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MembershipType membershipType)
        {
            _membersAppService.AddMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int membershipTypeId)
        {
            MembershipType membershipType = _membersAppService.GetMembershipType(membershipTypeId);

            return View(membershipType);
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membershipType)
        {
            _membersAppService.EditMembershipType(membershipType);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int membershipTypeId)
        {
            _membersAppService.DeleteMembershipType(membershipTypeId);

            return RedirectToAction("Index");
        }
    }
}
