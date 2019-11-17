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

        private ApplicationDbContext _context;

        public QuestionController()
        {
            _context = new ApplicationDbContext(); //Initialize _context in constructor
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); //_context is disposable object so need to get rid of
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Random(int id)
        {
            var question = _context.Questions.SingleOrDefault(q => q.Id == id);
            //var question = new Question() { InterviewQuestion = "How many pickles did peter pick on the pickling tree?" };
            if (question == null)
                return HttpNotFound();
            return View(question);
        }

        public ActionResult Id(int id)
        {
            var question = _context.Questions.SingleOrDefault(q => q.Id == id);
            if (question == null)
                return HttpNotFound();
            return View(question);
        }

        public ActionResult MasterList()
        {
            var question = _context.Questions.ToList();
            if (question == null)
                return HttpNotFound();
            return View(question);
        }

        public ActionResult QuestionSort()
        {
            return View();
        }

        ////TODO: Create view based on behavioral question types
        //[Route("Question/{star}")]
        //public ActionResult StarType(string star)
        //{
        //    return Content(star);
        //}
    }
}