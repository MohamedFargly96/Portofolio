using Microsoft.AspNetCore.Mvc;

namespace Portofolio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
