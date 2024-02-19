using Application.Interfaces.Contacts;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsBehavior _contactsBehavior;
        public ContactsController(IContactsBehavior contactsBehavior)
        {
            _contactsBehavior = contactsBehavior;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var result = _contactsBehavior.GetAll();
            return View(result);
        }
    }
}
