using System.Web.Mvc;
using Patment.Models;
using Patment.Repository;

namespace Patment.Controllers
{
    public class StaffController : Controller
    {
        [HttpGet]
        public ActionResult AddStaff()
        {
            var staff = new Staff();
            return View(staff);
        }

        [HttpPost]
        public ActionResult CreateStaff(Staff staff)
        {
            var repo = new StaffRepository();
            var repoStaff = repo.InsertStaff(staff);
            return View(repoStaff);
        }

        [HttpGet]
        public ActionResult AllStaff()
        {
            var repo = new StaffRepository();
            var allStaff = repo.GetAllStaff();
            return View(allStaff);
        }

        [HttpGet]
        public ActionResult DetailsOfStaff(int StaffID)
        {
            var repo = new StaffRepository();
            var staffDetail = repo.StaffDetail(StaffID);
            return View(staffDetail);
        }

        [HttpGet]
        //Update
        public ActionResult GettingStaffDetails(int StaffID)
        {
            var repo = new StaffRepository();
            var staffDetails = repo.GettingStaffDetails(StaffID);
            return View(staffDetails);
        }

        [HttpPut]
        public ActionResult UpdateConfirmation(Staff staff)
        {
            var repo = new StaffRepository();
            var updateStudent = repo.UpdateOfStaff(staff);
            return View();
        }

        [HttpDelete]
        public ActionResult DeletingOfStaff(int StaffID)
        {
            var repo = new StaffRepository();
            var deleteStaff = repo.DeleteStaff(StaffID);
            return View(deleteStaff);
        }
    }
}