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
    }
}
