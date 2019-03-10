using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    string htmlPage= "";

        //    htmlPage += "<html>";
        //    htmlPage += "<head><title>Second Test</title></head>";
        //    htmlPage += "<body>";
        //    htmlPage += "<h1>Big header for Hello World<h1>";          
        //    htmlPage += "Hi World <br />";
        //    htmlPage += "just to be different";
        //    htmlPage += "</body>";
        //    htmlPage += "</html>";


        //    return htmlPage;
        //}

        // GET: Home

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            ViewBag.Greeting = hour < 12 ? "Good Morning" + hour + ":" + minute : "Good Afternoon";
            ViewBag.NowTime = hour + ":" + minute;
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}