using Demo.Common;
using Demo.Service1;
using Demo.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Demo.WebSite.Models.ViewModels.SrvTestsController;

namespace Demo.WebSite.Controllers
{
    public class SrvTestsController : Controller
    {
        private readonly ILogger<SrvTestsController> _logger;

        private readonly IService _service;
        private readonly IService1abc _service1Abc;

        public SrvTestsController(ILogger<SrvTestsController> logger, IService service, IService1abc service1Abc)
        {
            _logger = logger;
            _service = service;
            _service1Abc = service1Abc;
            _service.ValuePassedIn = "Passed in from Controller";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Srv1()
        {
            var model = new Srv1ViewModel();
            model.DoSomeWork = _service1Abc.DoSomeMoreWork();
            return View(model);
        }

        public IActionResult Srv2()
        {
            var model = new Srv2ViewModel();
            model.DoSomeWork = _service1Abc.DoSomeMoreWork();
            return View(model);
        }

        public IActionResult Fake()
        {
            var model = new Srv2ViewModel();
            model.DoSomeWork = _service1Abc.DoSomeMoreWork();
            model.FakeMethodHere = _service1Abc.FakeMethodHere();
            return View(model);
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