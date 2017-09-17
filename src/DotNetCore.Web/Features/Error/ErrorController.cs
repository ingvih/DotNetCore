using System.Diagnostics;
using DotNetCore.Web.Features.Home;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Web.Features.Error
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
