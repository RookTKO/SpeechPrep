using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpeechPrep.Controllers
{
    public class ProfileController : Controller
    {
        // GET: UserProfile
        public ActionResult User()
        {
            return View();
        }
    }
}