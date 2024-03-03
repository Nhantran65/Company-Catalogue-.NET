using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace company_catalogue_api.Models;
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("first_name")]
        [Required(ErrorMessage = " Name is required")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        [Required(ErrorMessage = "Last N is required")]
        public string? LastName { get; set; }

        [Column("email")]
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(255)]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }

        [Column("password_hash")]
        [Required(ErrorMessage = "Password is required")]
        public string? PasswordHash { get; set; }

        [Column("role_id")]
        [Required(ErrorMessage = "Role ID is required")]
        public int? RoleId { get; set; }

        [Key]
        [ForeignKey("RoleId")]
        public virtual Role? Role { get; set; }

        [Column("profile_picture")]
        public string? ProfilePicture { get; set; }

        [Column("bio")]
        public string? Bio { get; set; }
    }

