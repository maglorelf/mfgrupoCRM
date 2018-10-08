using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace mfgrupoCRM.Controllers
{
    public partial class DialogController : Controller
    {
        //
        // GET: /DialogDefault/
        public ActionResult DialogFeatures()
        {
           ViewBag.button = new
            {
                content = "Learn More",
                isPrimary = true
            };
            return View();
        }
    }
}
