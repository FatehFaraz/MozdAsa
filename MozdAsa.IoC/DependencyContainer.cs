using Microsoft.Extensions.DependencyInjection;
using MozdAsa.Core.Interfaces;
using MozdAsa.Core.Services;
using MozdAsa.Data.Repository;
using MozdAsa.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ICompanyRepository, CompanyRepository>();
            service.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
