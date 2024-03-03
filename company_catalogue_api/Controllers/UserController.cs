using System;
using company_catalogue_api.Dao;
using company_catalogue_api.Models;
using company_catalogue_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace company_catalogue_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
		{
            _userService = userService;
		}

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDAO userDAO)
        {
            try
            {
                // Gọi phương thức Register trong IUserService để xử lý đăng ký người dùng
                User? user = await _userService.Register(userDAO);

                // Trả về dữ liệu người dùng đã đăng ký thành công
                return Ok(user);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDAO login)
        {
            try
            {
                // Gọi phương thức Register trong IUserService để xử lý đăng ký người dùng
                string jwtToken = await _userService.Login(login);

                // Trả về dữ liệu người dùng đã đăng ký thành công
                return Ok(new { jwtToken });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

