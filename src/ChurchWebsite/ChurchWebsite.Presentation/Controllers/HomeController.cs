namespace ChurchWebsite.Presentation.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ChurchWebsite.Presentation.Data;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

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

        public async Task<IActionResult> Event()
        {
            ViewData["Message"] = "Your application Event description.";

            return View(await _context.EventItems.OrderByDescending(e => e.EventDate).ToListAsync());
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
