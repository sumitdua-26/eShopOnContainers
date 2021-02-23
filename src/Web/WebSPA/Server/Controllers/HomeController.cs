﻿// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

using eShopOnContainers.WebSPA;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace eShopConContainers.WebSPA.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IOptionsSnapshot<AppSettings> _settings;

        public HomeController(IWebHostEnvironment env, IOptionsSnapshot<AppSettings> settings)
        {
            _env = env;
            _settings = settings;
        }
        public IActionResult Configuration()
        {
            _settings.Value.InstrumentationKey = Environment.GetEnvironmentVariable("ApplicationInsights__InstrumentationKey");
            return Json(_settings.Value);
        }
    }
}
