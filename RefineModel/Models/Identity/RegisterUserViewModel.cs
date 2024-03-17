using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RefineModels.Models.Identity
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters.", MinimumLength = 3)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }




    }
}
