using AbVision.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AbVision.Controllers
{
    public class AbController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Course()
        {
            return View();
        }
         public IActionResult About()
        {
            return View();
        }

        
        
    }
}