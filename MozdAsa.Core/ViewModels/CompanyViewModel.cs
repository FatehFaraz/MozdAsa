using MozdAsa.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MozdAsa.Core.ViewModels
{
    public class CompanyViewModel
    {
        public IEnumerable<Company> companies { get; set; }
    }
}
