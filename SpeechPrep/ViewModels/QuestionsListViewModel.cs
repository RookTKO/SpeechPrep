using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpeechPrep.Models;

namespace SpeechPrep.ViewModels
{
    public class QuestionsListViewModel
    {
        public IEnumerable<Question> QuestionList { get; set; }

        //TODO : Add profile model into modelview so users don't have issue logining in.
    }
}