using company_catalogue_api.Models;
using company_catalogue_api.Repositories;

namespace company_catalogue_api.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await _roleRepository.GetAllRoles();
        }

        public async Task<Role> GetRoleById(int id)
        {
            var role = await _roleRepository.GetRoleById(id);
            if (role == null)
            {
                throw new KeyNotFoundException();
            }
            return role;
        }

        public async Task<Role> CreateRole(Role role)
        {
            return await _roleRepository.CreateRole(role);
        }

        public async Task<Role> UpdateRole(int id, Role role)
        {
            role.Id = id;
            return await _roleRepository.UpdateRole(role);
        }

        public async Task DeleteRole(int id)
        {
            await _roleRepository.DeleteRole(id);
        }
    }
}
