using System;
using company_catalogue_api.Dao;
using company_catalogue_api.Models;

namespace company_catalogue_api.Services
{
    public interface IUserService
    {
        Task<User?> Register(UserDAO user);
        // JWT string
        Task<string> Login(LoginDAO login);
    }
}

