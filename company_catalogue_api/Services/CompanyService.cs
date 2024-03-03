using System;
using company_catalogue_api.Models;
using company_catalogue_api.Repositories;

namespace company_catalogue_api.Services
{
	public class CompanyService : ICompanyService
	{
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
		{
            _companyRepository = companyRepository;
		}

        public async Task<Company?> CreateCompany(Company company)
        {
            return await _companyRepository.CreateCompany(company);
        }

        public async Task DeleteCompany(int id)
        {
            await _companyRepository.DeleteCompany(id);
        }

        public async Task<IEnumerable<Company?>> GetAllCompanies()
        {
            return await _companyRepository.GetAllCompanies();
        }

        public async Task<Company?> GetCompanyById(int id)
        {
            return await _companyRepository.GetCompanyById(id);
        }

        public async Task<Company?> UpdateCompany(int id, Company company)
        {
            company.Id = id;
            return await _companyRepository.UpdateCompany(id, company);
        }
    }
}

