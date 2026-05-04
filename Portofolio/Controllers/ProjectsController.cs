using Microsoft.AspNetCore.Mvc;
using Portofolio.Databse;

namespace Portofolio.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly AppContext_Cls _context;

        public ProjectsController(AppContext_Cls context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context .ProjectsDbset.ToList();
            return View(projects);
        }
    }
}
