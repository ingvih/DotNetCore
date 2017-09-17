using System.Diagnostics;
using DotNetCore.Web.Core;
using DotNetCore.Web.Core.Business;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Web.Features.Home
{
    public class HomeController : Controller
    {
        private IContentBusiness _contentBusiness;
        public HomeController(IContentBusiness contentBusiness)
        {
            _contentBusiness = contentBusiness;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Property = _contentBusiness.GetTestContent("Input")
            };
            return View(model);
        }
    }
}
