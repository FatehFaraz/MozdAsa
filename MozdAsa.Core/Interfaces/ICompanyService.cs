using MozdAsa.Core.ViewModels;
using MozdAsa.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.Core.Interfaces
{
    public interface ICompanyService
    {
        CompanyViewModel GetCompany();
        Company GetCompanyById(int CompanyId);
        int GetCount();
        Task<bool> IsExists(int CompanyId);
        Task<Company> RemoveCompany(int CompanyId);
        Task<Company> AddCompany(Company company);
        Task<Company> UpdateCompany(Company company);
    }
}
