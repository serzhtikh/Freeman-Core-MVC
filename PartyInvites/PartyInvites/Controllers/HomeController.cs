using System;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour >= 12 ? "Good afternoon" : "Good morning";

            return View("MyView");
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
