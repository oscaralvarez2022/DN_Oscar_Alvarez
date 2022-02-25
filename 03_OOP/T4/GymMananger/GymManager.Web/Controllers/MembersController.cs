﻿using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymMananger.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymMananger.Controllers
{
    public class MembersController : Controller
    {
        private readonly iMembersAppService _membersAppService;
        public MembersController(iMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }

        public IActionResult Index()
        {
            List<Member> members = _membersAppService.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();
            viewModel.NewMembersCount = members.Count;
            viewModel.Members = members;

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int memberId)
        {
            _membersAppService.DeleteMember(memberId);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int memberId)
        {
            Member member = _membersAppService.GetMember(memberId);

            return View(member);
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            _membersAppService.AddMember(member);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Member member)
        {
            _membersAppService.EditMember(member);

            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
