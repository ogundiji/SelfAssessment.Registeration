using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Api.Controllers
{
    public class TaxpayerController : Controller
    {
        public IActionResult Individual()
        {
            return View();
        }


        public IActionResult organisation()
        {
            return View();
        }
    }
}
