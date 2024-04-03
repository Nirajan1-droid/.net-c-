using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Student.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            // Passing data from controller to view
            ViewData["Title"] = "My Home Page";
            ViewData["Message"] = "My Message";
            return View();
        }
    }
}