using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum Race
    {
        [Description("American Indian or Alaska Native")]
        AmericanIndianOrAlaskanNative = 0,
        [Description("Asian")]
        Asian = 1,
        [Description("Black or African American")]
        BlackOrAfricanAmerican = 2,
        [Description("Native Hawaiian or Other Pacific Islander")]
        NativeHawaiianOrOtherPacificIslander = 3,
        [Description("Two or More Races")]
        TwoOrMoreRaces = 4,
        [Description("White")]
        White = 5,
        [Description("HispanicLatino")]
        HispanicLatino = 6,
    }
}