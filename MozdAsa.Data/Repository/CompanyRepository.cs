using MozdAsa.Data.Context;
using MozdAsa.Domain.Entity;
using MozdAsa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.Data.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private MozdAsaDbContext _ctx;
        public CompanyRepository(MozdAsaDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Company> GetCompanies()
        {
            return _ctx.Companies;
        }
    }
}
