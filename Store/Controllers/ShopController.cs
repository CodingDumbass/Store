using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult MainPage()
        {
            return View();
        }
    }
}
