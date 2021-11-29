using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test_Ltd.Controllers
{
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;
        private readonly string Title = "Test_Ltd. - Booking";
        private readonly string Location = "Booking";

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Booking()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            return View();
        }
    }
}
