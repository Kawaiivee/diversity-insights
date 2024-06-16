using System.ComponentModel;
namespace DiversityInsights.Models.Enums
{
    public enum Weight
    {
        [Description("Underweight")]
        Underweight = 0,
        [Description("Normal")]
        Normal = 1,
        [Description("Overweight")]
        Overweight = 2,
    }
}