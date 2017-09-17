using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Web.Features.News
{
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
