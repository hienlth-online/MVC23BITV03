using Buoi02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buoi02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Hello
        // GET: /Home/Hello?name=Ronaldo
        public IActionResult Hello(string name = "David")
        {
            return Content($"Hello {name}");
        }

        public IActionResult Data()
        {
            return Json(new { Name = "David", Age = 30 });
        }

        public IActionResult Google()
        {
            return Redirect("https://www.google.com");
        }

        public IActionResult Intro()
        {
            return RedirectToAction("Index", "Home");
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
