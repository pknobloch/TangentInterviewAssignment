using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.Models.DataContracts
{
    public class TangentEmployee
    {
        public TangentUser user { get; set; }
        public TangentPosition position { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string github_user { get; set; }
        public string birth_date { get; set; }
        public string gender { get; set; }
        public string race { get; set; }
        public int years_worked { get; set; }
        public int age { get; set; }
        public int days_to_birthday { get; set; }
    }
}