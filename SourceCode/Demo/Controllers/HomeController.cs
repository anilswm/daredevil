using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo.Models;
using IOSdk;
using IOSdk.RequestModels;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            Config.ApiKey = "06929411-f9d7-4b70-9b28-02f68875cb79";
            Config.ApiSecret = "";
            _logger = logger;
        }

        public IActionResult Index()
        {
            var registerPayload = new UserRegisterationModel();
            registerPayload.Email = "a6@mailazy.com";
            registerPayload.Password = "123456";
            var result = new API().Register(registerPayload);
            ViewBag.result = result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
