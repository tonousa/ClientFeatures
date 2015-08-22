using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientFeatures.Models;

namespace ClientFeatures.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult MakeBooking()
        {
            return View(new Appointment
            {
                ClientName = "Adam"j,
                Date = DateTime.Now.AddDays(2),
                TermsAccepted = true
            });
        }

        [HttpDelete]
        public JsonResult MakeBooking(Appointment appt)
        {
            // Code to store appt in repository
            return Json(appt, JsonRequestBehavior.AllowGet);
        }

    }
}
