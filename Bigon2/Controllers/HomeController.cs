﻿using Microsoft.AspNetCore.Mvc;

namespace Bigon2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
