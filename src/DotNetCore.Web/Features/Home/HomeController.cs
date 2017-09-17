using System.Diagnostics;
using DotNetCore.Web.Core;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Web.Features.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var helperClass = new HelperClass();
            string value = helperClass.GetTestValue("Value from Web.");
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
