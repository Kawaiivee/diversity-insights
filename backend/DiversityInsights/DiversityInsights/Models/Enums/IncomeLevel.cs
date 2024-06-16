using System.ComponentModel;
namespace DiversityInsights.Models.Enums
{
    public enum IncomeLevel
    {
        [Description("Low")]
        Low = 0,
        [Description("Low Middle")]
        LowMiddle = 1,
        [Description("Middle")]
        Middle = 2,
        [Description("Upper Middle")]
        UpperMiddle = 3,
        [Description("Upper")]
        Upper = 4
    }
}