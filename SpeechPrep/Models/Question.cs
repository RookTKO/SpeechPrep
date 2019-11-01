using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpeechPrep.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string InterviewQuestion { get; set; }
        public string StarType { get; set; }
    }
}