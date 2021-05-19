﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScheduleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Sign_in()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return Redirect("/Schedule/Index");
        }
        
        public IActionResult Sign_up()
        {
            return Redirect("/SignUp/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
