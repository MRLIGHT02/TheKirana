using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Remove()
        {
            return View();
        }
        public IActionResult UpdateQuantity()
        {
            return View();
        }

    }
}
