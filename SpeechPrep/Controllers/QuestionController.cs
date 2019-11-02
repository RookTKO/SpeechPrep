using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeechPrep.Models;

namespace SpeechPrep.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question/Random
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Random()
        {
            var question = new Question() { InterviewQuestion = "How many pickles did peter pick on the pickling tree?" };
            return View(question);
        }
        
        public ActionResult Questions()
        {
            var question = new Question() { InterviewQuestion = "How many pickles did peter pick on the pickling tree?" };
            return View(question);
        }
    }
}