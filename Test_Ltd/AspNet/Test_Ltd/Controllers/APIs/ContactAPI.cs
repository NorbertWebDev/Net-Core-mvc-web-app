using Microsoft.AspNetCore.Mvc;
using ContactApiController.Models;
using MySqlController.Controllers;
using ValidationController.Controllers;

namespace ContactApiController.Controllers
{
    [ApiController]
    [Route("ContactApi")]
    public class ContactApiController : ControllerBase
    {
        // Define the result of the current validtion process
        private new dynamic[] Response = {"", "", "", ""};

        // Create a contact item in the database
        [HttpPost]
        [ActionName("ContactCreate")]
        public ActionResult ContactCreate([FromForm]ContactModel contact)
        {
            /* 
             * Create a generalValidations object instance
             * Run validate processes what is depend on the values
            */
            if (ModelState.IsValid)
            {
                generalValidations Validator = new generalValidations();
                Response[0] = Validator.runGeneralValidations("FullName", contact.FullName, "string", 0, 200);
                Response[1] = Validator.runGeneralValidations("Email", contact.Email, "string", 0, 400);
                Response[2] = Validator.runGeneralValidations("Subject", contact.Subject, "string", 0, 200);
                Response[3] = Validator.runGeneralValidations("Message", contact.Message, "string", 1, 65535);

                /*
                 * Create a MySqlDatabase object instance
                 * Run the insert a contact row to the related database table
                */
                MySqlDatabase Database = new MySqlDatabase();
                Database.insertContactEntry(contact.FullName, contact.Email, contact.Subject, contact.Message);

                return Ok(new { status = "done", data = Response, text = "Your message sent to us, and we'll be contat you as soon as possible."});
            }
            else
            {
                return BadRequest(new { status = "error", text = "Your message can't be sent, and please try again later. Thank you for your patience."});
            }
        }
    }
}
