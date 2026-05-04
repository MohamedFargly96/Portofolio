using Microsoft.AspNetCore.Mvc;
using Portofolio.Databse;
using Portofolio.Models;

namespace Portofolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectsController : Controller
    {
        private readonly AppContext_Cls _context;

        public ProjectsController(AppContext_Cls context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.ProjectsDbset.ToList();

            return View(projects);
        }

        //Add New Project
        [HttpPost]
        public IActionResult Create(Projects_Cls project )
        {
            if (ModelState.IsValid)
            {
                _context.ProjectsDbset.Add(project);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View("Index", _context.ProjectsDbset.ToList());
        }
           
        
    }
}
