using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patment.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int NhsNumber { get; set; }
    }
}