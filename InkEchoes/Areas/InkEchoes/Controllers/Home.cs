﻿using Microsoft.AspNetCore.Mvc;

namespace InkEchoes.Areas.InkEchoes.Controllers
{
    public class Home : Controller
    {


        public Home()
        {
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
