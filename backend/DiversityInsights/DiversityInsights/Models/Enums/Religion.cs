using System.ComponentModel;

namespace DiversityInsights.Models.Enums
{
    public enum Religion
    {
        [Description("None")]
        None = 0,
        [Description("Western Church")]
        WesternChurch = 1,
        [Description("Eastern Orthodox")]
        EasternOrthodox = 2,
        [Description("Atheist")]
        Atheist = 3,
        [Description("Agnostic")]
        Agnostic = 4
    }
}