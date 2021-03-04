using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SelfAssessment.Registration.Api.Models;

namespace SelfAssessment.Registration.Api.Pages.TaxPayer
{
    public class OrganisationModel : PageModel
    {
        [BindProperty]
        public OrganisationVm organisation { get; set; }
        public void OnGet()
        {
            organisation = new OrganisationVm();
        }
    }
}
