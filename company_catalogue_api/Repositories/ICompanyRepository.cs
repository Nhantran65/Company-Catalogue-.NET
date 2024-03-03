using System;
using company_catalogue_api.Models;

namespace company_catalogue_api.Repositories
{
	public interface ICompanyRepository
	{
        Task<IEnumerable<Company?>> GetAllCompanies();
        Task<Company?> GetCompanyById(int id);
        Task<Company?> CreateCompany(Company company);
        Task<Company?> UpdateCompany(int id, Company company);
        Task DeleteCompany(int id);
    }
}

