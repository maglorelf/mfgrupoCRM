using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace mfgrupoCRM.Controllers
{
    public partial class ToastController : Controller
    {
        //
        // GET: /CardDefault/
        public ActionResult ToastFeatures()
        {
            return View();
        }
    }
}
