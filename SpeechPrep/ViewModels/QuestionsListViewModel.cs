using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpeechPrep.Models;

namespace SpeechPrep.ViewModels
{
    public class QuestionsListViewModel
    {
        public IEnumerable<Question> Questions { get; set; }
    }
}