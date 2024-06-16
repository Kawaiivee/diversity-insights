using System.ComponentModel;
namespace DiversityInsights.Models.Enums
{
    public enum Education
    {
        [Description("None")]
        None = 0,
        [Description("Grade School")]
        GradeSchool = 1,
        [Description("High School")]
        HighSchool = 2,
        [Description("College/University")]
        CollegeUniversity = 3
    }
}