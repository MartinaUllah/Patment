﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patment.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DateOfBirth { get; set; }

        public StaffType StaffTypeID { get; set; }
    }
}