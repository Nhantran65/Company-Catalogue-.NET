using company_catalogue_api.Dao;
using company_catalogue_api.Models;

namespace company_catalogue_api.Repositories
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetAllRoles();

        Task<Role> GetRoleById(int id);

        Task<Role> CreateRole(Role role);

        Task<Role> UpdateRole(Role role);

        Task DeleteRole(int id);
    }
}
