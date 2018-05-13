﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.Models.DataContracts
{
    public class TangentUser
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_active { get; set; }
        public bool is_staff { get; set; }
        public bool is_superuser { get; set; }
    }
}