using MozdAsa.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(int CompanyId);
        int CountCompanies();
        Task<bool> IsExists(int CompanyId);
        Task<Company> AddCompany(Company company);
        Task<Company> UpdateCompany(Company company);
        Task<Company> RemoveCompany(int CompanyId);
    }
}
