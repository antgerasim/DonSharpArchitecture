using System;

namespace DonSharpLite.Domain
{
    /// <summary>
    /// All powers of 2 so we can OR them to combine role permissions.
    /// </summary>
    [Flags]
    public enum RoleType
    {
        Administrator = 1,
        Manager = 2,
        SupportStaff = 4
    }
}