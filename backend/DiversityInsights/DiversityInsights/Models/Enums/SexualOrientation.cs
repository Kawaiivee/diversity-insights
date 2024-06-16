using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum SexualOrientation
    {
        [Description("Straight")]
        Straight = 0,
        [Description("Gay")]
        Gay = 1,
        [Description("Lesbian")]
        Lesbian = 2,
        [Description("Bisexual")]
        Bisexual = 3,
        [Description("Asexual")]
        Asexual = 4
    }
}