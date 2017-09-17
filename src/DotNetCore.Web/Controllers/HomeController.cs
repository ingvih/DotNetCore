using System.Diagnostics;
using DotNetCore.Web.Core;
using DotNetCore.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var helperClass = new HelperClass();
            string value = helperClass.GetTestValue("Value from Web.");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
