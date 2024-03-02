using System.ComponentModel.DataAnnotations;

namespace company_catalogue_api.Dao
{
    public class RoleDAO
    {
        [Required(ErrorMessage = "name is required")]
        public string? Name { get; set; }
    }
}
