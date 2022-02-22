using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Mvc;

namespace GymMananger.Controllers
{
    public class HomeController : Controller
    {
        private readonly iMembersAppService _membersAppService;
        public HomeController(iMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }

        public IActionResult Index()
        {
            var members = _membersAppService.GetMembers();

            return View(members);
        }

    }
}
