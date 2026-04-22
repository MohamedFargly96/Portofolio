using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portofolio.Databse;
using Portofolio.Models;

namespace Portofolio.Areas.Admin.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly AppContext_Cls _context;

        public HomeController(AppContext_Cls context)
        {
            _context = context;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            var info = _context.HomeDbset.SingleOrDefault();
            if (info == null)
            {
                return View(new Home_Cls());
            }

            return View(info);
        }

        public IActionResult Save(Home_Cls model)
        {
            var exist = _context.HomeDbset.Find(model.Id);
            if(exist != null)
            {
                //edit
                exist.Name = model.Name;
                exist.JobTitle = model.JobTitle;
                exist.Description = model.Description;
                _context.SaveChanges();
            }
            else
            {
                //insert
                var DevInfo = _context.HomeDbset.Add(model);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        public IActionResult Delete (int id)
        {
            var exist = _context.HomeDbset.Find(id);
            if (exist != null)
            {
                _context.HomeDbset.Remove(exist);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
