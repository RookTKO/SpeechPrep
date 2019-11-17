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
        public TechCompanies Company { get; set; }
        public enum TechCompanies
        {
            Amazon,
            Microsoft,
            Google,
            Facebook,
            Netflix,
            Apple
        }
        public CoreValues Core { get; set; }
        public enum CoreValues
        {
            Leadership,
            Ownership,
            Customer
        }
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