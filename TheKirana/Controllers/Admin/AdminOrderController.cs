using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers.Admin
{
    public class AdminOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
