using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Patment.Models;
using Patment.Repository;

namespace Patment.Controllers
{
    public class StaffController : Controller
    {
        public ActionResult AddStaff()
        {
            var staff = new Staff();
            return View(staff);
        }

        public ActionResult CreateStaff(Staff staff)
        {
            var repo = new StaffRepository();
            var repoStaff = repo.InsertStaff(staff);
            return View(repoStaff);
        }

        public ActionResult AllStaff()
        {
            var repo = new StaffRepository();
            var allStaff = repo.GetAllStaff();
            return View(allStaff);
        }

        public ActionResult DetailsOfStaff(int StaffID)
        {
            var repo = new StaffRepository();
            var staffDetail = repo.StaffDetail(StaffID);
            return View(staffDetail);
        }

        //Update
        public ActionResult GettingStaffDetails(int StaffID)
        {
            var repo = new StaffRepository();
            var staffDetails = repo.GettingStaffDetails(StaffID);
            return View(staffDetails);
        }


        public ActionResult UpdateConfirmation(Staff staff)
        {
            var repo = new StaffRepository();
            var updateStudent = repo.UpdateOfStaff(staff);
            return View();
        }

        public ActionResult DeletingOfStaff(int StaffID)
        {
            var repo = new StaffRepository();
            var deleteStaff = repo.DeleteStaff(StaffID);
            return View(deleteStaff);
        }
    }
}