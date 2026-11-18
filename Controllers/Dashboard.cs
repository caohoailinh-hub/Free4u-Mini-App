using Microsoft.AspNetCore.Mvc;

namespace Free4u_Mini_App.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
