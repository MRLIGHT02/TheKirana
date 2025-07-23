using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
