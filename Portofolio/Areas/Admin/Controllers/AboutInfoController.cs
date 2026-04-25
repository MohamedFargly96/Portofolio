using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portofolio.Databse;
using Portofolio.Models;

namespace Portofolio.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutInfoController : Controller
    {
        private readonly AppContext_Cls _context;

        public AboutInfoController(AppContext_Cls context)
        {
            _context = context;
        }

     
        public IActionResult Index()
        {
            var info = _context.AboutDbset.SingleOrDefault();
            if (info == null)
            {
                return View(new About_Cls());
            }

            return View(info);
        }

        [HttpPost]
        public IActionResult Save(About_Cls model)
        {
            var exist = _context.AboutDbset.Find(model.Id);
            if (exist != null)
            {
                //edit
                exist.Description = model.Description;
                _context.SaveChanges();
            }
            else
            {
                //insert
                var DevInfo = _context.AboutDbset.Add(model);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var exist = _context.AboutDbset.Find(id);
            if (exist != null)
            {
                _context.AboutDbset.Remove(exist);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
