using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MozdAsa.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MozdAsa.Domain.Entity;

namespace MozdAsaWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            var result = new ObjectResult(_companyService.GetCompany())
            {
                StatusCode = (int)HttpStatusCode.OK
            };
            Request.HttpContext.Response.Headers.Add("X-Count", _companyService.GetCount().ToString());
            Request.HttpContext.Response.Headers.Add("X-Name", "Mohammad Fateh");
            return result;       
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany([FromRoute] int id)
        {
            var company = _companyService.GetCompanyById(id);
            return Ok(company);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCompany([FromRoute] int id)
        {
            await _companyService.RemoveCompany(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddCompany([FromBody] Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _companyService.AddCompany(company);
            return CreatedAtAction("GetCompany", new { id = company.Id }, company);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany([FromRoute] int id, [FromBody] Company company)
        {
            await _companyService.UpdateCompany(company);
           return Ok(company);
        }
    }
}
