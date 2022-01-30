using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MozdAsa.Web.Repository;

namespace MozdAsa.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private CompanyRepository _company;

        public IndexModel(ILogger<IndexModel> logger, CompanyRepository company)
        {
            _logger = logger;
            _company = company;
        }

        //public IEnumerable<Company> OnGet()
        //{
        //    var company = _company.GetAllCompany().ToList();
        //    return View();
        //}
    }
}