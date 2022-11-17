using Microsoft.AspNetCore.Mvc;
using System;

namespace API_Borrowed_Items_List.Controllers
{
    public class AppointmentController : Controller
    {
        /*

        public IActionResult Index()
        {
            return View();
            //string todaysDate = DateTime.Now.ToShortDateString();
            //return Ok(to);
        }

        public IActionResult Details(int id)
        {
            return Ok("You have entered id = " + id);
        }

        */

        [HttpPost]
        public IActionResult AddAppointment([FromHeader] string parentRequestId)
        {
            return Ok($"Got a header with parentRequestId: {parentRequestId}");
        }
    }
}
