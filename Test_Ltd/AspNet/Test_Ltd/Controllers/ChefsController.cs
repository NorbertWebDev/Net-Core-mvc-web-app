using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test_Ltd.Controllers
{
    public class ChefsController : Controller
    {
        private readonly ILogger<ChefsController> _logger;
        private readonly string Title = "Test_Ltd. - Chefs";
        private readonly string Location = "Chefs";

        public ChefsController(ILogger<ChefsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Chefs()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            return View();
        }
    }
}
