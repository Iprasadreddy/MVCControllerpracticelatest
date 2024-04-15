using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register()
        {
            return View();
        }

        // POST: Registration/Register
        [HttpPost]
        public ActionResult Register(string username, string email, string password)
        {
            // Process registration data here
            // For demo purposes, simply redirect to a thank you page
            return RedirectToAction("ThankYou");
        }

        // GET: Registration/ThankYou
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}