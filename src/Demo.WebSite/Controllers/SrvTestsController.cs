using Demo.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.WebSite.Controllers
{
    public class SrvTestsController : Controller
    {
        private readonly ILogger<SrvTestsController> _logger;

        public SrvTestsController(ILogger<SrvTestsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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