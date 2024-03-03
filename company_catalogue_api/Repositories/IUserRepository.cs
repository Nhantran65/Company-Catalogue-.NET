using System;
using company_catalogue_api.Dao;
using company_catalogue_api.Models;

namespace company_catalogue_api.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetById(int id);

        Task<User?> GetByFirstName(string FirstName);

        Task<User?> GetByEmail(string email);

        Task<User?> Create(UserDAO userd);

        Task<string?> Login(LoginDAO login);

    }
}

