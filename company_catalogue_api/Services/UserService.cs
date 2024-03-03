using System;
using company_catalogue_api.Dao;
using company_catalogue_api.Models;
using company_catalogue_api.Repositories;

namespace company_catalogue_api.Services
{
	public class UserService : IUserService
	{
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<string?> Login(LoginDAO login)
        {
            var existinguserbyemail = await _repository.GetByEmail(login.Email ?? "");

            if (existinguserbyemail == null)
            {
                throw new ArgumentException("user is not found ");
            }

            //thực hiện login nếu user found
            return await _repository.Login(login); // sử dụng await để chờ hoàn thành phương thức create
        }

        public async Task<User?> Register(UserDAO user)
        {

            var existingUserByEmail = await _repository.GetByEmail(user.Email ?? "");

            if (existingUserByEmail != null)
            {
                throw new ArgumentException("Email already exists");
            }

            //Thực hiện thêm mới user
            return await _repository.Create(user); // Sử dụng await để chờ hoàn thành phương thức Create
        }

    }
}

