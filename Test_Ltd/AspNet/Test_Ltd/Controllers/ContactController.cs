using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test_Ltd.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly string Title = "Test_Ltd. - Contact";
        private readonly string Location = "Contact";

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        public IActionResult Contact()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            return View();
        }
    }
}
