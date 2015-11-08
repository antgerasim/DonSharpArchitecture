using System.ComponentModel.DataAnnotations;
using DonSharpLite.Domain.Utilities;

namespace DonSharpLite.Tasks.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Employee number must be provided")]
        [Display(Name = "Employee Number")]
        public string EmployeeNumber { get; set; }

        [Required(ErrorMessage = "Password must be provided")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public string GetPasswordHash()
        {
            return Hasher.Hash(Password);
        }
    }
}