using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MozdAsa.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MozdAsaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger, ICompanyService companyService)
        {
            _logger = logger;
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            var result = new ObjectResult(_companyService.GetCompany())
            {
                StatusCode = (int)HttpStatusCode.OK
            };
 
            return result;
           
        }
    }
}
