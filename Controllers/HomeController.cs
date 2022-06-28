using Microsoft.AspNetCore.Mvc;

namespace Project_19101001_002.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
