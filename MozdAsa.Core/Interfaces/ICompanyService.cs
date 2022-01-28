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
        Company GetCount();
    }
}
