using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portofolio.Databse;
using Portofolio.Models;

namespace Portofolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContext_Cls _context;

        public HomeController(AppContext_Cls context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var info = _context.HomeDbset.SingleOrDefault();
            if (info == null)
            {
                return View(new Home_Cls());
            }

            return View(info);
        }

        public IActionResult About()
        {
            var about = _context.AboutDbset.SingleOrDefault();
            if(about==null)
            {
                return View(new About_Cls());
            }
            return View(about);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
