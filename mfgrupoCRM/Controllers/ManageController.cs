using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mfgrupoCRM.Models;

namespace mfgrupoCRM.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
