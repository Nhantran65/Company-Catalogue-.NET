using company_catalogue_api.Models;
using Microsoft.EntityFrameworkCore;

namespace company_catalogue_api.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly BookingDoctorContext _context;

        public RoleRepository(BookingDoctorContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> GetRoleById(int id)
        {
            return await _context.Roles.FindAsync(id);
        }

        public async Task<Role> CreateRole(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }

        public async Task<Role> UpdateRole(Role role)
        {
            _context.Entry(role).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleExists(role.Id))
                {
                    throw new KeyNotFoundException();
                }
                else
                {
                    throw;
                }
            }

            return role;
        }

        public async Task DeleteRole(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role == null)
            {
                throw new KeyNotFoundException();
            }

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
        }

        private bool RoleExists(int id)
        {
            return _context.Roles.Any(r => r.Id == id);
        }

    }
}
