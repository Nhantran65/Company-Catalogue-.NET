using System;
using System.ComponentModel.DataAnnotations;

namespace company_catalogue_api.Dao
{
    public class UserDAO
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? PasswordHash { get; set; }

        [Required(ErrorMessage = "RoleId is required")]
        public int RoleId { get; set; } // Assuming RoleId is the foreign key for Role

        public string? ProfilePicture { get; set; }

        public string? Bio { get; set; }
    }
}

