using Five.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Five.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IClock clock)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
