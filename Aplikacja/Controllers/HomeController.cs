using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewData["greeting"] = hour < 17 ? "dzień dobry" : "Dobry wieczór";
            return View();
        }
        
        [HttpGet]
        public ViewResult RsvpFrom()
        {
            return ();
        }
        [HttpGet]
        public ViewResult RsvpFrom(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}