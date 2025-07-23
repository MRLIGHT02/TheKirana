using Microsoft.AspNetCore.Mvc;

namespace TheKirana.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult LogoutLogoutLogoutLogoutLogout()
        {
            // Logic to handle user logout
            // For now, just redirecting to the home page
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Profile()
        {
            // Logic to get user profile details
            // For now, just returning a view
            return View();
        }
        public IActionResult ChangePassword()
        {
            // Logic to change user password
            // For now, just returning a view
            return View();
        }
    }
}
