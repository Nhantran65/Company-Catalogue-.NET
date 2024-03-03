using company_catalogue_api.Attributes; // Import namespace chứa JwtAuthorizeAttribute
using company_catalogue_api.Models;
using company_catalogue_api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; // Thêm namespace này
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;


namespace company_catalogue_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [JwtAuthorize] // Sử dụng JwtAuthorizeAttribute thay vì Authorize
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IConfiguration _configuration; // Thêm IConfiguration vào đây

        public RolesController(IRoleService roleService, IConfiguration configuration) // Thêm IConfiguration vào đây
        {
            _roleService = roleService;
            _configuration = configuration; // Lưu lại IConfiguration
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            var roles = await _roleService.GetAllRoles();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetRole(int id)
        {
            try
            {
                var role = await _roleService.GetRoleById(id);
                return Ok(role);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [JwtAuthorize] // Sử dụng JwtAuthorizeAttribute thay vì Authorize
        public async Task<ActionResult<Role>> PostRole(Role role)
        {
            try
            {
                var newRole = await _roleService.CreateRole(role);
                return CreatedAtAction(nameof(GetRole), new { id = newRole.Id }, newRole);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        [JwtAuthorize] // Sử dụng JwtAuthorizeAttribute thay vì Authorize
        public async Task<IActionResult> PutRole(int id, Role role)
        {
            try
            {
                await _roleService.UpdateRole(id, role);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        [JwtAuthorize] // Sử dụng JwtAuthorizeAttribute thay vì Authorize
        public async Task<IActionResult> DeleteRole(int id)
        {
            try
            {
                await _roleService.DeleteRole(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
