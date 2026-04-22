using Microsoft.AspNetCore.Mvc;

namespace Portofolio.Controllers
{
    public class TutorialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
