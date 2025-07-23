using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Confirm()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
