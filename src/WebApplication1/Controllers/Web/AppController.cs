using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        private IParkingRepository _repository;
        private ILogger<AppController> _logger;

        public AppController(
            IMailService mailService, 
            IConfigurationRoot config, 
            IParkingRepository repository,
            ILogger<AppController> logger)
        {
            _mailService = mailService;
            _config = config;
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var data = _repository.GetAllParkings();
                return View(data);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error while getting all parkings: {ex.Message}.");
                return Redirect("/error");
            }
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
