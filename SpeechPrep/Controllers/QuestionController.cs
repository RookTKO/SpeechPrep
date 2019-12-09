using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeechPrep.Models;
using SpeechPrep.ViewModels;

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


        public ActionResult Id(int id)
        {
            var question = _context.Questions.SingleOrDefault(q => q.Id == id);
            if (question == null)
                return HttpNotFound();
            return View(question);
        }

        public ActionResult MasterList()
        {
            var questions = _context.Questions.ToList();
            if (questions == null)
                return HttpNotFound();
            var viewModel = new QuestionsListViewModel
            {
                QuestionList = questions
            };

            return View(viewModel);
        }

        public ActionResult _QuestionSort()
        {
            return View();
        }

        public ActionResult _QuestionNavSort()
        {
            //var techCompany = _context.Questions.
            return PartialView();
        }

    }
}