using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum PhysicalDisability
    {
        [Description("None")]
        None = 0,
        [Description("Mute")]
        Mute = 1,
        [Description("Deaf")]
        Deaf = 2,
        [Description("Blind")]
        Blind = 3,
        [Description("Immobile")]
        Immobile = 4
    }
}