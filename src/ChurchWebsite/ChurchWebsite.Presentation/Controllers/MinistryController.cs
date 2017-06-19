using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChurchWebsite.Presentation.Controllers
{
    public class MinistryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Family()
        {
            ViewData["Message"] = "Your family ministry description page.";

            return View();
        }

        public IActionResult Adult()
        {
            ViewData["Message"] = "Your adult ministry description page.";

            return View();
        }

        public IActionResult Youth()
        {
            ViewData["Message"] = "Your youth ministry description page.";

            return View();
        }

        public IActionResult Children()
        {
            ViewData["Message"] = "Your children ministry description page.";

            return View();
        }
    }
}