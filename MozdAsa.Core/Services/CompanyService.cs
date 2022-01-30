using MozdAsa.Core.Interfaces;
using MozdAsa.Core.ViewModels;
using MozdAsa.Domain.Entity;
using MozdAsa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.Core.Services
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public Task<Company> AddCompany(Company company)
        {
            Task<Company> com = _companyRepository.AddCompany(company);
            return com;
        }

        public CompanyViewModel GetCompany()
        {
            return new CompanyViewModel()
            {
                companies = _companyRepository.GetCompanies()
            };
        }

        public Company GetCompanyById(int CompanyId)
        {
            Company company = _companyRepository.GetCompanyById(CompanyId);
            return company;
        }

        public int GetCount()
        {
            return _companyRepository.CountCompanies();
        }

        public Task<bool> IsExists(int CompanyId)
        {
            Task<bool> company = _companyRepository.IsExists(CompanyId);
            return company;
        }

        public Task<Company> RemoveCompany(int CompanyId)
        {
            Task<Company> company = _companyRepository.RemoveCompany(CompanyId);
            return company; 
        }

        public Task<Company> UpdateCompany(Company company)
        {
            Task<Company> com = _companyRepository.UpdateCompany(company);
            return com;
        }
    }
}
