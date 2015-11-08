using System.ComponentModel.DataAnnotations;
using SharpLite.Domain;

namespace DonSharpLite.Domain.Support
{
    public class IssueType : Entity
    {
        [DomainSignature]
        [Required(ErrorMessage = "Name of the issue type must be provided")]
        [StringLength(200,
            ErrorMessage = "Name of the issue type must be 200 characters or fewer")]
        public virtual string Name { get; set; }
    }
}

