using System;
using System.Web.Mvc;
using Aplikacja.Models;

namespace Aplikacja.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewData["greeting"] = hour < 17 ? "Dzień dobry !" : "Dobry wieczór";
            return View();
        }
        
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View() ;
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)

        {
            return View("Thanks", guestResponse);
        }
        
    }
}