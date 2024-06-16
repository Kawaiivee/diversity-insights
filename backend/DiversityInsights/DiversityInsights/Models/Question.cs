using DiversityInsights.Models.Enums;

namespace DiversityInsights.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public QuestionScore Score { get; set; }
    }
}
