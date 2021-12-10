using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowFundingMvc.Models;

namespace CrowFundingMvc.Controllers
{
    public class UserController : Controller
    {
       /* private readonly CrmDbContext UserCrm = new();*/
        public IActionResult Registration()
        {
            return View();
        }


    }
}
