using Microsoft.AspNetCore.Mvc;

namespace Project_19101001_002.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult showdata(string firstname,string secondname,string gender,string s)
        {
            ViewBag.MessageF = "First-Name:" + firstname;
            ViewBag.MessageS = "Second-Name:" + secondname;
            ViewBag.MessageG = "Gender"+gender;
            ViewBag.MessageD = "Deparrment:" + s;
            
            return View();
        }
    }
}
