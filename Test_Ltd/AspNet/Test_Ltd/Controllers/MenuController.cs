using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test_Ltd.Controllers;
using MySqlController.Controllers;

namespace MenuController.Controllers
{
    public class MenuController : Controller
    {
        private readonly ILogger<MenuController> _logger;
        private readonly string Title = "Test_Ltd. - Menu";
        private readonly string Location = "Menu";

        public MenuController(ILogger<MenuController> logger)
        {
            _logger = logger;
        }

        public IActionResult Menu()
        {
            ViewBag.Location = Location;
            ViewBag.Title = Title;

            // Create a CommonController object instance, and get the name of the company
            ViewBag.CompanyName = new CommonController().CompanyName;

            // Create a MySqlDatabase object instance
            MySqlDatabase Database = new MySqlDatabase();
            // Get the menu rows from the database
            ArrayList MenuItems = Database.getAllMenuItems();

            TempData["Menu"] = MenuItems;

            return View();
        }
    }
}
