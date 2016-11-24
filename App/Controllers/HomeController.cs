using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Get = hour > 12 ? "Good Evening" : "Good Morning"; 
            return View();
        }

        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestresponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestresponse);
            }
            else
            {
                return View();
            }            
        }
    }
}