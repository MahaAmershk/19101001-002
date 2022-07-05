using Microsoft.AspNetCore.Mvc;

namespace Project_19101001_002.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult showdata(string firstname,string secondname,string email,string phn,string dropdown_2, string dropdown)
        {
            ViewBag.MessageF = "First-Name:" + firstname;
            ViewBag.MessageS = "Second-Name:" + secondname;
            ViewBag.MessageG = "Email"+email;
            ViewBag.MessageD = "Phone Number:" + phn;
          
            ViewBag.MessageSe = "Service selected:" + dropdown;
            ViewBag.MessageT = "Time:" + dropdown_2;


            return View();
        }
    }
}
