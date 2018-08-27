using System.Web.Mvc;
using Patment.Models;
using Patment.Repository;

namespace Patment.Controllers
{
    public class AppointmentController : Controller
    {
        [HttpGet]
        public ActionResult AddAppointment()
        {
            var appointment = new Appointment();
            var repo = new AppointmentRepository();
            appointment.Staff = repo.GetAllStaff();
            appointment.AppointmentTimes = repo.GetAllAppointments();

            return View(appointment);
        }

        [HttpPost]
        public ActionResult CreateAppointment(Appointment appointment)
        {
            var repo = new AppointmentRepository();
            repo.InsertAppointment(appointment);

            return View();
        }
    }
}

