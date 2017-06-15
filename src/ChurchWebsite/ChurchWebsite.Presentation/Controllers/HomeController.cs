using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Ministry()
        {
            ViewData["Message"] = "Your application Ministry description.";

            return View();
        }

        public IActionResult Event()
        {
            ViewData["Message"] = "Your application Event description.";

            return View();
        }

        public IActionResult Calendar()
        {
            ViewData["Message"] = "Your application Calendar description.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
