using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace mfgrupoCRM.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult MenuFeatures()
        {
	    List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "File",
                iconCss = "e-menu-icons e-file",
                items = new List<object>()
                {
                    new { text= "Open", iconCss= "e-menu-icons e-open" },
                    new { text= "Save", iconCss= "e-icons e-save" },
                    new { separator= true },
                    new { text= "Exit" }
                }
            });
            menuItems.Add(new
            {
                text = "Edit",
                iconCss = "e-menu-icons e-edit",
                items = new List<object>()
                {
                    new { text= "Cut", iconCss= "e-menu-icons e-cut" },
                    new { text= "Copy", iconCss= "e-menu-icons e-copy" },
                    new { text= "Paste", iconCss= "e-menu-icons e-paste" }
                }
            });
            menuItems.Add(new
            {
                text = "View",
                items = new List<object>()
                {
                    new {
                        text = "Toolbars",
                        items = new List<object>()
                        {
                            new { text= "Menu Bar" },
                            new { text= "Bookmarks Toolbar" },
                            new { text= "Customize" }
                        }
                    },
                    new {
                        text = "Zoom",
                        items = new List<object>()
                        {
                            new  { text= "Zoom In" },
                            new { text= "Zoom Out" },
                            new { text= "Reset" },
                        }
                    },
                    new {
                        text = "Full Screen"
                    }
                }
            });
            menuItems.Add(new
            {
                text = "Tools",
                items = new List<object>()
                {
                    new { text= "Spelling & Grammar" },
                    new { text= "Customize" },
                    new { separator= true },
                    new { text= "Options" }
                }
            });
            menuItems.Add(new
            {
                text = "Help",
            });
            ViewBag.menuItems = menuItems;
            return View();
        }
    }
}
