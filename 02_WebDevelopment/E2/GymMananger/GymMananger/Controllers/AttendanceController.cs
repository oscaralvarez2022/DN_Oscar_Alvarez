using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMananger.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MemberIn()
        {
            return View();
        }

        public IActionResult MemberOut()
        {
            return View();
        }
    }
}
