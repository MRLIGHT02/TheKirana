using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            // Logic to get product details by id
            // For now, just returning a view
            return View(id);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
