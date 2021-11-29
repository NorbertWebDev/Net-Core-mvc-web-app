using System;
using Microsoft.AspNetCore.Mvc;
using BookingApiController.Models;
using MySqlController.Controllers;
using ValidationController.Controllers;

namespace BookingApiController.Controllers
{
    [ApiController]
    [Route("BookingApi")]
    public class BookingApiController : ControllerBase
    {
        // Define the result of the current validtion process
        private new dynamic[] Response = {"", "", "", "", "", "", ""};

        // Create a booking item in the database
        [HttpPost]
        [ActionName("BookingCreate")]
        public ActionResult BookingCreate([FromForm]BookingModel booking)
        {
            if(ModelState.IsValid)
            {
                /* 
                 * Create a generalValidations object instance
                 * Run validate processes what is depend on the values
                */
                generalValidations Validator = new generalValidations();
                Response[0] = Validator.runGeneralValidations("FullName", booking.FullName, "string", 0, 200);
                Response[1] = Validator.runGeneralValidations("Email", booking.Email, "string", 0, 400);
                Response[2] = Validator.runGeneralValidations("PhoneOrMobile", booking.PhoneOrMobile, "string", 12, 13);
                Response[3] = Validator.runGeneralValidations("Date", booking.Date.ToString(), "string", 19, 20);
                Response[4] = Validator.runGeneralValidations("Time", booking.Time.ToString(), "string", 8, 8);
                Response[5] = Validator.runGeneralValidations("Persons", Convert.ToInt32(booking.Persons), "int", 0, 255);
                Response[6] = Validator.runGeneralValidations("Message", booking.Message, "string", 1, 65535);

                // Put together the final DateTime value for database
                booking.Date = booking.Date.Add(booking.Time);

                /*
                 * Create a MySqlDatabase object instance
                 * Run the insert a booking row to the related database table
                */
                MySqlDatabase Database = new MySqlDatabase();
                Database.insertBookingEntry(booking.FullName, booking.Email, booking.PhoneOrMobile, booking.Date, booking.Persons, booking.Message);

                return Ok(new { status = "done", text = "The booking is active, and thank you for choosing us!"});
            }
            else
            {
                return BadRequest(new { status = "error", text = "The booking can't be made, and please try again later. Thank you for your patience."});
            }
        }
    }
}
