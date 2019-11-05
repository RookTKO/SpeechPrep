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
        public bool Favorite { get; set; }
        public bool SavedForLater { get; set; }
        public bool Completed { get; set; }

        //TODO: Either use enums for question state or use methods.
        //public static bool IsFavoritedQuestion()
        //{
        //    return true;
        //}
        //public static bool IsSavedQuestion()
        //{
        //    return true;
        //}
    }
}