using Microsoft.AspNetCore.Mvc;

namespace UpworkProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
