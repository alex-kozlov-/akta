using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public AppController(IMailService mailService, IConfigurationRoot config)
        {
            _mailService = mailService;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Users(UserViewModel model)
        {
            if (model.Email.Contains("aol.com"))
            {
                ModelState.AddModelError("", "We do not send messages to AOL accounts");
            }

            if (ModelState.IsValid)
            {
                _mailService.Send(_config["MailSettings:ToAddress"], model.Email, model.Name, model.Description);
                ViewBag.UserMessage = "The description has been saved.";
                ModelState.Clear();
            }
            return View();
        }

        public IActionResult Locations()
        {
            return View();
        }
    }
}
