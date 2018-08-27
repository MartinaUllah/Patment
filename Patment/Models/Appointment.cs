using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patment.Models
{
    public class Appointment
    {
        public List<SelectListItem> Staff { get; set; }

        public string SelectedStaff { get; set; }

        public List<SelectListItem> AppointmentTimes { get; set; }

        public string SelectedAppointmentTime { get; set; }

        public int PatientID { get; set; }

        public DateTime AppointmentDate { get; set; }
                
    }
}

