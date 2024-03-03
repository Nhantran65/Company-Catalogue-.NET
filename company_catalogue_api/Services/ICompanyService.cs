using System;
using company_catalogue_api.Models;

namespace company_catalogue_api.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company?>> GetAllCompanies();
        Task<Company?> GetCompanyById(int id);
        Task<Company?> CreateCompany(Company company);
        Task<Company?> UpdateCompany(int id, Company company);
        Task DeleteCompany(int id);
    }
}

