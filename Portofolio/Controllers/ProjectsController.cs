using Microsoft.AspNetCore.Mvc;

namespace Portofolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
