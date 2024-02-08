using Microsoft.AspNetCore.Mvc;
using Mission5_Costley.Models;
using System.Diagnostics;

namespace Mission5_Costley.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace YourNamespace.Controllers
    {
        public class HomeController : Controller
        {
            // Action method for the home page
            public IActionResult Index()
            {
                return View();
            }

            // Action method for the calculator page
            public IActionResult Calculator()
            {
                return View();
            }
        }
    }

}
