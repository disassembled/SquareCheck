using Maths;
using Microsoft.AspNetCore.Mvc;
using SquareCheck.Models;
using System.Diagnostics;

namespace SquareCheck.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult IsSquareNumber(string strNumber)
        {
            var result = Calculator.Evaluate(strNumber);
            return Json(result);
        }
    }
}