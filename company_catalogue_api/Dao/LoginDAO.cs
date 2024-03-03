using System;
using System.ComponentModel.DataAnnotations;

namespace company_catalogue_api.Dao
{
    public class LoginDAO
    {

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = " ";

        [Required(ErrorMessage = "Password is required")]
        public string PasswordHash { get; set; } = " ";


    }
}

