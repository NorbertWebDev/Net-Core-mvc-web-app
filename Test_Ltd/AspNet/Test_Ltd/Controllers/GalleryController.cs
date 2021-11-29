using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test_Ltd.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ILogger<GalleryController> _logger;
        private readonly string Title = "Test_Ltd. - Gallery";
        private readonly string Location = "Gallery";

        public GalleryController(ILogger<GalleryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Gallery()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            return View();
        }
    }
}
