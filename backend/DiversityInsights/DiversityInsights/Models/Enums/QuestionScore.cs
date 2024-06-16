using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum QuestionScore
    {
        [Description("None")]
        None = 0,
        [Description("Positive")]
        Positive = 1,
        [Description("Negative")]
        Negative = 2,
    }
}
