using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Patment.Models;
using Patment.Repository;

namespace Patment.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult AddPatient()
        {
            var patient = new Patient();
            return View(patient);
        }

        public ActionResult CreatePatient(Patient patient)
        {
            var repo = new PatientRepository();
            repo.InsertPatient(patient);
            return View();
        }

        public ActionResult AllPatients()
        {
            var repo = new PatientRepository();
            var patients = repo.AllPatients();
            return View(patients);

        }

        //Details
        public ActionResult DetailsOfPatient(int patientId)
        {
            var repo = new PatientRepository();
            var detailPatient = repo.PatientDetail(patientId);
            return View(detailPatient);
        }


        //Update
        public ActionResult GettingPatientDetails(int patientID)
        {
            var repo = new PatientRepository();
            var patientDetails = repo.GetPatientDetails(patientID);
            return View(patientDetails);
        }

        public ActionResult UpdateConfirmation(Patient patient)
        {
            var repo = new PatientRepository();
            var updatedPatient = repo.UpdateOfPatient(patient);
            return View(updatedPatient);
        }

        public ActionResult DeletePatient(int patientID)
        {
            var repo = new PatientRepository();
            repo.DeletePatient(patientID);
            return View();
        }
    }
}