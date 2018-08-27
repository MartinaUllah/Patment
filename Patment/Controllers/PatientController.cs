using System.Web.Mvc;
using Patment.Models;
using Patment.Repository;

namespace Patment.Controllers
{
    public class PatientController : Controller
    {
        [HttpGet]
        public ActionResult AddPatient()
        {
            var patient = new Patient();
            return View(patient);
        }

        [HttpPost]
        public ActionResult CreatePatient(Patient patient)
        {
            var repo = new PatientRepository();
            repo.InsertPatient(patient);
            return View();
        }

        [HttpGet]
        public ActionResult AllPatients()
        {
            var repo = new PatientRepository();
            var patients = repo.AllPatients();
            return View(patients);
        }

        [HttpGet]
        //Details
        public ActionResult DetailsOfPatient(int patientId)
        {
            var repo = new PatientRepository();
            var detailPatient = repo.PatientDetail(patientId);
            return View(detailPatient);
        }

        [HttpGet]
        //Update
        public ActionResult GettingPatientDetails(int patientID)
        {
            var repo = new PatientRepository();
            var patientDetails = repo.GetPatientDetails(patientID);
            return View(patientDetails);
        }

        [HttpPut]
        public ActionResult UpdateConfirmation(Patient patient)
        {
            var repo = new PatientRepository();
            var updatedPatient = repo.UpdateOfPatient(patient);
            return View(updatedPatient);
        }

        [HttpDelete]
        public ActionResult DeletePatient(int patientID)
        {
            var repo = new PatientRepository();
            repo.DeletePatient(patientID);
            return View();
        }
    }
}