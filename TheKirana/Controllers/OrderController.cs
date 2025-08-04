using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            // Logic to get order details by id
            // For now, just returning a view
           
            return View(id);
        }
    }
}
