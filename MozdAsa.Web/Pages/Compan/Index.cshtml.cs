using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MozdAsa.Web.Repository;

namespace MozdAsa.Web.Pages.Compan
{
    public class IndexModel : PageModel
    {
        private CompanyRepository _companyRepository;
        public IndexModel(CompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<IActionResult> OnGet()
        {
            //var company = await _companyRepository.GetAllCompany();
            return Page();
        }
    }
}
