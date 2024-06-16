using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum Gender
    {
        [Description("Male")]
        Male = 0,
        [Description("Female")]
        Female = 1,
        [Description("Non-binary/Non-conforming/Other")]
        NonBinaryNonConformingOther = 2
    }
}