using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace RefineModels.Models.Identity
{
    public class LoginModelView
    {
        [Required(ErrorMessage = "Username or Email is required.")]
        public string UsernameOrEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}
