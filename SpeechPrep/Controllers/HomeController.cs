using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpeechPrep.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Preparing for an interview? Speech Prep is for you!";

            return View();
        }


        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        public ActionResult Questions()
        {
            ViewBag.Message = "Whatcha want?!.";

            return View();
        }
        //public ActionResult Login()
        //{
        //    ViewBag.Message = "Log me In!";

        //    return View();
        //}
    }
}