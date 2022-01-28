using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
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
        private IMemoryCache _cache;
        public CompanyRepository(MozdAsaDbContext ctx, IMemoryCache cache)
        {
            _ctx = ctx;
            _cache = cache;
        }

        public async Task<int> CountCompanies()
        {
            return await _ctx.Companies.CountAsync();
        }

        public IEnumerable<Company> GetCompanies()
        {
            return _ctx.Companies;
        }

        public Company GetCompanyById(int CompanyId)
        {
            var cacheCompany = _cache.Get<Company>(CompanyId);
            if (cacheCompany != null)
            {
                return cacheCompany;
            }
            else
            {
                var company = _ctx.Companies.Find(CompanyId);
                var cacheOption = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(60));
                _cache.Set(CompanyId, company, cacheOption);
                return company;
            }
        }
    }
}
