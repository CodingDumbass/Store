using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Models;
using Store.Services.Authentication;

namespace Store.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return PartialView("_LoginForm");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _LoginForm( CustomerModel customer)
        {
            
            if (ModelState.IsValid)
            {
                DbAuthentication db_aut = new DbAuthentication();
                bool success = db_aut.Authenticate(customer);
                if (success)
                    return View("LoginSuccessful", customer);
                else
                    return RedirectToAction("LoginFailed");
            }
            return RedirectToAction("MainPage", "Shop", "divOne");
        }
        public IActionResult LoginSuccessful()
        {
            return View();
        }
        public IActionResult LoginFailed()
        {
            return View();
        }

    }
}
