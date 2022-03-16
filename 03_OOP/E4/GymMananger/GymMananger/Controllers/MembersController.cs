using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymMananger.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Serilog.Events;
using System.Collections.Generic;

namespace GymMananger.Controllers
{
    public class MembersController : Controller
    {
        private readonly IMembersAppService _memberAppServices;
        public MembersController(IMembersAppService memberAppServices)
        {
            _memberAppServices = memberAppServices;
        }

        public IActionResult Index()
        {
            List<Member> members = _memberAppServices.GetMembers();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

           

            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                //.WriteTo.Console(LogEventLevel.Information)
                .WriteTo.File("log.txt", LogEventLevel.Information)
                .CreateLogger();

            logger.Verbose("Mensaje Verbose");
            logger.Debug("Mensaje Debug");
            logger.Information("Mensaje Information");
            logger.Warning("Mensaje Warning");
            logger.Error("Mensaje Error");
            logger.Fatal("Mensaje Fatal");


            //FileLogger.Log("You Enter to Members option");


            return View(viewModel);
        }

        public IActionResult Test()
        {
            return View();
        }


        //...


    }
}
