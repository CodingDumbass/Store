using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Models;
using Store.Services.Authentication;
namespace Store.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View("_RegisterForm");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> _RegisterForm( CustomerModel customer)
        {
            string pass = Request.Form["ConfirmPassword"];
            if (ModelState.IsValid && pass == customer.CustomerPassword)
            {
                DbAuthentication db_aut = new DbAuthentication();
                bool success = db_aut.AuthenticateEmail(customer);
                if (success)
                    return View("RegisterSuccessful", customer);
                else
                    return RedirectToAction("RegisterFailed");
            }
            return RedirectToAction("MainPage", "Shop", "divOne");
        }
       
        public IActionResult RegisterSuccessful()
        {
            return View();
        }
        public IActionResult RegisterFailed()
        {
            return View();
        }
    }
}
