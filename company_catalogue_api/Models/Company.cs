using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace company_catalogue_api.Models
{
    [Table("company")]
    public class Company
	{
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Company name is required.")]
        [StringLength(255, ErrorMessage = "Company name cannot exceed 255 characters.")]
        [Column("name")]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("location")]
        public string? Location { get; set; }

        [Url(ErrorMessage = "Invalid website URL.")]
        [Column("website")]
        public string? Website { get; set; }

        [Url(ErrorMessage = "Invalid image URL.")]
        [Column("logo")]
        public string? Logo { get; set; }

        [StringLength(255, ErrorMessage = "Industry cannot exceed 255 characters.")]
        [Column("industry")]
        public string? Industry { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Invalid established date.")]
        [Column("established")]
        public DateTime? Established { get; set; }

        [Column("other_details")]
        public string? OtherDetails { get; set; }
    }
}

