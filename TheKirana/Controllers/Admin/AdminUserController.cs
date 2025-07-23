using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers.Admin
{
    public class AdminUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
