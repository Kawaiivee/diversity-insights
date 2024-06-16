using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum GeographicLocation
    {
        [Description("Urban")]
        Urban = 0,
        [Description("Suburban")]
        Suburban = 1,
        [Description("Country")]
        Country = 2
    }
}