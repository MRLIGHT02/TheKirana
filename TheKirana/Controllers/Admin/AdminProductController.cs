using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers.Admin
{
    public class AdminProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        public IActionResult Edit(int id)
        {
            // Logic to get product details by id for editing
            // For now, just returning a view with the id
            return View(id);
        }
    }
}
