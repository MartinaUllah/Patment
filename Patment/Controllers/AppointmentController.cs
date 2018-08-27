using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Patment.Models;
using Patment.Repository;

namespace Patment.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult AddAppointment()
        {
            var appointment = new Appointment();
            var repo = new AppointmentRepository();
            appointment.Staff = repo.GetAllStaff();
            appointment.AppointmentTimes = repo.GetAllAppointments();
            
            return View(appointment);
        }

        public ActionResult CreateAppointment(Appointment appointment)
        {
            var repo = new AppointmentRepository();
            repo.InsertAppointment(appointment);

            return View();
        }
    }
}

