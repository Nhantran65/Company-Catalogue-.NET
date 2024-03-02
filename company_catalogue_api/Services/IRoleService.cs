using company_catalogue_api.Models;

namespace company_catalogue_api.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAllRoles();
        Task<Role> GetRoleById(int id);
        Task<Role> CreateRole(Role role);
        Task<Role> UpdateRole(int id, Role role);
        Task DeleteRole(int id);
    }
}
