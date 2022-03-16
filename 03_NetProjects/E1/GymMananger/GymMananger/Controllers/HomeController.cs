using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMananger.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMembersAppService _memberAppServices;
        public HomeController(IMembersAppService memberAppServices)
        {
            _memberAppServices = memberAppServices;
        }

        public IActionResult Index()
        {

            var members = _memberAppServices.GetMembers();

            return View(members);
        }

    }
}
