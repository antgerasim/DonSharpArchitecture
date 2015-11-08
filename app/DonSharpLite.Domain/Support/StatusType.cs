using System.ComponentModel;

namespace DonSharpLite.Domain.Support
{
    public enum StatusType
    {
         New = 1,
        [Description("In Progress")]
        InProgress = 2,
        Resolved = 3
    }
}