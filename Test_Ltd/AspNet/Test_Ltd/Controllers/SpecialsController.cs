using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test_Ltd.Controllers
{
    public class SpecialsController : Controller
    {
        private readonly ILogger<SpecialsController> _logger;
        private readonly string Title = "Test_Ltd. - Specials";
        private readonly string Location = "Specials";

        public SpecialsController(ILogger<SpecialsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Specials()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            return View();
        }
    }
}
