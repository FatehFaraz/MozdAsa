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

        //public CountViewModel GetCount()
        //{
        //    return new CountViewModel()
        //    {
        //        CountCompanies = _companyRepository.CountCompanies()
        //    };
        //}

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

        Company ICompanyService.GetCount()
        {
            throw new NotImplementedException();
        }
    }
}
