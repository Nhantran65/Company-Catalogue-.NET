using System;
using company_catalogue_api.Models;
using Microsoft.EntityFrameworkCore;

namespace company_catalogue_api.Repositories
{
	public class CompanyRepository : ICompanyRepository
	{
        private readonly BookingDoctorContext _context;

        public CompanyRepository(BookingDoctorContext context)
		{
            _context = context;
		}

        public async Task<IEnumerable<Company?>> GetAllCompanies()
        {
            return await _context.Companies.ToListAsync();
        }

        public async Task<Company?> GetCompanyById(int id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public async Task<Company?> CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return company;
        }

        public async Task<Company?> UpdateCompany(int id, Company company)
        {
            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(company.Id))
                {
                    throw new KeyNotFoundException();
                }
                else
                {
                    throw;
                }
            }

            return company;
        }

        public async Task DeleteCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                throw new KeyNotFoundException();
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }
    }
}

