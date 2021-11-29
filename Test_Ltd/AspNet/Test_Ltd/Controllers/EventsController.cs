using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test_Ltd.Controllers
{
    public class EventsController : Controller
    {
        private readonly ILogger<EventsController> _logger;
        private readonly string Title = "Test_Ltd. - Events";
        private readonly string Location = "Events";

        public EventsController(ILogger<EventsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Events()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            return View();
        }
    }
}
