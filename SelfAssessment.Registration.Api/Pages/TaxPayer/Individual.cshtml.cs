using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SelfAssessment.Registration.Api.Models;

namespace SelfAssessment.Registration.Api.Pages.TaxPayer
{
    public class IndividualModel : PageModel
    {
        [BindProperty]
        public IndividualRegisterVm individual { get; set; }

        public void OnGet()
        {
            individual = new IndividualRegisterVm();
        }
    }
}
