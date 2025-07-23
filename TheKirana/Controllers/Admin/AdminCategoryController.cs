using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers.Admin
{
    public class AdminCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
