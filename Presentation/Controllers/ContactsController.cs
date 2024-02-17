using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
